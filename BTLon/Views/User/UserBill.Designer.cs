namespace BTLon.Views.User
{
    partial class UserBill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblKH = new System.Windows.Forms.Label();
            this.btnOld = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnDestroy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnNew = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.errtxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSDT = new BTLon.Views.Custom.TextBoxCus();
            this.txtHoTen = new BTLon.Views.Custom.TextBoxCus();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errtxt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKH
            // 
            this.lblKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKH.Location = new System.Drawing.Point(12, 0);
            this.lblKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(192, 44);
            this.lblKH.TabIndex = 1;
            this.lblKH.Text = "Bạn là khách hàng mới hay cũ?";
            // 
            // btnOld
            // 
            this.btnOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOld.BorderRadius = 5;
            this.btnOld.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOld.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOld.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOld.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOld.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOld.FillColor = System.Drawing.Color.DeepPink;
            this.btnOld.FillColor2 = System.Drawing.Color.HotPink;
            this.btnOld.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOld.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOld.Location = new System.Drawing.Point(149, 52);
            this.btnOld.Margin = new System.Windows.Forms.Padding(2);
            this.btnOld.Name = "btnOld";
            this.btnOld.Size = new System.Drawing.Size(55, 23);
            this.btnOld.TabIndex = 0;
            this.btnOld.Text = "Cũ";
            this.btnOld.Click += new System.EventHandler(this.btnOld_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 8;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnDestroy);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnConfirm);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtpDate);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblDate);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtSDT);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtHoTen);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnNew);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Separator2);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblKH);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnOld);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(215, 257);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // btnDestroy
            // 
            this.btnDestroy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDestroy.BorderRadius = 5;
            this.btnDestroy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDestroy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDestroy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDestroy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDestroy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDestroy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDestroy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDestroy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDestroy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDestroy.Location = new System.Drawing.Point(18, 223);
            this.btnDestroy.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(55, 23);
            this.btnDestroy.TabIndex = 14;
            this.btnDestroy.Text = "Hủy";
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConfirm.BorderRadius = 5;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConfirm.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(121, 223);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(83, 23);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(16, 188);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(188, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(16, 171);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 15);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Ngày/Tháng/Năm sinh";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNew.BorderRadius = 5;
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.FillColor2 = System.Drawing.Color.Crimson;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNew.Location = new System.Drawing.Point(16, 52);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 22);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2Separator2.Location = new System.Drawing.Point(0, 46);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(215, 1);
            this.guna2Separator2.TabIndex = 3;
            // 
            // errtxt
            // 
            this.errtxt.ContainerControl = this;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtSDT.BorderColor = System.Drawing.Color.Lavender;
            this.txtSDT.BorderFocusColor = System.Drawing.Color.Lavender;
            this.txtSDT.BorderSize = 1;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSDT.Location = new System.Drawing.Point(16, 141);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.Size = new System.Drawing.Size(188, 28);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.Texts = "Số Điện Thoại:";
            this.txtSDT.UnderlinedStyle = true;
            this.txtSDT.Click += new System.EventHandler(this.txtSDT_Click);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtHoTen.BorderColor = System.Drawing.Color.Lavender;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.Lavender;
            this.txtHoTen.BorderSize = 1;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHoTen.Location = new System.Drawing.Point(16, 102);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.Size = new System.Drawing.Size(188, 28);
            this.txtHoTen.TabIndex = 5;
            this.txtHoTen.Texts = "Họ Và Tên:";
            this.txtHoTen.UnderlinedStyle = true;
            this.txtHoTen.Click += new System.EventHandler(this.txtHoTen_Click);
            this.txtHoTen.Leave += new System.EventHandler(this.txtHoTen_Leave);
            // 
            // UserBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserBill";
            this.Size = new System.Drawing.Size(215, 257);
            this.Load += new System.EventHandler(this.UserBill_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errtxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.TextBoxCus txtHoTen;
        private System.Windows.Forms.Label lblKH;
        private Guna.UI2.WinForms.Guna2GradientButton btnOld;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private Custom.TextBoxCus txtSDT;
        private Guna.UI2.WinForms.Guna2GradientButton btnNew;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2GradientButton btnDestroy;
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirm;
        private System.Windows.Forms.ErrorProvider errtxt;
    }
}
