﻿namespace BTLon.Views.User
{
    partial class UserDetailDepart
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbQuanLy = new System.Windows.Forms.ComboBox();
            this.lbTenPB = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.lbMaPB = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Controls.Add(this.cbQuanLy);
            this.panelDetail.Controls.Add(this.lbTenPB);
            this.panelDetail.Controls.Add(this.txtTenPB);
            this.panelDetail.Controls.Add(this.lbMaPB);
            this.panelDetail.Controls.Add(this.txtMaPB);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(376, 641);
            this.panelDetail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý";
            // 
            // cbQuanLy
            // 
            this.cbQuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuanLy.Enabled = false;
            this.cbQuanLy.FormattingEnabled = true;
            this.cbQuanLy.Location = new System.Drawing.Point(200, 241);
            this.cbQuanLy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbQuanLy.Name = "cbQuanLy";
            this.cbQuanLy.Size = new System.Drawing.Size(160, 24);
            this.cbQuanLy.TabIndex = 4;
            // 
            // lbTenPB
            // 
            this.lbTenPB.AutoSize = true;
            this.lbTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPB.Location = new System.Drawing.Point(37, 215);
            this.lbTenPB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenPB.Name = "lbTenPB";
            this.lbTenPB.Size = new System.Drawing.Size(141, 24);
            this.lbTenPB.TabIndex = 3;
            this.lbTenPB.Text = "Tên phòng ban";
            // 
            // txtTenPB
            // 
            this.txtTenPB.Enabled = false;
            this.txtTenPB.Location = new System.Drawing.Point(23, 241);
            this.txtTenPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenPB.Multiline = true;
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(168, 25);
            this.txtTenPB.TabIndex = 2;
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
            this.lbMaPB.Size = new System.Drawing.Size(133, 24);
            this.lbMaPB.TabIndex = 1;
            this.lbMaPB.Text = "Mã phòng ban";
            this.lbMaPB.Click += new System.EventHandler(this.lbMaPB_Click);
            // 
            // txtMaPB
            // 
            this.txtMaPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPB.Enabled = false;
            this.txtMaPB.Location = new System.Drawing.Point(92, 142);
            this.txtMaPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPB.Multiline = true;
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(203, 29);
            this.txtMaPB.TabIndex = 0;
            // 
            // UserDetailDepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserDetailDepart";
            this.Size = new System.Drawing.Size(376, 641);
            this.Load += new System.EventHandler(this.UserDetailDepart_Load);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label lbMaPB;
        private System.Windows.Forms.ComboBox cbQuanLy;
        private System.Windows.Forms.Label lbTenPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Label label1;
    }
}
