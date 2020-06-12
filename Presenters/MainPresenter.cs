using System;
using System.Collections.Generic;
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
            if (usbModemService.SendSms(recipients, message))
            {
                view.ShowError("Wysłano");
            }
            else
            {
                view.ShowError("Nie udało się wysłać wiadomości");
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
            view.UpdateStatusBar("");
            view.IsConnected = false;
        }
    }
}
