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
        public Controllers.MainController Controller { get; set; }
        public SendingTaskForm SendingTaskForm { get; set; }

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

        private List<Model.Message> _messageList = new List<Model.Message>();

        public IList<Model.Message> MessageList { 
            get { return this._messageList; }
            set { _messageList = (List<Model.Message>)value; }
        }

        public MainForm()
        {
            InitializeComponent();

            // ustawienie pierwszego prefiksu jako domyślnego
            recipientPrefixComboBox.SelectedIndex = 0;

            updateFormsVisibility();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, Resources.ErrorCaption, MessageBoxButtons.OK);
        }

        public void UpdateStatusBar(string message)
        {
            statusBar.Text = message;
        }

        public void UpdateMessageList()
        {
            receivedMessagesListView.Items.Clear();
            sentMessagesListView.Items.Clear();

            foreach (Model.Message message in MessageList)
            {
                if (message.Type == Model.MessageType.Received)
                {
                    receivedMessagesListView.Items.Add(
                        new ListViewItem(new string[] {
                        message.Sender, message.Date.ToString("yyyy-MM-dd HH:mm:ss"), message.Content
                        })
                    );
                }

                if (message.Type == Model.MessageType.Sent)
                {
                    sentMessagesListView.Items.Add(
                        new ListViewItem(new string[] {
                        message.Recipent, message.Date.ToString("yyyy-MM-dd HH:mm:ss"), message.Content
                        })
                    );
                }
            }
        }

        private void refreshPortsButton_Click(object sender, EventArgs e)
        {
            this.Controller.UpdatePortList();
        }

        private void portAdvancedButton_Click(object sender, EventArgs e)
        {
            portAdvancedGroupBox.Visible = !portAdvancedGroupBox.Visible;
        }

        private void setPortButton_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                Controller.DisconnectModem();
            }
            else
            {
                if (portComboBox.SelectedIndex >= 0)
                {
                    Controller.SetPort(portComboBox.SelectedItem.ToString(), pinTextBox.Text);
                }
                else
                {
                    ShowError(Resources.ModemPortNotSelected);
                }
            }

            updateFormsVisibility();
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

                updateFormsVisibility();
            }
        }

        private void clearRecipientsButton_Click(object sender, EventArgs e)
        {
            recipientListView.Items.Clear();
            updateFormsVisibility();
        }

        /// <summary>
        /// Funkcja aktualizująca widoczność i aktywność elementów formularzy (np. przycisków)
        /// </summary>
        private void updateFormsVisibility()
        {
            // jeżeli modem jest rozłączony, to wszystkie przyciski powinny być nieaktywne
            messagesRefreshButton.Enabled = IsConnected;

            // walidacje listy odbiorców w formularzu wysyłania SMS-a
            clearRecipientsButton.Enabled = IsConnected && recipientListView.Items.Count > 0;
            addRecipientButton.Enabled = IsConnected && recipientTextBox.Text.Length > 0 && Utils.SmsUtils.validatePhoneNumer(recipientTextBox.Text);
            sendMessageButton.Enabled = IsConnected && recipientListView.Items.Count > 0 && messageTextBox.Text.Length > 0;
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            List<string> recipients = new List<string>();

            foreach (ListViewItem recipientItem in recipientListView.Items)
            {
                recipients.Add(recipientItem.Text);
            }

            this.SendingTaskForm = new SendingTaskForm();
            this.SendingTaskForm.Controller = Controller;
            this.SendingTaskForm.StartSending(recipients.ToArray(), messageTextBox.Text);
            this.SendingTaskForm.ShowDialog();

            Controller.UpdateMessageList();
        }

        private void recipientTextBox_TextChanged(object sender, EventArgs e)
        {
            updateFormsVisibility();
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            updateFormsVisibility();
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFormsGrid();
        }

        /// <summary>
        /// Funkcja aktualizująca układ i pozycje elementów po zmianie rozmiaru ekranu
        /// </summary>
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
            int sendPagePaddingTop = 23;
            messageTextBox.Location = new Point((sendPage.Size.Width - 392) / 2, sendPagePaddingTop + 180);
            messageBoxLabel.Location = new Point((sendPage.Size.Width - 392) / 2 - 3, sendPagePaddingTop + 164);
            recipientPrefixComboBox.Location = new Point((sendPage.Size.Width - 394) / 2 + 1, sendPagePaddingTop + 136);
            recipientTextBox.Location = new Point((sendPage.Size.Width - 392) / 2 + 53, sendPagePaddingTop + 137);
            addRecipientButton.Location = new Point((sendPage.Size.Width - 392) / 2 + 245, sendPagePaddingTop + 135);
            recipientLabel.Location = new Point((sendPage.Size.Width - 392) / 2 - 3, sendPagePaddingTop + 120);
            recipientListView.Location = new Point((sendPage.Size.Width - 392) / 2, sendPagePaddingTop + 16);
            clearRecipientsButton.Location = new Point((sendPage.Size.Width - 392) / 2 + 245, sendPagePaddingTop + 91);
            recipientsListLabel.Location = new Point((sendPage.Size.Width - 392) / 2 - 3, sendPagePaddingTop);
            sendMessageButton.Location = new Point((sendPage.Size.Width - 392) / 2 + 292, sendPagePaddingTop + 286);

            // inbox/outbox page settings
            receivedMessagesListView.Size = new Size(receivePage.Width - 124, 205);
            sentMessagesListView.Size = new Size(receivePage.Width - 124, 205);
            messageDetailsGroupBox.Size = new Size(receivePage.Width - 124, 138);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.DisconnectModem();
        }

        private void messagesRefreshButton_Click(object sender, EventArgs e)
        {
            Controller.RefreshMessageList();
        }

        private void inboxTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == "inbox")
            {
                receivedMessagesListView.Visible = true;
                sentMessagesListView.Visible = false;
            }
            else if (e.Node.Tag == "outbox")
            {
                receivedMessagesListView.Visible = false;
                sentMessagesListView.Visible = true;
            }
        }

        private void sentMessagesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            messageDetailsGroupBox.Visible = true;

            messageDetailsFromToLabel.Text = e.Item.SubItems[0].Text;
            messageDetailsDateLabel.Text = e.Item.SubItems[1].Text;
            messageDetailsContentTextBox.Text = e.Item.SubItems[2].Text;
        }

        private void receivedMessagesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            messageDetailsGroupBox.Visible = true;

            messageDetailsFromToLabel.Text = e.Item.SubItems[0].Text;
            messageDetailsDateLabel.Text = e.Item.SubItems[1].Text;
            messageDetailsContentTextBox.Text = e.Item.SubItems[2].Text;
        }

        private void menuAboutItem_Click(object sender, EventArgs e)
        {
            var form = new Forms.AboutProgramForm();
            form.ShowDialog();
        }
    }
}
