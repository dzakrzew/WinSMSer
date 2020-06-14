using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSMSer.Properties;

namespace WinSMSer.Services
{
    /// <summary>
    /// Usługa łącząca się z modemem i wykonująca na nim operacje
    /// </summary>
    public class UsbModemService
    {
        public Controllers.MainController Controller { get; set; }
        private string selectedPort;
        public string ModemInfo { get; private set; }
        private SerialPort serialPort;

        /// <summary>
        /// Sprawdzanie czy podano prawidłowy numer PIN
        /// </summary>
        private bool checkPin(string pin)
        {
            serialPort.WriteLine("AT+CPIN=" + pin + Environment.NewLine);
            Thread.Sleep(100);
            string response = serialPort.ReadExisting();

            return response.Contains("OK");
        }

        /// <summary>
        /// Pobiera informacje o producencie i modelu modemu
        /// </summary>
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

        /// <summary>
        /// Próba połączenia z modemem na podanym porcie i przy użyciu PIN-u
        /// </summary>
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
                        throw new Exception(Resources.PinRequired);
                    }

                    if (pin.Length > 0 && !checkPin(pin))
                    {
                        serialPort.Close();
                        throw new Exception(Resources.PinInvalid);
                    }
                }

                getModemInfo();

                return true;
            }

            // jeżeli błąd, zamknij połączenie z modemem
            serialPort.Close();

            return false;
        }

        /// <summary>
        /// Pobiera listę dostępnych portów COM, na których może znajdować się modem
        /// </summary>
        /// <returns></returns>
        public string[] GetAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();

            return ports;
        }

        /// <summary>
        /// Wybieranie modemu do połączenia
        /// </summary>
        public bool SelectPort(string port, string pin)
        {
            return tryConnectWithModem(port, pin);
        }

        /// <summary>
        /// Zamknięcie połączenia z modemem
        /// </summary>
        public void DisconnectModem()
        {
            if (serialPort != null)
            {
                serialPort.Close();
            }

        }

        /// <summary>
        /// Wysyłanie SMS na podany numer telefonu
        /// </summary>
        public bool SendSms(string recipient, string content)
        {
            // ustawienie trybu tekstowego sms
            serialPort.WriteLine("at+cmgf=1" + Environment.NewLine);
            Thread.Sleep(100);

            if (serialPort.ReadExisting().Contains("OK"))
            {
                // wysłanie wiadomości
                serialPort.WriteLine("at+cmgs=\"" + recipient + "\"" + Environment.NewLine);
                Thread.Sleep(100);

                serialPort.WriteLine(content + Environment.NewLine);
                Thread.Sleep(100);
                serialPort.WriteLine((char)26 + Environment.NewLine);
                Thread.Sleep(2000);

                // oczekiwanie na wiadomość OK
                while (!serialPort.ReadExisting().Contains("OK"))
                {
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Pobiera z modemu listę nieprzeczytanych wiadomości SMS
        /// </summary>
        /// <returns></returns>
        public List<Model.Message> GetUnreadMessages()
        {
            List<Model.Message> messages = new List<Model.Message>();

            // ustawienie tekstowego trybu wiadomości
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

                    // parsowanie tego dziwnego formatu daty
                    message.Date = DateTime.ParseExact(m.Groups[4].Value.Split('+')[0], "yy/MM/dd,HH:mm:ss", CultureInfo.InvariantCulture);
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
