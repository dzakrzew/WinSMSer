using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinSMSer.Forms;
using WinSMSer.Presenters;

namespace WinSMSer.Views
{
    public interface IMainView
    {
        MainPresenter Presenter { set; }
        SendingTaskForm SendingTaskForm { get; set; }
        IList<string> PortList { get; set; }
        IList<Model.Message> MessageList { get; set; }
        void ShowError(string message);
        void UpdateStatusBar(string message);
        void UpdateMessageList();
        bool IsConnected { get; set; }
    }
}
