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
    public partial class MainForm : Form, Views.IMainView
    {
        public Presenters.MainPresenter Presenter { get; set; }

        private bool _isConnected;

        public bool IsConnected { 
            get { return this._isConnected; }
            set {
                setPortButton.Text = (value == true) ? "Rozłącz" : "Połącz";
                this._isConnected = value; 
            }
        }

        public IList<string> PortList
        {
            get { return (IList<string>)this.portComboBox.DataSource; }
            set { this.portComboBox.DataSource = value; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Wystąpił błąd", MessageBoxButtons.OK);
        }

        public void UpdateStatusBar(string message)
        {
            statusBar.Text = message;
        }

        private void refreshPortsButton_Click(object sender, EventArgs e)
        {
            this.Presenter.UpdatePortList();
        }

        private void portAdvancedButton_Click(object sender, EventArgs e)
        {
            portAdvancedPanel.Visible = !portAdvancedPanel.Visible;
        }

        private void setPortButton_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                Presenter.DisconnectModem();
            }
            else
            {
                if (portComboBox.SelectedIndex >= 0)
                {
                    Presenter.SetPort(portComboBox.SelectedItem.ToString(), pinTextBox.Text);
                }
                else
                {
                    ShowError("Nie wybrano portu modemu");
                }
            }
        }

        private void menuCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
