using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSMSer.Properties;

namespace WinSMSer.Forms
{
    public partial class MainForm : Form, Views.IMainView
    {
        public Presenters.MainPresenter Presenter { get; set; }

        private bool _isConnected;

        public bool IsConnected { 
            get { return this._isConnected; }
            set {
                setPortButton.Text = (value == true) ? Resources.Disconnect : Resources.Connect;
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

            // set first phone number prefix as default
            recipientPrefixComboBox.SelectedIndex = 0;

            updateSendFormVisibility();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, Resources.ErrorCaption, MessageBoxButtons.OK);
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
            portAdvancedGroupBox.Visible = !portAdvancedGroupBox.Visible;
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
                    ShowError(Resources.ModemPortNotSelected);
                }
            }
        }

        private void menuCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRecipientButton_Click(object sender, EventArgs e)
        {
            if (!Utils.SmsUtils.validatePhoneNumer(recipientTextBox.Text))
            {
                ShowError(Resources.InvalidPhoneNumber);
            }
            else {
                recipientListView.Items.Add(recipientPrefixComboBox.SelectedItem.ToString() + recipientTextBox.Text);
                recipientTextBox.Clear();

                updateSendFormVisibility();
            }
        }

        private void clearRecipientsButton_Click(object sender, EventArgs e)
        {
            recipientListView.Items.Clear();
            updateSendFormVisibility();
        }

        private void aboutProgramMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Forms.AboutProgramForm();
            form.ShowDialog();
        }

        private void updateSendFormVisibility()
        {
            clearRecipientsButton.Enabled = recipientListView.Items.Count > 0;
            addRecipientButton.Enabled = recipientTextBox.Text.Length > 0 && Utils.SmsUtils.validatePhoneNumer(recipientTextBox.Text);
            sendMessageButton.Enabled = recipientListView.Items.Count > 0 && messageTextBox.Text.Length > 0;
        }

        private void recipientTextBox_TextChanged(object sender, EventArgs e)
        {
            updateSendFormVisibility();
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            updateSendFormVisibility();
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            updateFormsGrid();
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            updateFormsGrid();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            updateFormsGrid();
        }

        private void updateFormsGrid()
        {
            tabControl.Size = new Size(this.Size.Width - 40, this.Size.Height - 98);

            // modem page settings
            int modemPagePaddingTop = 100;
            choosePortLabel.Location = new Point((modemPage.Size.Width - 392) / 2 - 3, modemPagePaddingTop - 16);
            portComboBox.Location = new Point((modemPage.Size.Width - 392) /2, modemPagePaddingTop);
            refreshPortsButton.Location = new Point((modemPage.Size.Width - 392) / 2 - 1, modemPagePaddingTop + 27);
            portAdvancedButton.Location = new Point((modemPage.Size.Width - 392) / 2 - 1 + 81, modemPagePaddingTop + 27);
            setPortButton.Location = new Point((modemPage.Size.Width - 392) / 2 + 301, modemPagePaddingTop + 27);
            portAdvancedGroupBox.Location = new Point((modemPage.Size.Width - 392) / 2, modemPagePaddingTop + 56);

            // send sms page settings
            int sendPagePaddingTop = 14;
            messageTextBox.Location = new Point((sendPage.Size.Width - 392) / 2, sendPagePaddingTop + 180);
            messageBoxLabel.Location = new Point((sendPage.Size.Width - 392) / 2 - 3, sendPagePaddingTop + 164);
            recipientPrefixComboBox.Location = new Point((sendPage.Size.Width - 394) / 2 + 1, sendPagePaddingTop + 136);
            recipientTextBox.Location = new Point((sendPage.Size.Width - 392) / 2 + 53, sendPagePaddingTop + 137);
            addRecipientButton.Location = new Point((sendPage.Size.Width - 392) / 2 + 245, sendPagePaddingTop + 135);
            recipientLabel.Location = new Point((sendPage.Size.Width - 392) / 2 - 3, sendPagePaddingTop + 120);
            recipientListView.Location = new Point((sendPage.Size.Width - 392) / 2, sendPagePaddingTop + 16);
            clearRecipientsButton.Location = new Point((sendPage.Size.Width - 392) / 2 + 245, sendPagePaddingTop + 91);
            recipientsListLabel.Location = new Point((sendPage.Size.Width - 392) / 2 - 3, sendPagePaddingTop);
            sendMessageButton.Location = new Point((sendPage.Size.Width - 392) / 2 + 292, 300);
        }
    }
}
