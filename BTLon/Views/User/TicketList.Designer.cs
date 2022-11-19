namespace BTLon.Views.User
{
    partial class TicketList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketList));
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpKT = new System.Windows.Forms.DateTimePicker();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSeach = new BTLon.Views.Custom.TextBoxCus();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.cbbTK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaNV";
            this.Column4.HeaderText = "Mã nhân viên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayBan";
            this.Column2.HeaderText = "Ngày bán";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "GiaVe";
            this.GiaVe.HeaderText = "Giá vé";
            this.GiaVe.MinimumWidth = 6;
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            this.GiaVe.Width = 125;
            // 
            // txtQuanLy
            // 
            this.txtQuanLy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtQuanLy.DataPropertyName = "MaGhe";
            this.txtQuanLy.HeaderText = "Mã ghế";
            this.txtQuanLy.MinimumWidth = 6;
            this.txtQuanLy.Name = "txtQuanLy";
            this.txtQuanLy.ReadOnly = true;
            this.txtQuanLy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtQuanLy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtTenPB
            // 
            this.txtTenPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTenPB.DataPropertyName = "MaLichChieu";
            this.txtTenPB.FillWeight = 140F;
            this.txtTenPB.HeaderText = "Mã lịch chiếu";
            this.txtTenPB.MinimumWidth = 6;
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.ReadOnly = true;
            this.txtTenPB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtMaPB
            // 
            this.txtMaPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMaPB.DataPropertyName = "MaVe";
            this.txtMaPB.HeaderText = "Mã vé";
            this.txtMaPB.MinimumWidth = 6;
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.ReadOnly = true;
            this.txtMaPB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtMaPB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvVe
            // 
            this.dgvVe.AllowUserToAddRows = false;
            this.dgvVe.AllowUserToResizeColumns = false;
            this.dgvVe.AllowUserToResizeRows = false;
            this.dgvVe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvVe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVe.ColumnHeadersHeight = 35;
            this.dgvVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaPB,
            this.txtTenPB,
            this.txtQuanLy,
            this.GiaVe,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVe.EnableHeadersVisualStyles = false;
            this.dgvVe.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVe.Location = new System.Drawing.Point(48, 152);
            this.dgvVe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.ReadOnly = true;
            this.dgvVe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVe.RowHeadersVisible = false;
            this.dgvVe.RowHeadersWidth = 51;
            this.dgvVe.RowTemplate.Height = 26;
            this.dgvVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVe.Size = new System.Drawing.Size(1157, 449);
            this.dgvVe.TabIndex = 14;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaKH";
            this.Column3.HeaderText = "Mã khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1205, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 449);
            this.panel5.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 449);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblSL);
            this.panel3.Controls.Add(this.btnExcel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 601);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 84);
            this.panel3.TabIndex = 11;
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTien.Location = new System.Drawing.Point(981, 40);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(67, 26);
            this.lblTien.TabIndex = 3;
            this.lblTien.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(822, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng tiền:";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(981, 4);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(67, 26);
            this.lblSL.TabIndex = 1;
            this.lblSL.Text = "label3";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(1113, 14);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(91, 52);
            this.btnExcel.TabIndex = 17;
            this.btnExcel.Text = "In";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(822, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số lượng:";
            // 
            // dtpKT
            // 
            this.dtpKT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKT.Location = new System.Drawing.Point(396, 68);
            this.dtpKT.Name = "dtpKT";
            this.dtpKT.Size = new System.Drawing.Size(146, 34);
            this.dtpKT.TabIndex = 1;
            // 
            // dtpBD
            // 
            this.dtpBD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBD.Location = new System.Drawing.Point(186, 66);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(152, 34);
            this.dtpBD.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtSeach
            // 
            this.txtSeach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSeach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtSeach.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSeach.BorderSize = 2;
            this.txtSeach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeach.ForeColor = System.Drawing.Color.DimGray;
            this.txtSeach.Location = new System.Drawing.Point(63, 4);
            this.txtSeach.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeach.Multiline = false;
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Padding = new System.Windows.Forms.Padding(9);
            this.txtSeach.PasswordChar = false;
            this.txtSeach.Size = new System.Drawing.Size(240, 41);
            this.txtSeach.TabIndex = 0;
            this.txtSeach.Texts = "Seach...";
            this.txtSeach.UnderlinedStyle = true;
            this.txtSeach._TextChanged += new System.EventHandler(this.txtSeach__TextChanged);
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen.Location = new System.Drawing.Point(344, 74);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(46, 26);
            this.lblDen.TabIndex = 21;
            this.lblDen.Text = "đến";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTu.Location = new System.Drawing.Point(142, 72);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(38, 26);
            this.lblTu.TabIndex = 20;
            this.lblTu.Text = "Từ";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(15, 104);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(121, 38);
            this.btnShow.TabIndex = 19;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cbbTK
            // 
            this.cbbTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbTK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTK.FormattingEnabled = true;
            this.cbbTK.Location = new System.Drawing.Point(15, 64);
            this.cbbTK.Name = "cbbTK";
            this.cbbTK.Size = new System.Drawing.Size(121, 34);
            this.cbbTK.TabIndex = 18;
            this.cbbTK.Text = "Tất cả";
            this.cbbTK.SelectedIndexChanged += new System.EventHandler(this.cbbTK_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(373, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO THÔNG TIN VÉ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.txtSeach);
            this.panel6.Location = new System.Drawing.Point(901, 100);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(307, 44);
            this.panel6.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDen);
            this.panel2.Controls.Add(this.lblTu);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.cbbTK);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.dtpKT);
            this.panel2.Controls.Add(this.dtpBD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 152);
            this.panel2.TabIndex = 10;
            // 
            // TicketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "TicketList";
            this.Size = new System.Drawing.Size(1221, 685);
            this.Load += new System.EventHandler(this.TicketList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaPB;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKT;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Custom.TextBoxCus txtSeach;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cbbTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
    }
}
