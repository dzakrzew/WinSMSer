using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSMSer.Services;

namespace WinSMSer
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // inicjalizacja głównego widoku
            var view = new Forms.MainForm();

            // inicjalizacja usługi połączenia z modemem USB
            var usbModemService = new Services.UsbModemService();

            // inicjalizacja usługi przechowywania wiadomości w pliku (określonym ścieżką)
            var messageDatabaseService = new Services.MessageDatabaseService("messages.json");

            // inicjalizacja głównego kontrolera programu
            var controller = new Controllers.MainController(view, usbModemService, messageDatabaseService);

            // uruchomienie programu
            Application.Run(view);
        }
    }
}
