using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinSMSer.Presenters;

namespace WinSMSer.Views
{
    public interface IMainView
    {
        MainPresenter Presenter { set; }
        IList<string> PortList { get; set; }
        void ShowError(string message);
        void UpdateStatusBar(string message);
        bool IsConnected { get; set; }
    }
}
