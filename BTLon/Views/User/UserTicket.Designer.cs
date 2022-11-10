namespace BTLon.Views.User
{
    partial class UserTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTicket));
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.toolTipDelete = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEdit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSave = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panelPhim = new System.Windows.Forms.Panel();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnTicket = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhim = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.PanelListFilm = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            this.panelPhim.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(66, 488);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.guna2Separator1);
            this.panel3.Controls.Add(this.panelPhim);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(66, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 76);
            this.panel3.TabIndex = 9;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Separator1.Location = new System.Drawing.Point(30, 51);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(720, 2);
            this.guna2Separator1.TabIndex = 18;
            // 
            // panelPhim
            // 
            this.panelPhim.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelPhim.Controls.Add(this.btnBill);
            this.panelPhim.Controls.Add(this.btnTicket);
            this.panelPhim.Location = new System.Drawing.Point(20, 0);
            this.panelPhim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPhim.Name = "panelPhim";
            this.panelPhim.Size = new System.Drawing.Size(138, 53);
            this.panelPhim.TabIndex = 16;
            this.panelPhim.Visible = false;
            // 
            // btnBill
            // 
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FillColor = System.Drawing.Color.DimGray;
            this.btnBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Location = new System.Drawing.Point(0, 24);
            this.btnBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(138, 29);
            this.btnBill.TabIndex = 16;
            this.btnBill.Tag = "";
            this.btnBill.Text = "Phim sắp chiếu";
            // 
            // btnTicket
            // 
            this.btnTicket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTicket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTicket.FillColor = System.Drawing.Color.DimGray;
            this.btnTicket.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.Location = new System.Drawing.Point(0, 0);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(138, 24);
            this.btnTicket.TabIndex = 15;
            this.btnTicket.Tag = "";
            this.btnTicket.Text = "  Phim đang chiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phim Đang Chiếu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnPhim);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 33);
            this.panel1.TabIndex = 8;
            // 
            // btnPhim
            // 
            this.btnPhim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPhim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhim.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhim.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPhim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPhim.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPhim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPhim.Location = new System.Drawing.Point(86, 0);
            this.btnPhim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Size = new System.Drawing.Size(122, 33);
            this.btnPhim.TabIndex = 12;
            this.btnPhim.Text = "Phim";
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(15, 15);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 33);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(846, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(66, 488);
            this.panel5.TabIndex = 11;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.PanelListFilm);
            this.panelContent.Controls.Add(this.panel3);
            this.panelContent.Controls.Add(this.panel4);
            this.panelContent.Controls.Add(this.panel5);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 33);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(912, 488);
            this.panelContent.TabIndex = 13;
            // 
            // PanelListFilm
            // 
            this.PanelListFilm.AutoScroll = true;
            this.PanelListFilm.BackColor = System.Drawing.SystemColors.Window;
            this.PanelListFilm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelListFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListFilm.Location = new System.Drawing.Point(66, 76);
            this.PanelListFilm.Name = "PanelListFilm";
            this.PanelListFilm.Size = new System.Drawing.Size(780, 412);
            this.PanelListFilm.TabIndex = 12;
            // 
            // UserTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserTicket";
            this.Size = new System.Drawing.Size(912, 521);
            this.Load += new System.EventHandler(this.UserTicket_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelPhim.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.ToolTip toolTipDelete;
        private System.Windows.Forms.ToolTip toolTipAdd;
        private System.Windows.Forms.ToolTip toolTipEdit;
        private System.Windows.Forms.ToolTip toolTipSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelPhim;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2Button btnTicket;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2GradientButton btnPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContent;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.FlowLayoutPanel PanelListFilm;
    }
}
