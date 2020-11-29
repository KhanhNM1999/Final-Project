namespace Dev
{
    partial class frmMain
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spinCurrentMoney = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spinMoney = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.spinService = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spinPrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtEndtime = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTimePlay = new DevExpress.XtraEditors.TextEdit();
            this.btnOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnChat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.spinCurrentMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndtime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimePlay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Current Money : ";
            // 
            // spinCurrentMoney
            // 
            this.spinCurrentMoney.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCurrentMoney.Location = new System.Drawing.Point(100, 9);
            this.spinCurrentMoney.Name = "spinCurrentMoney";
            this.spinCurrentMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinCurrentMoney.Properties.DisplayFormat.FormatString = "{0:n0}";
            this.spinCurrentMoney.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinCurrentMoney.Properties.EditFormat.FormatString = "{0:n0}";
            this.spinCurrentMoney.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinCurrentMoney.Size = new System.Drawing.Size(172, 20);
            this.spinCurrentMoney.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Money:";
            // 
            // spinMoney
            // 
            this.spinMoney.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMoney.Location = new System.Drawing.Point(100, 87);
            this.spinMoney.Name = "spinMoney";
            this.spinMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinMoney.Properties.DisplayFormat.FormatString = "{0:n0}";
            this.spinMoney.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMoney.Properties.EditFormat.FormatString = "{0:n0}";
            this.spinMoney.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMoney.Size = new System.Drawing.Size(172, 20);
            this.spinMoney.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Service charge:";
            // 
            // spinService
            // 
            this.spinService.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinService.Location = new System.Drawing.Point(100, 113);
            this.spinService.Name = "spinService";
            this.spinService.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinService.Properties.DisplayFormat.FormatString = "{0:n0}";
            this.spinService.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinService.Properties.EditFormat.FormatString = "{0:n0}";
            this.spinService.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinService.Size = new System.Drawing.Size(172, 20);
            this.spinService.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 142);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Price / 1h:";
            // 
            // spinPrice
            // 
            this.spinPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinPrice.Location = new System.Drawing.Point(100, 139);
            this.spinPrice.Name = "spinPrice";
            this.spinPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinPrice.Properties.DisplayFormat.FormatString = "{0:n0}";
            this.spinPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinPrice.Properties.EditFormat.FormatString = "{0:n0}";
            this.spinPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinPrice.Size = new System.Drawing.Size(172, 20);
            this.spinPrice.TabIndex = 1;
            // 
            // txtEndtime
            // 
            this.txtEndtime.Location = new System.Drawing.Point(100, 35);
            this.txtEndtime.Name = "txtEndtime";
            this.txtEndtime.Size = new System.Drawing.Size(172, 20);
            this.txtEndtime.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "End time:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 64);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Time play";
            // 
            // txtTimePlay
            // 
            this.txtTimePlay.Location = new System.Drawing.Point(100, 61);
            this.txtTimePlay.Name = "txtTimePlay";
            this.txtTimePlay.Size = new System.Drawing.Size(172, 20);
            this.txtTimePlay.TabIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(12, 189);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(260, 36);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(12, 231);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(260, 36);
            this.btnChat.TabIndex = 3;
            this.btnChat.Text = "Chat";
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 273);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(260, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 661);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtTimePlay);
            this.Controls.Add(this.txtEndtime);
            this.Controls.Add(this.spinPrice);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.spinService);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.spinMoney);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.spinCurrentMoney);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.MaximumSize = new System.Drawing.Size(300, 700);
            this.MinimumSize = new System.Drawing.Size(300, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinCurrentMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndtime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimePlay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinCurrentMoney;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinMoney;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spinService;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spinPrice;
        private DevExpress.XtraEditors.TextEdit txtEndtime;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTimePlay;
        private DevExpress.XtraEditors.SimpleButton btnOrder;
        private DevExpress.XtraEditors.SimpleButton btnChat;
        private DevExpress.XtraEditors.SimpleButton btnLogout;
    }
}