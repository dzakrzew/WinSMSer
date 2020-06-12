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


            var view = new Forms.MainForm();
            var usbModemService = new Services.UsbModemService();
            var messageDatabaseService = new Services.MessageDatabaseService();
            var presenter = new Presenters.MainPresenter(view, usbModemService, messageDatabaseService);

            Application.Run(view);
        }
    }
}
