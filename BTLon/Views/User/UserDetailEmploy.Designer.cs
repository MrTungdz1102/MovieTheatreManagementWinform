namespace BTLon.Views.User
{
    partial class UserDetailEmploy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetailEmploy));
            this.panelDetail = new System.Windows.Forms.Panel();
            this.btnDele = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ptbAvt = new System.Windows.Forms.PictureBox();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelDetail.Controls.Add(this.panel1);
            this.panelDetail.Controls.Add(this.splitter2);
            this.panelDetail.Controls.Add(this.ptbAvt);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(164, 521);
            this.panelDetail.TabIndex = 4;
            // 
            // btnDele
            // 
            this.btnDele.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDele.BorderRadius = 8;
            this.btnDele.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDele.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDele.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDele.FillColor = System.Drawing.Color.Red;
            this.btnDele.FillColor2 = System.Drawing.Color.Red;
            this.btnDele.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDele.ForeColor = System.Drawing.Color.White;
            this.btnDele.Location = new System.Drawing.Point(16, 6);
            this.btnDele.Name = "btnDele";
            this.btnDele.Size = new System.Drawing.Size(131, 22);
            this.btnDele.TabIndex = 4;
            this.btnDele.Text = "Delete";
            this.btnDele.Click += new System.EventHandler(this.btnDele_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.BorderRadius = 8;
            this.btnUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUp.FillColor = System.Drawing.Color.Gray;
            this.btnUp.FillColor2 = System.Drawing.Color.Gray;
            this.btnUp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(16, 34);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(131, 22);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Upload";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // ptbAvt
            // 
            this.ptbAvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbAvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbAvt.Image = ((System.Drawing.Image)(resources.GetObject("ptbAvt.Image")));
            this.ptbAvt.Location = new System.Drawing.Point(0, 0);
            this.ptbAvt.Name = "ptbAvt";
            this.ptbAvt.Size = new System.Drawing.Size(164, 118);
            this.ptbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvt.TabIndex = 0;
            this.ptbAvt.TabStop = false;
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog1";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 118);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(164, 3);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.btnDele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 60);
            this.panel1.TabIndex = 7;
            // 
            // UserDetailEmploy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Name = "UserDetailEmploy";
            this.Size = new System.Drawing.Size(164, 521);
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.PictureBox ptbAvt;
        private Guna.UI2.WinForms.Guna2GradientButton btnDele;
        private Guna.UI2.WinForms.Guna2GradientButton btnUp;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
    }
}
