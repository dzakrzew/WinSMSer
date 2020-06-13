namespace WinSMSer.Forms
{
    partial class SendingTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendingTaskForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countAllLabel = new System.Windows.Forms.Label();
            this.countPendingLabel = new System.Windows.Forms.Label();
            this.countSentLabel = new System.Windows.Forms.Label();
            this.countErrorLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba SMS do wysłania:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pozostało:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wysłano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Błędy wysyłania:";
            // 
            // countAllLabel
            // 
            this.countAllLabel.Location = new System.Drawing.Point(176, 14);
            this.countAllLabel.Name = "countAllLabel";
            this.countAllLabel.Size = new System.Drawing.Size(100, 12);
            this.countAllLabel.TabIndex = 4;
            this.countAllLabel.Text = "0";
            this.countAllLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countPendingLabel
            // 
            this.countPendingLabel.Location = new System.Drawing.Point(176, 26);
            this.countPendingLabel.Name = "countPendingLabel";
            this.countPendingLabel.Size = new System.Drawing.Size(100, 18);
            this.countPendingLabel.TabIndex = 5;
            this.countPendingLabel.Text = "0";
            this.countPendingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countSentLabel
            // 
            this.countSentLabel.Location = new System.Drawing.Point(176, 44);
            this.countSentLabel.Name = "countSentLabel";
            this.countSentLabel.Size = new System.Drawing.Size(100, 13);
            this.countSentLabel.TabIndex = 6;
            this.countSentLabel.Text = "0";
            this.countSentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countErrorLabel
            // 
            this.countErrorLabel.Location = new System.Drawing.Point(176, 57);
            this.countErrorLabel.Name = "countErrorLabel";
            this.countErrorLabel.Size = new System.Drawing.Size(100, 19);
            this.countErrorLabel.TabIndex = 7;
            this.countErrorLabel.Text = "0";
            this.countErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 95);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(263, 23);
            this.progressBar.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.Enabled = false;
            this.closeButton.Location = new System.Drawing.Point(204, 138);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SendingTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 173);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.countErrorLabel);
            this.Controls.Add(this.countSentLabel);
            this.Controls.Add(this.countPendingLabel);
            this.Controls.Add(this.countAllLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(307, 212);
            this.MinimumSize = new System.Drawing.Size(307, 212);
            this.Name = "SendingTaskForm";
            this.Text = "Wysyłanie SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label countAllLabel;
        private System.Windows.Forms.Label countPendingLabel;
        private System.Windows.Forms.Label countSentLabel;
        private System.Windows.Forms.Label countErrorLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button closeButton;
    }
}