using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSMSer.Properties;

namespace WinSMSer.Controllers
{
    /// <summary>
    /// Główny kontroler programu
    /// </summary>
    public class MainController
    {
        private readonly Views.IMainView view;
        private readonly Services.UsbModemService usbModemService;
        private readonly Services.MessageDatabaseService messageDatabaseService;
        private BackgroundWorker messageSendWorker;

        public MainController(Views.IMainView view, Services.UsbModemService usbModemService, Services.MessageDatabaseService messageDatabaseService)
        {
            this.view = view;
            this.usbModemService = usbModemService;
            this.messageDatabaseService = messageDatabaseService;

            view.Controller = this;
            usbModemService.Controller = this;

            // odświeżanie listy portów i wiadomości przy uruchomieniu programu
            UpdatePortList();
            UpdateMessageList();
        }

        /// <summary>
        /// Odświeżenie listy dostępnych portów
        /// </summary>
        public void UpdatePortList()
        {
            string[] availablePorts = usbModemService.GetAvailablePorts();
            view.PortList = availablePorts.ToList();
        }

        /// <summary>
        /// Odświeżenie listy wiadomości SMS w skrzynce
        /// </summary>
        public void UpdateMessageList()
        {
            view.MessageList = messageDatabaseService.GetAllMessages();
            view.UpdateMessageList();
        }

        /// <summary>
        /// Inicjuje połączenie z modemem na podanym porcie i ewentualnie z numerem PIN
        /// </summary>
        public void SetPort(string port, string pin)
        {
            try
            {
                if (usbModemService.SelectPort(port, pin))
                {
                    view.UpdateStatusBar(String.Format(Resources.ConnectedWithModemOnPort, usbModemService.ModemInfo, port));
                }
                else
                {
                    view.ShowError(Resources.DefaultConnectionError);
                }

                view.IsConnected = true;
            }
            catch (Exception e)
            {
                view.ShowError(e.Message);
            }
        }

        /// <summary>
        /// Wysyła wiadomość do podanej grupy odbiorców
        /// </summary>
        public void SendMessage(string[] recipients, string message)
        {
            messageSendWorker = new BackgroundWorker();
            messageSendWorker.WorkerReportsProgress = true; 
            messageSendWorker.DoWork += (obj, e) => MessageSendWorker_DoWork(obj, e, recipients, message);
            messageSendWorker.ProgressChanged += MessageSendWorker_ProgressChanged;
            messageSendWorker.RunWorkerCompleted += MessageSendWorker_RunWorkerCompleted;

            messageSendWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Funkcja wywoływana po zakończeniu asynchronicznego wysyłania wiadomości
        /// </summary>
        private void MessageSendWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            view.SendingTaskForm.SendingDone();
        }

        /// <summary>
        /// Raportowanie o postępach asynchronicznego wysyłania wiadomości
        /// </summary>
        private void MessageSendWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            view.SendingTaskForm.UpdateProgress(e.ProgressPercentage, (int[])e.UserState);
        }

        /// <summary>
        /// Funkcja wywoływana asynchronicznie, wysyła wiadomości SMS do grupy odbiorców
        /// </summary>
        private void MessageSendWorker_DoWork(object sender, DoWorkEventArgs e, string[] recipients, string content)
        {
            int countAll = recipients.Length;
            int countPending = recipients.Length;
            int countSent = 0;
            int countError = 0;

            messageSendWorker.ReportProgress(0, new int[] {
                countAll, countPending, countSent, countError
            });


            List<Model.Message> messages = new List<Model.Message>();

            messageDatabaseService.AppendMessages(messages);
            foreach (string recipient in recipients)
            {
                if (usbModemService.SendSms(recipient, content))
                {
                    countSent += 1;
                    countPending -= 1;

                    Model.Message message = new Model.Message();
                    message.Type = Model.MessageType.Sent;
                    message.Recipent = recipient;
                    message.Date = DateTime.Now;
                    message.Content = content.Trim();

                    messages.Add(message);
                }
                else
                {
                    countError += 1;
                }

                messageSendWorker.ReportProgress((int)((countSent * 100 / countAll)), new int[] { 
                    countAll, countPending, countSent, countError
                });
            }

            // zapisuje wysłane wiadomości w skrzynce "Wysłane"
            messageDatabaseService.AppendMessages(messages);
        }

        /// <summary>
        /// Odświeża listę wiadomości poprzez pobranie z modemu nieprzeczytanych SMS
        /// </summary>
        public void RefreshMessageList()
        {
            List<Model.Message> messages = usbModemService.GetUnreadMessages();
            messageDatabaseService.AppendMessages(messages);

            UpdateMessageList();
        }

        /// <summary>
        /// Zamyka połączenie z modemem
        /// </summary>
        public void DisconnectModem()
        {
            usbModemService.DisconnectModem();
            view.UpdateStatusBar(Resources.Disconnected);
            view.IsConnected = false;
        }
    }
}
