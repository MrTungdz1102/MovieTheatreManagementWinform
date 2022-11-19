namespace BTLon.Views.User
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserNameA = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassWordA = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuyenTCA = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddA = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchA = new Guna.UI2.WinForms.Guna2Button();
            this.btnExitA = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteA = new Guna.UI2.WinForms.Guna2Button();
            this.btnCanCelA = new Guna.UI2.WinForms.Guna2Button();
            this.imgAcc = new BTLon.Views.Custom.CirclePictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserNameA
            // 
            this.txtUserNameA.BorderRadius = 15;
            this.txtUserNameA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameA.DefaultText = "";
            this.txtUserNameA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserNameA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserNameA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserNameA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameA.Location = new System.Drawing.Point(215, 26);
            this.txtUserNameA.Name = "txtUserNameA";
            this.txtUserNameA.PasswordChar = '\0';
            this.txtUserNameA.PlaceholderText = "";
            this.txtUserNameA.SelectedText = "";
            this.txtUserNameA.Size = new System.Drawing.Size(200, 36);
            this.txtUserNameA.TabIndex = 1;
            this.txtUserNameA.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgAcc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtQuyenTCA);
            this.groupBox1.Controls.Add(this.txtMaNVA);
            this.groupBox1.Controls.Add(this.txtPassWordA);
            this.groupBox1.Controls.Add(this.txtUserNameA);
            this.groupBox1.Location = new System.Drawing.Point(29, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 330);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài Khoản";
            // 
            // txtPassWordA
            // 
            this.txtPassWordA.BorderRadius = 15;
            this.txtPassWordA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWordA.DefaultText = "";
            this.txtPassWordA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassWordA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassWordA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWordA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWordA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWordA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassWordA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWordA.Location = new System.Drawing.Point(215, 107);
            this.txtPassWordA.Name = "txtPassWordA";
            this.txtPassWordA.PasswordChar = '\0';
            this.txtPassWordA.PlaceholderText = "";
            this.txtPassWordA.SelectedText = "";
            this.txtPassWordA.Size = new System.Drawing.Size(200, 36);
            this.txtPassWordA.TabIndex = 1;
            this.txtPassWordA.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaNVA
            // 
            this.txtMaNVA.BorderRadius = 15;
            this.txtMaNVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNVA.DefaultText = "";
            this.txtMaNVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNVA.Location = new System.Drawing.Point(215, 177);
            this.txtMaNVA.Name = "txtMaNVA";
            this.txtMaNVA.PasswordChar = '\0';
            this.txtMaNVA.PlaceholderText = "";
            this.txtMaNVA.SelectedText = "";
            this.txtMaNVA.Size = new System.Drawing.Size(200, 36);
            this.txtMaNVA.TabIndex = 1;
            this.txtMaNVA.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Nhân Viên";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQuyenTCA
            // 
            this.txtQuyenTCA.BorderRadius = 15;
            this.txtQuyenTCA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuyenTCA.DefaultText = "";
            this.txtQuyenTCA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuyenTCA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuyenTCA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuyenTCA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuyenTCA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuyenTCA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuyenTCA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuyenTCA.Location = new System.Drawing.Point(215, 250);
            this.txtQuyenTCA.Name = "txtQuyenTCA";
            this.txtQuyenTCA.PasswordChar = '\0';
            this.txtQuyenTCA.PlaceholderText = "";
            this.txtQuyenTCA.SelectedText = "";
            this.txtQuyenTCA.Size = new System.Drawing.Size(200, 36);
            this.txtQuyenTCA.TabIndex = 1;
            this.txtQuyenTCA.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quyền Truy Cập";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.BorderRadius = 20;
            this.btnAddA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddA.ForeColor = System.Drawing.Color.White;
            this.btnAddA.Location = new System.Drawing.Point(84, 399);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(159, 45);
            this.btnAddA.TabIndex = 3;
            this.btnAddA.Text = "Thêm";
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // btnSearchA
            // 
            this.btnSearchA.BorderRadius = 20;
            this.btnSearchA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchA.ForeColor = System.Drawing.Color.White;
            this.btnSearchA.Location = new System.Drawing.Point(397, 399);
            this.btnSearchA.Name = "btnSearchA";
            this.btnSearchA.Size = new System.Drawing.Size(159, 45);
            this.btnSearchA.TabIndex = 3;
            this.btnSearchA.Text = "Tìm Kiếm";
            this.btnSearchA.Click += new System.EventHandler(this.btnSearchA_Click);
            // 
            // btnExitA
            // 
            this.btnExitA.BorderRadius = 20;
            this.btnExitA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExitA.ForeColor = System.Drawing.Color.White;
            this.btnExitA.Location = new System.Drawing.Point(706, 399);
            this.btnExitA.Name = "btnExitA";
            this.btnExitA.Size = new System.Drawing.Size(159, 45);
            this.btnExitA.TabIndex = 3;
            this.btnExitA.Text = "Sửa";
            this.btnExitA.Click += new System.EventHandler(this.btnExitA_Click);
            // 
            // btnDeleteA
            // 
            this.btnDeleteA.BorderRadius = 20;
            this.btnDeleteA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteA.ForeColor = System.Drawing.Color.White;
            this.btnDeleteA.Location = new System.Drawing.Point(244, 475);
            this.btnDeleteA.Name = "btnDeleteA";
            this.btnDeleteA.Size = new System.Drawing.Size(159, 45);
            this.btnDeleteA.TabIndex = 3;
            this.btnDeleteA.Text = "Xóa";
            this.btnDeleteA.Click += new System.EventHandler(this.btnDeleteA_Click);
            // 
            // btnCanCelA
            // 
            this.btnCanCelA.BorderRadius = 20;
            this.btnCanCelA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCanCelA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCanCelA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCanCelA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCanCelA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCanCelA.ForeColor = System.Drawing.Color.White;
            this.btnCanCelA.Location = new System.Drawing.Point(548, 475);
            this.btnCanCelA.Name = "btnCanCelA";
            this.btnCanCelA.Size = new System.Drawing.Size(159, 45);
            this.btnCanCelA.TabIndex = 3;
            this.btnCanCelA.Text = "Hủy";
            this.btnCanCelA.Click += new System.EventHandler(this.btnCanCelA_Click);
            // 
            // imgAcc
            // 
            this.imgAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgAcc.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.imgAcc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imgAcc.BorderColor2 = System.Drawing.Color.Gray;
            this.imgAcc.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.imgAcc.BorderSize = 2;
            this.imgAcc.GradientAngle = 50F;
            this.imgAcc.Image = ((System.Drawing.Image)(resources.GetObject("imgAcc.Image")));
            this.imgAcc.Location = new System.Drawing.Point(579, 38);
            this.imgAcc.Margin = new System.Windows.Forms.Padding(4);
            this.imgAcc.Name = "imgAcc";
            this.imgAcc.Size = new System.Drawing.Size(257, 257);
            this.imgAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAcc.TabIndex = 2;
            this.imgAcc.TabStop = false;
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.Controls.Add(this.btnCanCelA);
            this.Controls.Add(this.btnDeleteA);
            this.Controls.Add(this.btnExitA);
            this.Controls.Add(this.btnSearchA);
            this.Controls.Add(this.btnAddA);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserAccount";
            this.Size = new System.Drawing.Size(977, 548);
            this.Load += new System.EventHandler(this.UserAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserNameA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtQuyenTCA;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNVA;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWordA;
        private Guna.UI2.WinForms.Guna2Button btnAddA;
        private Guna.UI2.WinForms.Guna2Button btnSearchA;
        private Guna.UI2.WinForms.Guna2Button btnExitA;
        private Guna.UI2.WinForms.Guna2Button btnDeleteA;
        private Guna.UI2.WinForms.Guna2Button btnCanCelA;
        private Custom.CirclePictureBox imgAcc;
    }
}
