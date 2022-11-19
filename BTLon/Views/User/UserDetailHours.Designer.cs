namespace BTLon.Views.User
{
    partial class UserDetailHours
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
            this.panelDetail = new System.Windows.Forms.Panel();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lbMoTa = new System.Windows.Forms.Label();
            this.lbGiaGio = new System.Windows.Forms.Label();
            this.txtGiaGio = new System.Windows.Forms.TextBox();
            this.lbLoaiGio = new System.Windows.Forms.Label();
            this.txtLoaiGio = new System.Windows.Forms.TextBox();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelDetail.Controls.Add(this.txtLoaiGio);
            this.panelDetail.Controls.Add(this.txtMoTa);
            this.panelDetail.Controls.Add(this.lbMoTa);
            this.panelDetail.Controls.Add(this.lbGiaGio);
            this.panelDetail.Controls.Add(this.txtGiaGio);
            this.panelDetail.Controls.Add(this.lbLoaiGio);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(385, 641);
            this.panelDetail.TabIndex = 8;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Enabled = false;
            this.txtMoTa.Location = new System.Drawing.Point(92, 305);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(203, 25);
            this.txtMoTa.TabIndex = 6;
            // 
            // lbMoTa
            // 
            this.lbMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMoTa.AutoSize = true;
            this.lbMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoTa.Location = new System.Drawing.Point(156, 279);
            this.lbMoTa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMoTa.Name = "lbMoTa";
            this.lbMoTa.Size = new System.Drawing.Size(56, 24);
            this.lbMoTa.TabIndex = 5;
            this.lbMoTa.Text = "Mô tả";
            // 
            // lbGiaGio
            // 
            this.lbGiaGio.AutoSize = true;
            this.lbGiaGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaGio.Location = new System.Drawing.Point(156, 202);
            this.lbGiaGio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGiaGio.Name = "lbGiaGio";
            this.lbGiaGio.Size = new System.Drawing.Size(69, 24);
            this.lbGiaGio.TabIndex = 3;
            this.lbGiaGio.Text = "Giá giờ";
            // 
            // txtGiaGio
            // 
            this.txtGiaGio.Enabled = false;
            this.txtGiaGio.Location = new System.Drawing.Point(92, 228);
            this.txtGiaGio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaGio.Multiline = true;
            this.txtGiaGio.Name = "txtGiaGio";
            this.txtGiaGio.Size = new System.Drawing.Size(203, 25);
            this.txtGiaGio.TabIndex = 2;
            // 
            // lbLoaiGio
            // 
            this.lbLoaiGio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoaiGio.AutoSize = true;
            this.lbLoaiGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiGio.Location = new System.Drawing.Point(156, 133);
            this.lbLoaiGio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiGio.Name = "lbLoaiGio";
            this.lbLoaiGio.Size = new System.Drawing.Size(76, 24);
            this.lbLoaiGio.TabIndex = 1;
            this.lbLoaiGio.Text = "Loại giờ";
            // 
            // txtLoaiGio
            // 
            this.txtLoaiGio.Enabled = false;
            this.txtLoaiGio.Location = new System.Drawing.Point(92, 161);
            this.txtLoaiGio.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoaiGio.Multiline = true;
            this.txtLoaiGio.Name = "txtLoaiGio";
            this.txtLoaiGio.Size = new System.Drawing.Size(203, 25);
            this.txtLoaiGio.TabIndex = 7;
            // 
            // UserDetailHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserDetailHours";
            this.Size = new System.Drawing.Size(385, 641);
            this.Load += new System.EventHandler(this.UserDetailHours_Load);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lbMoTa;
        private System.Windows.Forms.Label lbGiaGio;
        private System.Windows.Forms.TextBox txtGiaGio;
        private System.Windows.Forms.Label lbLoaiGio;
        private System.Windows.Forms.TextBox txtLoaiGio;
    }
}
