using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSMSer.Forms
{
    public partial class SendingTaskForm : Form
    {
        public Presenters.MainPresenter Presenter { get; set; }

        public SendingTaskForm()
        {
            InitializeComponent();
        }

        public void UpdateProgress(int value, int[] state)
        {
            countAllLabel.Text = state[0].ToString();
            countPendingLabel.Text = state[1].ToString();
            countSentLabel.Text = state[2].ToString();
            countErrorLabel.Text = state[3].ToString();

            progressBar.Value = value;
        }

        public void StartSending(string[] recipients, string message)
        {
            Presenter.SendMessage(recipients, message);
        }

        public void SendingDone()
        {
            closeButton.Enabled = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
