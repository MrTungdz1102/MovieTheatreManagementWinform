namespace BTLon.Views.User
{
    partial class UserDetailRoom
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
            this.txtMaPC = new System.Windows.Forms.TextBox();
            this.txtSLGhe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenPC = new System.Windows.Forms.Label();
            this.txtTenPC = new System.Windows.Forms.TextBox();
            this.lbMaPC = new System.Windows.Forms.Label();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelDetail.Controls.Add(this.txtMaPC);
            this.panelDetail.Controls.Add(this.txtSLGhe);
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Controls.Add(this.lbTenPC);
            this.panelDetail.Controls.Add(this.txtTenPC);
            this.panelDetail.Controls.Add(this.lbMaPC);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(4);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(385, 641);
            this.panelDetail.TabIndex = 6;
            // 
            // txtMaPC
            // 
            this.txtMaPC.Enabled = false;
            this.txtMaPC.Location = new System.Drawing.Point(92, 153);
            this.txtMaPC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPC.Multiline = true;
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(203, 25);
            this.txtMaPC.TabIndex = 7;
            // 
            // txtSLGhe
            // 
            this.txtSLGhe.Enabled = false;
            this.txtSLGhe.Location = new System.Drawing.Point(92, 305);
            this.txtSLGhe.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLGhe.Multiline = true;
            this.txtSLGhe.Name = "txtSLGhe";
            this.txtSLGhe.Size = new System.Drawing.Size(203, 25);
            this.txtSLGhe.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số lượng ghế";
            // 
            // lbTenPC
            // 
            this.lbTenPC.AutoSize = true;
            this.lbTenPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPC.Location = new System.Drawing.Point(123, 202);
            this.lbTenPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenPC.Name = "lbTenPC";
            this.lbTenPC.Size = new System.Drawing.Size(156, 24);
            this.lbTenPC.TabIndex = 3;
            this.lbTenPC.Text = "Tên phòng chiếu";
            // 
            // txtTenPC
            // 
            this.txtTenPC.Enabled = false;
            this.txtTenPC.Location = new System.Drawing.Point(92, 228);
            this.txtTenPC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPC.Multiline = true;
            this.txtTenPC.Name = "txtTenPC";
            this.txtTenPC.Size = new System.Drawing.Size(203, 25);
            this.txtTenPC.TabIndex = 2;
            // 
            // lbMaPC
            // 
            this.lbMaPC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaPC.AutoSize = true;
            this.lbMaPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPC.Location = new System.Drawing.Point(123, 116);
            this.lbMaPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaPC.Name = "lbMaPC";
            this.lbMaPC.Size = new System.Drawing.Size(148, 24);
            this.lbMaPC.TabIndex = 1;
            this.lbMaPC.Text = "Mã phòng chiếu";
            // 
            // UserDetailRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserDetailRoom";
            this.Size = new System.Drawing.Size(385, 641);
            this.Load += new System.EventHandler(this.UserDetailRoom_Load);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenPC;
        private System.Windows.Forms.TextBox txtTenPC;
        private System.Windows.Forms.Label lbMaPC;
        private System.Windows.Forms.TextBox txtSLGhe;
        private System.Windows.Forms.TextBox txtMaPC;
    }
}
