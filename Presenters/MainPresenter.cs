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

namespace WinSMSer.Presenters
{
    public class MainPresenter
    {
        private readonly Views.IMainView view;
        private readonly Services.UsbModemService usbModemService;
        private readonly Services.MessageDatabaseService messageDatabaseService;
        private BackgroundWorker messageSendWorker;

        public MainPresenter(Views.IMainView view, Services.UsbModemService usbModemService, Services.MessageDatabaseService messageDatabaseService)
        {
            this.view = view;
            this.usbModemService = usbModemService;
            this.messageDatabaseService = messageDatabaseService;

            view.Presenter = this;
            usbModemService.Presenter = this;

            UpdatePortList();
            UpdateMessageList();
        }

        public void UpdatePortList()
        {
            string[] availablePorts = usbModemService.GetAvailablePorts();
            view.PortList = availablePorts.ToList();
        }

        public void UpdateMessageList()
        {
            view.MessageList = messageDatabaseService.GetReceivedMessages();
            view.UpdateMessageList();
        }

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

        public void SendMessage(string[] recipients, string message)
        {
            messageSendWorker = new BackgroundWorker();
            messageSendWorker.WorkerReportsProgress = true; 
            messageSendWorker.DoWork += (obj, e) => MessageSendWorker_DoWork(obj, e, recipients, message);
            messageSendWorker.ProgressChanged += MessageSendWorker_ProgressChanged;
            messageSendWorker.RunWorkerCompleted += MessageSendWorker_RunWorkerCompleted;

            messageSendWorker.RunWorkerAsync();
        }

        private void MessageSendWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            view.SendingTaskForm.SendingDone();
        }

        private void MessageSendWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            view.SendingTaskForm.UpdateProgress(e.ProgressPercentage, (int[])e.UserState);
        }

        private void MessageSendWorker_DoWork(object sender, DoWorkEventArgs e, string[] recipients, string message)
        {
            int countAll = recipients.Length;
            int countPending = recipients.Length;
            int countSent = 0;
            int countError = 0;

            messageSendWorker.ReportProgress(0, new int[] {
                countAll, countPending, countSent, countError
            });

            foreach (string recipient in recipients)
            {
                if (usbModemService.SendSms(recipient, message))
                {
                    countSent += 1;
                    countPending -= 1;
                }
                else
                {
                    countError += 1;
                }

                messageSendWorker.ReportProgress((int)((countSent * 100 / countAll)), new int[] { 
                    countAll, countPending, countSent, countError
                });
            }
        }

        public void RefreshMessageList()
        {
            List<Model.Message> messages = usbModemService.GetUnreadMessages();
            messageDatabaseService.AppendMessages(messages);

            UpdateMessageList();
        }

        public void DisconnectModem()
        {
            usbModemService.DisconnectModem();
            view.UpdateStatusBar("Rozłączono");
            view.IsConnected = false;
        }
    }
}
