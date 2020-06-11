using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WinSMSer.Properties;

namespace WinSMSer.Presenters
{
    public class MainPresenter
    {
        private readonly Views.IMainView view;
        private readonly Services.UsbModemService usbModemService;

        public MainPresenter(Views.IMainView view, Services.UsbModemService usbModemService)
        {
            this.view = view;
            this.usbModemService = usbModemService;

            view.Presenter = this;
            usbModemService.Presenter = this;

            UpdatePortList();
        }

        public void UpdatePortList()
        {
            string[] availablePorts = usbModemService.GetAvailablePorts();
            view.PortList = availablePorts.ToList();
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

        public void DisconnectModem()
        {
            usbModemService.DisconnectModem();
            view.UpdateStatusBar("");
            view.IsConnected = false;
        }
    }
}
