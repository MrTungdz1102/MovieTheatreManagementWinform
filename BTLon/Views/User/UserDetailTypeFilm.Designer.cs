namespace BTLon.Views.User
{
    partial class UserDetailTypeFilm
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
            this.lbTenLP = new System.Windows.Forms.Label();
            this.txtTenLP = new System.Windows.Forms.TextBox();
            this.lbMaPB = new System.Windows.Forms.Label();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelDetail.Controls.Add(this.lbTenLP);
            this.panelDetail.Controls.Add(this.txtTenLP);
            this.panelDetail.Controls.Add(this.lbMaPB);
            this.panelDetail.Controls.Add(this.txtMaLP);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(4);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(376, 641);
            this.panelDetail.TabIndex = 6;
            // 
            // lbTenLP
            // 
            this.lbTenLP.AutoSize = true;
            this.lbTenLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLP.Location = new System.Drawing.Point(123, 223);
            this.lbTenLP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenLP.Name = "lbTenLP";
            this.lbTenLP.Size = new System.Drawing.Size(125, 24);
            this.lbTenLP.TabIndex = 3;
            this.lbTenLP.Text = "Tên loại phim";
            // 
            // txtTenLP
            // 
            this.txtTenLP.Enabled = false;
            this.txtTenLP.Location = new System.Drawing.Point(92, 251);
            this.txtTenLP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLP.Multiline = true;
            this.txtTenLP.Name = "txtTenLP";
            this.txtTenLP.Size = new System.Drawing.Size(203, 25);
            this.txtTenLP.TabIndex = 2;
            // 
            // lbMaPB
            // 
            this.lbMaPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaPB.AutoSize = true;
            this.lbMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPB.Location = new System.Drawing.Point(123, 116);
            this.lbMaPB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaPB.Name = "lbMaPB";
            this.lbMaPB.Size = new System.Drawing.Size(117, 24);
            this.lbMaPB.TabIndex = 1;
            this.lbMaPB.Text = "Mã loại phim";
            // 
            // txtMaLP
            // 
            this.txtMaLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLP.Enabled = false;
            this.txtMaLP.Location = new System.Drawing.Point(92, 142);
            this.txtMaLP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLP.Multiline = true;
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.Size = new System.Drawing.Size(203, 29);
            this.txtMaLP.TabIndex = 0;
            // 
            // UserDetailTypeFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Name = "UserDetailTypeFilm";
            this.Size = new System.Drawing.Size(376, 641);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label lbTenLP;
        private System.Windows.Forms.TextBox txtTenLP;
        private System.Windows.Forms.Label lbMaPB;
        private System.Windows.Forms.TextBox txtMaLP;
    }
}
