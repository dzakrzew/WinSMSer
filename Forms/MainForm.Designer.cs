namespace WinSMSer.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.modemPage = new System.Windows.Forms.TabPage();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.pinLabel = new System.Windows.Forms.Label();
            this.portAdvancedButton = new System.Windows.Forms.Button();
            this.setPortButton = new System.Windows.Forms.Button();
            this.refreshPortsButton = new System.Windows.Forms.Button();
            this.choosePortLabel = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.sendPage = new System.Windows.Forms.TabPage();
            this.receivePage = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.recipientTextBox = new System.Windows.Forms.TextBox();
            this.recipientListView = new System.Windows.Forms.ListView();
            this.recipientPrefixComboBox = new System.Windows.Forms.ComboBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.clearRecipientsButton = new System.Windows.Forms.Button();
            this.addRecipientButton = new System.Windows.Forms.Button();
            this.portAdvancedGroupBox = new System.Windows.Forms.GroupBox();
            this.recipientsListLabel = new System.Windows.Forms.Label();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.messageBoxLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.modemPage.SuspendLayout();
            this.sendPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.portAdvancedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.modemPage);
            this.tabControl.Controls.Add(this.sendPage);
            this.tabControl.Controls.Add(this.receivePage);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 382);
            this.tabControl.TabIndex = 0;
            // 
            // modemPage
            // 
            this.modemPage.Controls.Add(this.portAdvancedGroupBox);
            this.modemPage.Controls.Add(this.portAdvancedButton);
            this.modemPage.Controls.Add(this.setPortButton);
            this.modemPage.Controls.Add(this.refreshPortsButton);
            this.modemPage.Controls.Add(this.choosePortLabel);
            this.modemPage.Controls.Add(this.portComboBox);
            this.modemPage.Location = new System.Drawing.Point(4, 22);
            this.modemPage.Name = "modemPage";
            this.modemPage.Padding = new System.Windows.Forms.Padding(3);
            this.modemPage.Size = new System.Drawing.Size(592, 356);
            this.modemPage.TabIndex = 0;
            this.modemPage.Text = "Ustawienia modemu";
            this.modemPage.UseVisualStyleBackColor = true;
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(11, 32);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(100, 20);
            this.pinTextBox.TabIndex = 1;
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(8, 16);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(91, 13);
            this.pinLabel.TabIndex = 0;
            this.pinLabel.Text = "PIN do karty SIM:";
            // 
            // portAdvancedButton
            // 
            this.portAdvancedButton.Location = new System.Drawing.Point(180, 127);
            this.portAdvancedButton.Name = "portAdvancedButton";
            this.portAdvancedButton.Size = new System.Drawing.Size(75, 23);
            this.portAdvancedButton.TabIndex = 4;
            this.portAdvancedButton.Text = "Opcje...";
            this.portAdvancedButton.UseVisualStyleBackColor = true;
            this.portAdvancedButton.Click += new System.EventHandler(this.portAdvancedButton_Click);
            // 
            // setPortButton
            // 
            this.setPortButton.Location = new System.Drawing.Point(401, 127);
            this.setPortButton.Name = "setPortButton";
            this.setPortButton.Size = new System.Drawing.Size(100, 23);
            this.setPortButton.TabIndex = 3;
            this.setPortButton.Text = "Połącz";
            this.setPortButton.UseVisualStyleBackColor = true;
            this.setPortButton.Click += new System.EventHandler(this.setPortButton_Click);
            // 
            // refreshPortsButton
            // 
            this.refreshPortsButton.Location = new System.Drawing.Point(99, 127);
            this.refreshPortsButton.Name = "refreshPortsButton";
            this.refreshPortsButton.Size = new System.Drawing.Size(75, 23);
            this.refreshPortsButton.TabIndex = 2;
            this.refreshPortsButton.Text = "Odśwież";
            this.refreshPortsButton.UseVisualStyleBackColor = true;
            this.refreshPortsButton.Click += new System.EventHandler(this.refreshPortsButton_Click);
            // 
            // choosePortLabel
            // 
            this.choosePortLabel.AutoSize = true;
            this.choosePortLabel.Location = new System.Drawing.Point(97, 84);
            this.choosePortLabel.Name = "choosePortLabel";
            this.choosePortLabel.Size = new System.Drawing.Size(102, 13);
            this.choosePortLabel.TabIndex = 1;
            this.choosePortLabel.Text = "Wybierz urządzenie:";
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(100, 100);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(400, 21);
            this.portComboBox.TabIndex = 0;
            // 
            // sendPage
            // 
            this.sendPage.Controls.Add(this.messageBoxLabel);
            this.sendPage.Controls.Add(this.recipientLabel);
            this.sendPage.Controls.Add(this.recipientsListLabel);
            this.sendPage.Controls.Add(this.addRecipientButton);
            this.sendPage.Controls.Add(this.clearRecipientsButton);
            this.sendPage.Controls.Add(this.sendMessageButton);
            this.sendPage.Controls.Add(this.messageTextBox);
            this.sendPage.Controls.Add(this.recipientPrefixComboBox);
            this.sendPage.Controls.Add(this.recipientListView);
            this.sendPage.Controls.Add(this.recipientTextBox);
            this.sendPage.Location = new System.Drawing.Point(4, 22);
            this.sendPage.Name = "sendPage";
            this.sendPage.Padding = new System.Windows.Forms.Padding(3);
            this.sendPage.Size = new System.Drawing.Size(592, 356);
            this.sendPage.TabIndex = 1;
            this.sendPage.Text = "Wysyłanie SMS";
            this.sendPage.UseVisualStyleBackColor = true;
            // 
            // receivePage
            // 
            this.receivePage.Location = new System.Drawing.Point(4, 22);
            this.receivePage.Name = "receivePage";
            this.receivePage.Size = new System.Drawing.Size(768, 356);
            this.receivePage.TabIndex = 2;
            this.receivePage.Text = "Skrzynka odbiorcza";
            this.receivePage.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem,
            this.pomocToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCloseItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.pomocToolStripMenuItem.Text = "Plik";
            // 
            // menuCloseItem
            // 
            this.menuCloseItem.Name = "menuCloseItem";
            this.menuCloseItem.Size = new System.Drawing.Size(118, 22);
            this.menuCloseItem.Text = "Zakończ";
            this.menuCloseItem.Click += new System.EventHandler(this.menuCloseItem_Click);
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // recipientTextBox
            // 
            this.recipientTextBox.Location = new System.Drawing.Point(153, 151);
            this.recipientTextBox.Name = "recipientTextBox";
            this.recipientTextBox.Size = new System.Drawing.Size(186, 20);
            this.recipientTextBox.TabIndex = 0;
            this.recipientTextBox.TextChanged += new System.EventHandler(this.recipientTextBox_TextChanged);
            // 
            // recipientListView
            // 
            this.recipientListView.HideSelection = false;
            this.recipientListView.Location = new System.Drawing.Point(100, 30);
            this.recipientListView.Name = "recipientListView";
            this.recipientListView.Size = new System.Drawing.Size(239, 97);
            this.recipientListView.TabIndex = 1;
            this.recipientListView.UseCompatibleStateImageBehavior = false;
            this.recipientListView.View = System.Windows.Forms.View.List;
            // 
            // recipientPrefixComboBox
            // 
            this.recipientPrefixComboBox.FormattingEnabled = true;
            this.recipientPrefixComboBox.Items.AddRange(new object[] {
            "+48"});
            this.recipientPrefixComboBox.Location = new System.Drawing.Point(100, 150);
            this.recipientPrefixComboBox.Name = "recipientPrefixComboBox";
            this.recipientPrefixComboBox.Size = new System.Drawing.Size(47, 21);
            this.recipientPrefixComboBox.TabIndex = 2;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(100, 194);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(400, 100);
            this.messageTextBox.TabIndex = 3;
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(392, 300);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(109, 23);
            this.sendMessageButton.TabIndex = 4;
            this.sendMessageButton.Text = "Wyślij";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // clearRecipientsButton
            // 
            this.clearRecipientsButton.Location = new System.Drawing.Point(345, 105);
            this.clearRecipientsButton.Name = "clearRecipientsButton";
            this.clearRecipientsButton.Size = new System.Drawing.Size(75, 23);
            this.clearRecipientsButton.TabIndex = 5;
            this.clearRecipientsButton.Text = "Wyczyść";
            this.clearRecipientsButton.UseVisualStyleBackColor = true;
            this.clearRecipientsButton.Click += new System.EventHandler(this.clearRecipientsButton_Click);
            // 
            // addRecipientButton
            // 
            this.addRecipientButton.Location = new System.Drawing.Point(345, 149);
            this.addRecipientButton.Name = "addRecipientButton";
            this.addRecipientButton.Size = new System.Drawing.Size(75, 23);
            this.addRecipientButton.TabIndex = 6;
            this.addRecipientButton.Text = "Dodaj";
            this.addRecipientButton.UseVisualStyleBackColor = true;
            this.addRecipientButton.Click += new System.EventHandler(this.addRecipientButton_Click);
            // 
            // portAdvancedGroupBox
            // 
            this.portAdvancedGroupBox.Controls.Add(this.pinTextBox);
            this.portAdvancedGroupBox.Controls.Add(this.pinLabel);
            this.portAdvancedGroupBox.Location = new System.Drawing.Point(100, 156);
            this.portAdvancedGroupBox.Name = "portAdvancedGroupBox";
            this.portAdvancedGroupBox.Size = new System.Drawing.Size(400, 100);
            this.portAdvancedGroupBox.TabIndex = 6;
            this.portAdvancedGroupBox.TabStop = false;
            this.portAdvancedGroupBox.Text = "Opcje modemu";
            this.portAdvancedGroupBox.Visible = false;
            // 
            // recipientsListLabel
            // 
            this.recipientsListLabel.AutoSize = true;
            this.recipientsListLabel.Location = new System.Drawing.Point(97, 14);
            this.recipientsListLabel.Name = "recipientsListLabel";
            this.recipientsListLabel.Size = new System.Drawing.Size(81, 13);
            this.recipientsListLabel.TabIndex = 7;
            this.recipientsListLabel.Text = "Lista odbiorców";
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Location = new System.Drawing.Point(97, 134);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(79, 13);
            this.recipientLabel.TabIndex = 8;
            this.recipientLabel.Text = "Numer telefonu";
            // 
            // messageBoxLabel
            // 
            this.messageBoxLabel.AutoSize = true;
            this.messageBoxLabel.Location = new System.Drawing.Point(97, 178);
            this.messageBoxLabel.Name = "messageBoxLabel";
            this.messageBoxLabel.Size = new System.Drawing.Size(92, 13);
            this.messageBoxLabel.TabIndex = 9;
            this.messageBoxLabel.Text = "Treść wiadomości";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "WinSMSer";
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl.ResumeLayout(false);
            this.modemPage.ResumeLayout(false);
            this.modemPage.PerformLayout();
            this.sendPage.ResumeLayout(false);
            this.sendPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.portAdvancedGroupBox.ResumeLayout(false);
            this.portAdvancedGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage modemPage;
        private System.Windows.Forms.Label choosePortLabel;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.TabPage sendPage;
        private System.Windows.Forms.TabPage receivePage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Button portAdvancedButton;
        private System.Windows.Forms.Button setPortButton;
        private System.Windows.Forms.Button refreshPortsButton;
        private System.Windows.Forms.ToolStripMenuItem menuCloseItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.ComboBox recipientPrefixComboBox;
        private System.Windows.Forms.ListView recipientListView;
        private System.Windows.Forms.TextBox recipientTextBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Button addRecipientButton;
        private System.Windows.Forms.Button clearRecipientsButton;
        private System.Windows.Forms.GroupBox portAdvancedGroupBox;
        private System.Windows.Forms.Label messageBoxLabel;
        private System.Windows.Forms.Label recipientLabel;
        private System.Windows.Forms.Label recipientsListLabel;
    }
}