namespace BTLon.Views.User
{
    partial class UserShowTimes
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
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblThoiGianChieu = new System.Windows.Forms.Label();
            this.panelListButton = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.CalendarDimensions = new System.Drawing.Size(4, 1);
            this.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calendar.Location = new System.Drawing.Point(0, 0);
            this.Calendar.MaxDate = new System.DateTime(2023, 1, 15, 0, 0, 0, 0);
            this.Calendar.MinDate = new System.DateTime(2022, 4, 11, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToday = false;
            this.Calendar.TabIndex = 2;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1064, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 594);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Calendar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 207);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.guna2Separator1);
            this.panel3.Controls.Add(this.lblThoiGianChieu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 207);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 57);
            this.panel3.TabIndex = 5;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Separator1.Location = new System.Drawing.Point(-3, 49);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1061, 2);
            this.guna2Separator1.TabIndex = 0;
            // 
            // lblThoiGianChieu
            // 
            this.lblThoiGianChieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThoiGianChieu.AutoSize = true;
            this.lblThoiGianChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianChieu.Location = new System.Drawing.Point(429, 16);
            this.lblThoiGianChieu.Name = "lblThoiGianChieu";
            this.lblThoiGianChieu.Size = new System.Drawing.Size(206, 29);
            this.lblThoiGianChieu.TabIndex = 0;
            this.lblThoiGianChieu.Text = "Chọn ngày chiếu";
            // 
            // panelListButton
            // 
            this.panelListButton.BackColor = System.Drawing.SystemColors.Window;
            this.panelListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListButton.Location = new System.Drawing.Point(0, 264);
            this.panelListButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelListButton.Name = "panelListButton";
            this.panelListButton.Size = new System.Drawing.Size(1064, 330);
            this.panelListButton.TabIndex = 6;
            // 
            // UserShowTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panelListButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserShowTimes";
            this.Size = new System.Drawing.Size(1216, 594);
            this.Load += new System.EventHandler(this.UserShowTimes_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblThoiGianChieu;
        private System.Windows.Forms.FlowLayoutPanel panelListButton;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
