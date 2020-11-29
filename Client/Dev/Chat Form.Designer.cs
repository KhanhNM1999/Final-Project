namespace Dev
{
    partial class Chat_Form
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbMess = new System.Windows.Forms.TextBox();
            this.rtbChatLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(384, 295);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 60);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbMess
            // 
            this.tbMess.Location = new System.Drawing.Point(13, 296);
            this.tbMess.Multiline = true;
            this.tbMess.Name = "tbMess";
            this.tbMess.Size = new System.Drawing.Size(365, 59);
            this.tbMess.TabIndex = 5;
            // 
            // rtbChatLog
            // 
            this.rtbChatLog.Location = new System.Drawing.Point(13, 13);
            this.rtbChatLog.Name = "rtbChatLog";
            this.rtbChatLog.Size = new System.Drawing.Size(468, 276);
            this.rtbChatLog.TabIndex = 6;
            this.rtbChatLog.Text = "";
            // 
            // Chat_Form
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 367);
            this.Controls.Add(this.rtbChatLog);
            this.Controls.Add(this.tbMess);
            this.Controls.Add(this.btnSend);
            this.Name = "Chat_Form";
            this.Text = "Chat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbMess;
        private System.Windows.Forms.RichTextBox rtbChatLog;
    }
}