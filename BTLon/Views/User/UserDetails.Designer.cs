namespace BTLon.Views.User
{
    partial class UserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetails));
            this.lblHoTen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOldPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSaveP = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelP = new Guna.UI2.WinForms.Guna2Button();
            this.btnExitP = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cicrleAvatarP = new BTLon.Views.Custom.CirclePictureBox();
            this.txtDateP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPlaceP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumberP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNameP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cicrleAvatarP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(680, 196);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(163, 29);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Trần Mỹ Linh";
            this.lblHoTen.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtReNewPass);
            this.groupBox1.Controls.Add(this.txtNewPass);
            this.groupBox1.Controls.Add(this.txtOldPass);
            this.groupBox1.Location = new System.Drawing.Point(526, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nhập Lại Mật Khẩu Mới:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mật Khẩu Cũ:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật Khẩu Mới:";
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.BorderRadius = 15;
            this.txtReNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReNewPass.DefaultText = "";
            this.txtReNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReNewPass.Location = new System.Drawing.Point(202, 162);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.PasswordChar = '\0';
            this.txtReNewPass.PlaceholderText = "";
            this.txtReNewPass.SelectedText = "";
            this.txtReNewPass.Size = new System.Drawing.Size(200, 36);
            this.txtReNewPass.TabIndex = 5;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderRadius = 15;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.Location = new System.Drawing.Point(202, 107);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderText = "";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.Size = new System.Drawing.Size(200, 36);
            this.txtNewPass.TabIndex = 5;
            // 
            // txtOldPass
            // 
            this.txtOldPass.BorderRadius = 15;
            this.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPass.DefaultText = "";
            this.txtOldPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOldPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldPass.Location = new System.Drawing.Point(202, 42);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '\0';
            this.txtOldPass.PlaceholderText = "";
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.Size = new System.Drawing.Size(200, 36);
            this.txtOldPass.TabIndex = 5;
            this.txtOldPass.TextChanged += new System.EventHandler(this.guna2TextBox7_TextChanged);
            // 
            // btnSaveP
            // 
            this.btnSaveP.BorderRadius = 20;
            this.btnSaveP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveP.ForeColor = System.Drawing.Color.White;
            this.btnSaveP.Location = new System.Drawing.Point(70, 462);
            this.btnSaveP.Name = "btnSaveP";
            this.btnSaveP.Size = new System.Drawing.Size(180, 45);
            this.btnSaveP.TabIndex = 8;
            this.btnSaveP.Text = "Lưu";
            this.btnSaveP.Click += new System.EventHandler(this.btnSaveP_Click);
            // 
            // btnCancelP
            // 
            this.btnCancelP.BorderRadius = 20;
            this.btnCancelP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelP.Enabled = false;
            this.btnCancelP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelP.ForeColor = System.Drawing.Color.White;
            this.btnCancelP.Location = new System.Drawing.Point(685, 462);
            this.btnCancelP.Name = "btnCancelP";
            this.btnCancelP.Size = new System.Drawing.Size(180, 45);
            this.btnCancelP.TabIndex = 8;
            this.btnCancelP.Text = "Hủy";
            this.btnCancelP.Click += new System.EventHandler(this.btnCancelP_Click);
            // 
            // btnExitP
            // 
            this.btnExitP.BorderRadius = 20;
            this.btnExitP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitP.Enabled = false;
            this.btnExitP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExitP.ForeColor = System.Drawing.Color.White;
            this.btnExitP.Location = new System.Drawing.Point(387, 462);
            this.btnExitP.Name = "btnExitP";
            this.btnExitP.Size = new System.Drawing.Size(180, 45);
            this.btnExitP.TabIndex = 8;
            this.btnExitP.Text = "Sửa";
            this.btnExitP.Click += new System.EventHandler(this.btnExitP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDateP);
            this.groupBox2.Controls.Add(this.txtPlaceP);
            this.groupBox2.Controls.Add(this.txtNumberP);
            this.groupBox2.Controls.Add(this.txtRoomP);
            this.groupBox2.Controls.Add(this.txtNameP);
            this.groupBox2.Controls.Add(this.txtUserP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(26, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 404);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Tài Khoản";
            // 
            // cicrleAvatarP
            // 
            this.cicrleAvatarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cicrleAvatarP.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cicrleAvatarP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cicrleAvatarP.BorderColor2 = System.Drawing.Color.Gray;
            this.cicrleAvatarP.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cicrleAvatarP.BorderSize = 2;
            this.cicrleAvatarP.GradientAngle = 50F;
            this.cicrleAvatarP.Image = ((System.Drawing.Image)(resources.GetObject("cicrleAvatarP.Image")));
            this.cicrleAvatarP.Location = new System.Drawing.Point(655, 23);
            this.cicrleAvatarP.Margin = new System.Windows.Forms.Padding(4);
            this.cicrleAvatarP.Name = "cicrleAvatarP";
            this.cicrleAvatarP.Size = new System.Drawing.Size(151, 151);
            this.cicrleAvatarP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cicrleAvatarP.TabIndex = 9;
            this.cicrleAvatarP.TabStop = false;
            this.cicrleAvatarP.Click += new System.EventHandler(this.circlePictureBox1_Click);
            // 
            // txtDateP
            // 
            this.txtDateP.BorderRadius = 15;
            this.txtDateP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateP.DefaultText = "";
            this.txtDateP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDateP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDateP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateP.Enabled = false;
            this.txtDateP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDateP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateP.Location = new System.Drawing.Point(225, 333);
            this.txtDateP.Name = "txtDateP";
            this.txtDateP.PasswordChar = '\0';
            this.txtDateP.PlaceholderText = "";
            this.txtDateP.SelectedText = "";
            this.txtDateP.Size = new System.Drawing.Size(200, 36);
            this.txtDateP.TabIndex = 12;
            // 
            // txtPlaceP
            // 
            this.txtPlaceP.BorderRadius = 15;
            this.txtPlaceP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaceP.DefaultText = "";
            this.txtPlaceP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlaceP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlaceP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaceP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaceP.Enabled = false;
            this.txtPlaceP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlaceP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlaceP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlaceP.Location = new System.Drawing.Point(225, 268);
            this.txtPlaceP.Name = "txtPlaceP";
            this.txtPlaceP.PasswordChar = '\0';
            this.txtPlaceP.PlaceholderText = "";
            this.txtPlaceP.SelectedText = "";
            this.txtPlaceP.Size = new System.Drawing.Size(200, 36);
            this.txtPlaceP.TabIndex = 13;
            // 
            // txtNumberP
            // 
            this.txtNumberP.BorderRadius = 15;
            this.txtNumberP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberP.DefaultText = "";
            this.txtNumberP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberP.Enabled = false;
            this.txtNumberP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumberP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberP.Location = new System.Drawing.Point(225, 209);
            this.txtNumberP.Name = "txtNumberP";
            this.txtNumberP.PasswordChar = '\0';
            this.txtNumberP.PlaceholderText = "";
            this.txtNumberP.SelectedText = "";
            this.txtNumberP.Size = new System.Drawing.Size(200, 36);
            this.txtNumberP.TabIndex = 14;
            // 
            // txtRoomP
            // 
            this.txtRoomP.BorderRadius = 15;
            this.txtRoomP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomP.DefaultText = "";
            this.txtRoomP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomP.Enabled = false;
            this.txtRoomP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomP.Location = new System.Drawing.Point(225, 152);
            this.txtRoomP.Name = "txtRoomP";
            this.txtRoomP.PasswordChar = '\0';
            this.txtRoomP.PlaceholderText = "";
            this.txtRoomP.SelectedText = "";
            this.txtRoomP.Size = new System.Drawing.Size(200, 36);
            this.txtRoomP.TabIndex = 15;
            // 
            // txtNameP
            // 
            this.txtNameP.BorderRadius = 15;
            this.txtNameP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameP.DefaultText = "";
            this.txtNameP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameP.Enabled = false;
            this.txtNameP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameP.Location = new System.Drawing.Point(225, 94);
            this.txtNameP.Name = "txtNameP";
            this.txtNameP.PasswordChar = '\0';
            this.txtNameP.PlaceholderText = "";
            this.txtNameP.SelectedText = "";
            this.txtNameP.Size = new System.Drawing.Size(200, 36);
            this.txtNameP.TabIndex = 16;
            // 
            // txtUserP
            // 
            this.txtUserP.BorderColor = System.Drawing.Color.White;
            this.txtUserP.BorderRadius = 15;
            this.txtUserP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserP.DefaultText = "";
            this.txtUserP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserP.Enabled = false;
            this.txtUserP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserP.Location = new System.Drawing.Point(225, 36);
            this.txtUserP.Name = "txtUserP";
            this.txtUserP.PasswordChar = '\0';
            this.txtUserP.PlaceholderText = "";
            this.txtUserP.SelectedText = "";
            this.txtUserP.Size = new System.Drawing.Size(200, 36);
            this.txtUserP.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 349);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã phòng ban:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã nhân viên:";
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.cicrleAvatarP);
            this.Controls.Add(this.btnExitP);
            this.Controls.Add(this.btnCancelP);
            this.Controls.Add(this.btnSaveP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHoTen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserDetails";
            this.Size = new System.Drawing.Size(977, 548);
            this.Load += new System.EventHandler(this.UserDetails_Load);
            this.Enter += new System.EventHandler(this.UserDetails_Enter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cicrleAvatarP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnSaveP;
        private Guna.UI2.WinForms.Guna2Button btnCancelP;
        private Custom.CirclePictureBox cicrleAvatarP;
        private Guna.UI2.WinForms.Guna2Button btnExitP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtReNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPass;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtDateP;
        private Guna.UI2.WinForms.Guna2TextBox txtPlaceP;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberP;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomP;
        private Guna.UI2.WinForms.Guna2TextBox txtNameP;
        private Guna.UI2.WinForms.Guna2TextBox txtUserP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
