﻿namespace WinSMSer.Forms
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Odebrane");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Wysłane");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.modemPage = new System.Windows.Forms.TabPage();
            this.portAdvancedGroupBox = new System.Windows.Forms.GroupBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.pinLabel = new System.Windows.Forms.Label();
            this.portAdvancedButton = new System.Windows.Forms.Button();
            this.setPortButton = new System.Windows.Forms.Button();
            this.refreshPortsButton = new System.Windows.Forms.Button();
            this.choosePortLabel = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.sendPage = new System.Windows.Forms.TabPage();
            this.messageBoxLabel = new System.Windows.Forms.Label();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.recipientsListLabel = new System.Windows.Forms.Label();
            this.addRecipientButton = new System.Windows.Forms.Button();
            this.clearRecipientsButton = new System.Windows.Forms.Button();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.recipientPrefixComboBox = new System.Windows.Forms.ComboBox();
            this.recipientListView = new System.Windows.Forms.ListView();
            this.recipientTextBox = new System.Windows.Forms.TextBox();
            this.receivePage = new System.Windows.Forms.TabPage();
            this.messageDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.sentMessagesListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inboxTreeView = new System.Windows.Forms.TreeView();
            this.messagesRefreshButton = new System.Windows.Forms.Button();
            this.receivedMessagesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.messageDetailsFromToLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messageDetailsDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.messageDetailsContentTextBox = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.modemPage.SuspendLayout();
            this.portAdvancedGroupBox.SuspendLayout();
            this.sendPage.SuspendLayout();
            this.receivePage.SuspendLayout();
            this.messageDetailsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
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
            // messageBoxLabel
            // 
            this.messageBoxLabel.AutoSize = true;
            this.messageBoxLabel.Location = new System.Drawing.Point(97, 187);
            this.messageBoxLabel.Name = "messageBoxLabel";
            this.messageBoxLabel.Size = new System.Drawing.Size(92, 13);
            this.messageBoxLabel.TabIndex = 9;
            this.messageBoxLabel.Text = "Treść wiadomości";
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Location = new System.Drawing.Point(97, 143);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(79, 13);
            this.recipientLabel.TabIndex = 8;
            this.recipientLabel.Text = "Numer telefonu";
            // 
            // recipientsListLabel
            // 
            this.recipientsListLabel.AutoSize = true;
            this.recipientsListLabel.Location = new System.Drawing.Point(97, 23);
            this.recipientsListLabel.Name = "recipientsListLabel";
            this.recipientsListLabel.Size = new System.Drawing.Size(81, 13);
            this.recipientsListLabel.TabIndex = 7;
            this.recipientsListLabel.Text = "Lista odbiorców";
            // 
            // addRecipientButton
            // 
            this.addRecipientButton.Location = new System.Drawing.Point(345, 158);
            this.addRecipientButton.Name = "addRecipientButton";
            this.addRecipientButton.Size = new System.Drawing.Size(75, 23);
            this.addRecipientButton.TabIndex = 6;
            this.addRecipientButton.Text = "Dodaj";
            this.addRecipientButton.UseVisualStyleBackColor = true;
            this.addRecipientButton.Click += new System.EventHandler(this.addRecipientButton_Click);
            // 
            // clearRecipientsButton
            // 
            this.clearRecipientsButton.Location = new System.Drawing.Point(345, 114);
            this.clearRecipientsButton.Name = "clearRecipientsButton";
            this.clearRecipientsButton.Size = new System.Drawing.Size(75, 23);
            this.clearRecipientsButton.TabIndex = 5;
            this.clearRecipientsButton.Text = "Wyczyść";
            this.clearRecipientsButton.UseVisualStyleBackColor = true;
            this.clearRecipientsButton.Click += new System.EventHandler(this.clearRecipientsButton_Click);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(392, 309);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(109, 23);
            this.sendMessageButton.TabIndex = 4;
            this.sendMessageButton.Text = "Wyślij";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(100, 203);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(400, 100);
            this.messageTextBox.TabIndex = 3;
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // recipientPrefixComboBox
            // 
            this.recipientPrefixComboBox.FormattingEnabled = true;
            this.recipientPrefixComboBox.Items.AddRange(new object[] {
            "+48"});
            this.recipientPrefixComboBox.Location = new System.Drawing.Point(100, 159);
            this.recipientPrefixComboBox.Name = "recipientPrefixComboBox";
            this.recipientPrefixComboBox.Size = new System.Drawing.Size(47, 21);
            this.recipientPrefixComboBox.TabIndex = 2;
            // 
            // recipientListView
            // 
            this.recipientListView.HideSelection = false;
            this.recipientListView.Location = new System.Drawing.Point(100, 39);
            this.recipientListView.Name = "recipientListView";
            this.recipientListView.Size = new System.Drawing.Size(239, 97);
            this.recipientListView.TabIndex = 1;
            this.recipientListView.UseCompatibleStateImageBehavior = false;
            this.recipientListView.View = System.Windows.Forms.View.List;
            // 
            // recipientTextBox
            // 
            this.recipientTextBox.Location = new System.Drawing.Point(153, 160);
            this.recipientTextBox.Name = "recipientTextBox";
            this.recipientTextBox.Size = new System.Drawing.Size(186, 20);
            this.recipientTextBox.TabIndex = 0;
            this.recipientTextBox.TextChanged += new System.EventHandler(this.recipientTextBox_TextChanged);
            // 
            // receivePage
            // 
            this.receivePage.Controls.Add(this.messageDetailsGroupBox);
            this.receivePage.Controls.Add(this.sentMessagesListView);
            this.receivePage.Controls.Add(this.inboxTreeView);
            this.receivePage.Controls.Add(this.messagesRefreshButton);
            this.receivePage.Controls.Add(this.receivedMessagesListView);
            this.receivePage.Location = new System.Drawing.Point(4, 22);
            this.receivePage.Name = "receivePage";
            this.receivePage.Size = new System.Drawing.Size(592, 356);
            this.receivePage.TabIndex = 2;
            this.receivePage.Text = "Skrzynka wiadomości";
            this.receivePage.UseVisualStyleBackColor = true;
            // 
            // messageDetailsGroupBox
            // 
            this.messageDetailsGroupBox.Controls.Add(this.messageDetailsContentTextBox);
            this.messageDetailsGroupBox.Controls.Add(this.label3);
            this.messageDetailsGroupBox.Controls.Add(this.messageDetailsDateLabel);
            this.messageDetailsGroupBox.Controls.Add(this.label2);
            this.messageDetailsGroupBox.Controls.Add(this.messageDetailsFromToLabel);
            this.messageDetailsGroupBox.Controls.Add(this.label1);
            this.messageDetailsGroupBox.Location = new System.Drawing.Point(121, 215);
            this.messageDetailsGroupBox.Name = "messageDetailsGroupBox";
            this.messageDetailsGroupBox.Size = new System.Drawing.Size(468, 138);
            this.messageDetailsGroupBox.TabIndex = 5;
            this.messageDetailsGroupBox.TabStop = false;
            this.messageDetailsGroupBox.Text = "Szczegóły wiadomości";
            this.messageDetailsGroupBox.Visible = false;
            // 
            // sentMessagesListView
            // 
            this.sentMessagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.sentMessagesListView.FullRowSelect = true;
            this.sentMessagesListView.HideSelection = false;
            this.sentMessagesListView.Location = new System.Drawing.Point(121, 3);
            this.sentMessagesListView.Name = "sentMessagesListView";
            this.sentMessagesListView.Size = new System.Drawing.Size(468, 205);
            this.sentMessagesListView.TabIndex = 4;
            this.sentMessagesListView.UseCompatibleStateImageBehavior = false;
            this.sentMessagesListView.View = System.Windows.Forms.View.Details;
            this.sentMessagesListView.Visible = false;
            this.sentMessagesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.sentMessagesListView_ItemSelectionChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Odbiorca";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Treść";
            // 
            // inboxTreeView
            // 
            this.inboxTreeView.Location = new System.Drawing.Point(3, 3);
            this.inboxTreeView.Name = "inboxTreeView";
            treeNode1.Name = "inboxNode";
            treeNode1.Tag = "inbox";
            treeNode1.Text = "Odebrane";
            treeNode2.Name = "outboxNode";
            treeNode2.Tag = "outbox";
            treeNode2.Text = "Wysłane";
            this.inboxTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.inboxTreeView.Size = new System.Drawing.Size(112, 176);
            this.inboxTreeView.TabIndex = 2;
            this.inboxTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.inboxTreeView_AfterSelect);
            // 
            // messagesRefreshButton
            // 
            this.messagesRefreshButton.Location = new System.Drawing.Point(3, 185);
            this.messagesRefreshButton.Name = "messagesRefreshButton";
            this.messagesRefreshButton.Size = new System.Drawing.Size(112, 23);
            this.messagesRefreshButton.TabIndex = 1;
            this.messagesRefreshButton.Text = "Odśwież";
            this.messagesRefreshButton.UseVisualStyleBackColor = true;
            this.messagesRefreshButton.Click += new System.EventHandler(this.messagesRefreshButton_Click);
            // 
            // receivedMessagesListView
            // 
            this.receivedMessagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.receivedMessagesListView.FullRowSelect = true;
            this.receivedMessagesListView.HideSelection = false;
            this.receivedMessagesListView.Location = new System.Drawing.Point(121, 3);
            this.receivedMessagesListView.Name = "receivedMessagesListView";
            this.receivedMessagesListView.Size = new System.Drawing.Size(468, 205);
            this.receivedMessagesListView.TabIndex = 0;
            this.receivedMessagesListView.UseCompatibleStateImageBehavior = false;
            this.receivedMessagesListView.View = System.Windows.Forms.View.Details;
            this.receivedMessagesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.receivedMessagesListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nadawca";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Treść";
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
            this.menuCloseItem.Size = new System.Drawing.Size(180, 22);
            this.menuCloseItem.Text = "Zakończ";
            this.menuCloseItem.Click += new System.EventHandler(this.menuCloseItem_Click);
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAboutItem});
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            // 
            // menuAboutItem
            // 
            this.menuAboutItem.Name = "menuAboutItem";
            this.menuAboutItem.Size = new System.Drawing.Size(180, 22);
            this.menuAboutItem.Text = "O programie";
            this.menuAboutItem.Click += new System.EventHandler(this.menuAboutItem_Click);
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
            this.statusBar.Size = new System.Drawing.Size(67, 17);
            this.statusBar.Text = "Rozłączono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Od/do:";
            // 
            // messageDetailsFromToLabel
            // 
            this.messageDetailsFromToLabel.Location = new System.Drawing.Point(54, 20);
            this.messageDetailsFromToLabel.Name = "messageDetailsFromToLabel";
            this.messageDetailsFromToLabel.Size = new System.Drawing.Size(408, 13);
            this.messageDetailsFromToLabel.TabIndex = 1;
            this.messageDetailsFromToLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            // 
            // messageDetailsDateLabel
            // 
            this.messageDetailsDateLabel.AutoSize = true;
            this.messageDetailsDateLabel.Location = new System.Drawing.Point(54, 33);
            this.messageDetailsDateLabel.Name = "messageDetailsDateLabel";
            this.messageDetailsDateLabel.Size = new System.Drawing.Size(35, 13);
            this.messageDetailsDateLabel.TabIndex = 3;
            this.messageDetailsDateLabel.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Treść:";
            // 
            // messageDetailsContentTextBox
            // 
            this.messageDetailsContentTextBox.Location = new System.Drawing.Point(57, 49);
            this.messageDetailsContentTextBox.Multiline = true;
            this.messageDetailsContentTextBox.Name = "messageDetailsContentTextBox";
            this.messageDetailsContentTextBox.ReadOnly = true;
            this.messageDetailsContentTextBox.Size = new System.Drawing.Size(405, 83);
            this.messageDetailsContentTextBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "WinSMSer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl.ResumeLayout(false);
            this.modemPage.ResumeLayout(false);
            this.modemPage.PerformLayout();
            this.portAdvancedGroupBox.ResumeLayout(false);
            this.portAdvancedGroupBox.PerformLayout();
            this.sendPage.ResumeLayout(false);
            this.sendPage.PerformLayout();
            this.receivePage.ResumeLayout(false);
            this.messageDetailsGroupBox.ResumeLayout(false);
            this.messageDetailsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem menuAboutItem;
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
        private System.Windows.Forms.Button messagesRefreshButton;
        private System.Windows.Forms.ListView receivedMessagesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TreeView inboxTreeView;
        private System.Windows.Forms.ListView sentMessagesListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox messageDetailsGroupBox;
        private System.Windows.Forms.TextBox messageDetailsContentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label messageDetailsDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label messageDetailsFromToLabel;
        private System.Windows.Forms.Label label1;
    }
}