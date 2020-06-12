using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSMSer.Services
{
    public class UsbModemService
    {
        public Presenters.MainPresenter Presenter { get; set; }
        private string selectedPort;
        public string ModemInfo { get; private set; }
        private SerialPort serialPort;

        private bool checkPin(string pin)
        {
            serialPort.WriteLine("AT+CPIN=" + pin + Environment.NewLine);
            Thread.Sleep(100);
            string response = serialPort.ReadExisting();

            return response.Contains("OK");
        }

        private void getModemInfo()
        {
            serialPort.WriteLine("ati" + Environment.NewLine);
            Thread.Sleep(100);

            string response = serialPort.ReadExisting();

            Regex reg = new Regex(@"Manufacturer\:\s([a-zA-Z0-9 ]+)?\r\nModel\:\s([a-zA-Z0-9 ]+)?\s", RegexOptions.IgnoreCase);
            Match m = reg.Match(response);

            if (m.Success)
            {
                ModemInfo = m.Groups[1].Value + " " + m.Groups[2].Value;
            }
        }

        private bool tryConnectWithModem(string port, string pin = "")
        {
            selectedPort = port;

            serialPort = new SerialPort();
            serialPort.PortName = port;
            serialPort.BaudRate = 9600;

            serialPort.Open();

            serialPort.WriteLine("at" + Environment.NewLine);
            Thread.Sleep(100);

            if (serialPort.ReadExisting().Contains("OK"))
            {
                serialPort.WriteLine("at+csq" + Environment.NewLine);
                Thread.Sleep(100);

                if (serialPort.ReadExisting().Contains("ERROR"))
                {
                    if (pin == "")
                    {
                        serialPort.Close();
                        throw new Exception("Wymagane jest podanie numeru PIN");
                    }

                    if (pin.Length > 0 && !checkPin(pin))
                    {
                        serialPort.Close();
                        throw new Exception("Nieprawidłowy numer PIN");
                    }
                }

                getModemInfo();

                return true;
            }

            serialPort.Close();

            return false;
        }

        public string[] GetAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();

            return ports;
        }

        public bool SelectPort(string port, string pin)
        {
            return tryConnectWithModem(port, pin);
        }

        public string GetSelectedPort()
        {
            return selectedPort;
        }

        public void DisconnectModem()
        {
            if (serialPort != null)
            {
                serialPort.Close();
            }

        }

        public bool SendSms(string recipient, string message)
        {
            // set sms text mode
            serialPort.WriteLine("at+cmgf=1" + Environment.NewLine);
            Thread.Sleep(100);

            if (serialPort.ReadExisting().Contains("OK"))
            {
                // send message
                serialPort.WriteLine("at+cmgs=\"" + recipient + "\"" + Environment.NewLine);
                Thread.Sleep(100);

                serialPort.WriteLine(message + Environment.NewLine);
                Thread.Sleep(100);
                serialPort.WriteLine((char)26 + Environment.NewLine);
                Thread.Sleep(2000);

                while (!serialPort.ReadExisting().Contains("OK"))
                {
                }

                return true;
            }

            return false;
        }

        public List<Model.Message> GetUnreadMessages()
        {
            List<Model.Message> messages = new List<Model.Message>();

            serialPort.WriteLine("at+cmgf=1" + Environment.NewLine);
            Thread.Sleep(100);
            serialPort.WriteLine("at+cmgl=\"ALL\"" + Environment.NewLine);
            Thread.Sleep(100);

            var response = serialPort.ReadExisting();

            if (response.Contains("OK"))
            {
                Regex reg = new Regex(@"\+CMGL\:([\d ]+),.([A-Z ]+).,.([\d\+]+).,,.([\d\/,:\+]+).\r\n(.*)");

                MatchCollection matches = reg.Matches(response);

                foreach (Match m in matches)
                {
                    Model.Message message = new Model.Message();
                    message.Type = Model.MessageType.Received;
                    message.Sender = m.Groups[3].Value;
                    message.Date = m.Groups[4].Value;
                    message.Content = m.Groups[5].Value.Trim();

                    messages.Add(message);

                    serialPort.WriteLine("at+cmgd=" + m.Groups[1] + Environment.NewLine);
                    Thread.Sleep(100);
                }
            }

            return messages;
        }
    }
}
