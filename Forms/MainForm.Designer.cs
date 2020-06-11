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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.modemPage = new System.Windows.Forms.TabPage();
            this.sendPage = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivePage = new System.Windows.Forms.TabPage();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshPortsButton = new System.Windows.Forms.Button();
            this.setPortButton = new System.Windows.Forms.Button();
            this.portAdvancedButton = new System.Windows.Forms.Button();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portAdvancedPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.modemPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.portAdvancedPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.modemPage);
            this.tabControl1.Controls.Add(this.sendPage);
            this.tabControl1.Controls.Add(this.receivePage);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // modemPage
            // 
            this.modemPage.Controls.Add(this.portAdvancedPanel);
            this.modemPage.Controls.Add(this.portAdvancedButton);
            this.modemPage.Controls.Add(this.setPortButton);
            this.modemPage.Controls.Add(this.refreshPortsButton);
            this.modemPage.Controls.Add(this.label1);
            this.modemPage.Controls.Add(this.portComboBox);
            this.modemPage.Location = new System.Drawing.Point(4, 22);
            this.modemPage.Name = "modemPage";
            this.modemPage.Padding = new System.Windows.Forms.Padding(3);
            this.modemPage.Size = new System.Drawing.Size(768, 356);
            this.modemPage.TabIndex = 0;
            this.modemPage.Text = "Ustawienia modemu";
            this.modemPage.UseVisualStyleBackColor = true;
            // 
            // sendPage
            // 
            this.sendPage.Location = new System.Drawing.Point(4, 22);
            this.sendPage.Name = "sendPage";
            this.sendPage.Padding = new System.Windows.Forms.Padding(3);
            this.sendPage.Size = new System.Drawing.Size(768, 385);
            this.sendPage.TabIndex = 1;
            this.sendPage.Text = "Wysyłanie SMS";
            this.sendPage.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem,
            this.pomocToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            // receivePage
            // 
            this.receivePage.Location = new System.Drawing.Point(4, 22);
            this.receivePage.Name = "receivePage";
            this.receivePage.Size = new System.Drawing.Size(768, 385);
            this.receivePage.TabIndex = 2;
            this.receivePage.Text = "Skrzynka odbiorcza";
            this.receivePage.UseVisualStyleBackColor = true;
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(200, 122);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(368, 21);
            this.portComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz urządzenie:";
            // 
            // refreshPortsButton
            // 
            this.refreshPortsButton.Location = new System.Drawing.Point(200, 149);
            this.refreshPortsButton.Name = "refreshPortsButton";
            this.refreshPortsButton.Size = new System.Drawing.Size(75, 23);
            this.refreshPortsButton.TabIndex = 2;
            this.refreshPortsButton.Text = "Odśwież";
            this.refreshPortsButton.UseVisualStyleBackColor = true;
            this.refreshPortsButton.Click += new System.EventHandler(this.refreshPortsButton_Click);
            // 
            // setPortButton
            // 
            this.setPortButton.Location = new System.Drawing.Point(469, 149);
            this.setPortButton.Name = "setPortButton";
            this.setPortButton.Size = new System.Drawing.Size(99, 23);
            this.setPortButton.TabIndex = 3;
            this.setPortButton.Text = "Połącz";
            this.setPortButton.UseVisualStyleBackColor = true;
            this.setPortButton.Click += new System.EventHandler(this.setPortButton_Click);
            // 
            // portAdvancedButton
            // 
            this.portAdvancedButton.Location = new System.Drawing.Point(281, 149);
            this.portAdvancedButton.Name = "portAdvancedButton";
            this.portAdvancedButton.Size = new System.Drawing.Size(75, 23);
            this.portAdvancedButton.TabIndex = 4;
            this.portAdvancedButton.Text = "Opcje...";
            this.portAdvancedButton.UseVisualStyleBackColor = true;
            this.portAdvancedButton.Click += new System.EventHandler(this.portAdvancedButton_Click);
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            // 
            // menuCloseItem
            // 
            this.menuCloseItem.Name = "menuCloseItem";
            this.menuCloseItem.Size = new System.Drawing.Size(180, 22);
            this.menuCloseItem.Text = "Zakończ";
            this.menuCloseItem.Click += new System.EventHandler(this.menuCloseItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // portAdvancedPanel
            // 
            this.portAdvancedPanel.Controls.Add(this.pinTextBox);
            this.portAdvancedPanel.Controls.Add(this.label2);
            this.portAdvancedPanel.Location = new System.Drawing.Point(200, 179);
            this.portAdvancedPanel.Name = "portAdvancedPanel";
            this.portAdvancedPanel.Size = new System.Drawing.Size(368, 100);
            this.portAdvancedPanel.TabIndex = 5;
            this.portAdvancedPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PIN do karty SIM:";
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(7, 21);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(100, 20);
            this.pinTextBox.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WinSMSer";
            this.tabControl1.ResumeLayout(false);
            this.modemPage.ResumeLayout(false);
            this.modemPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.portAdvancedPanel.ResumeLayout(false);
            this.portAdvancedPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage modemPage;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel portAdvancedPanel;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
    }
}