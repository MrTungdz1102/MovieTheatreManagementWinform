namespace BTLon.Views.User
{
    partial class UserListMovieChelude
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
            this.dgvLichChieu = new System.Windows.Forms.DataGridView();
            this.txtMaLichChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMaPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGioBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoaiNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoaiGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiaLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichChieu
            // 
            this.dgvLichChieu.AllowUserToAddRows = false;
            this.dgvLichChieu.AllowUserToResizeColumns = false;
            this.dgvLichChieu.AllowUserToResizeRows = false;
            this.dgvLichChieu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLichChieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichChieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvLichChieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichChieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichChieu.ColumnHeadersHeight = 44;
            this.dgvLichChieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaLichChieu,
            this.txtMaPhim,
            this.cbMaPC,
            this.txtNgayChieu,
            this.txtGioBD,
            this.txtLoaiNgay,
            this.txtLoaiGio,
            this.txtGiaLC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichChieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichChieu.EnableHeadersVisualStyles = false;
            this.dgvLichChieu.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLichChieu.Location = new System.Drawing.Point(0, 0);
            this.dgvLichChieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichChieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichChieu.RowHeadersVisible = false;
            this.dgvLichChieu.RowHeadersWidth = 51;
            this.dgvLichChieu.RowTemplate.Height = 26;
            this.dgvLichChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichChieu.Size = new System.Drawing.Size(1216, 641);
            this.dgvLichChieu.TabIndex = 9;
            this.dgvLichChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichChieu_CellClick);
            // 
            // txtMaLichChieu
            // 
            this.txtMaLichChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMaLichChieu.DataPropertyName = "MaLichChieu";
            this.txtMaLichChieu.HeaderText = "Mã Lịch Chiếu";
            this.txtMaLichChieu.MinimumWidth = 6;
            this.txtMaLichChieu.Name = "txtMaLichChieu";
            this.txtMaLichChieu.ReadOnly = true;
            this.txtMaLichChieu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMaPhim.DataPropertyName = "MaPhim";
            this.txtMaPhim.FillWeight = 140F;
            this.txtMaPhim.HeaderText = "Mã Phim";
            this.txtMaPhim.MinimumWidth = 6;
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cbMaPC
            // 
            this.cbMaPC.DataPropertyName = "MaPC";
            this.cbMaPC.HeaderText = "Mã Phòng Chiếu";
            this.cbMaPC.MinimumWidth = 6;
            this.cbMaPC.Name = "cbMaPC";
            this.cbMaPC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbMaPC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cbMaPC.Width = 125;
            // 
            // txtNgayChieu
            // 
            this.txtNgayChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNgayChieu.DataPropertyName = "NgayChieu";
            this.txtNgayChieu.HeaderText = "Ngày Chiếu";
            this.txtNgayChieu.MinimumWidth = 6;
            this.txtNgayChieu.Name = "txtNgayChieu";
            this.txtNgayChieu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtGioBD
            // 
            this.txtGioBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtGioBD.DataPropertyName = "GioBD";
            this.txtGioBD.HeaderText = "Giờ BĐ";
            this.txtGioBD.MinimumWidth = 6;
            this.txtGioBD.Name = "txtGioBD";
            this.txtGioBD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtLoaiNgay
            // 
            this.txtLoaiNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtLoaiNgay.DataPropertyName = "LoaiNgay";
            this.txtLoaiNgay.HeaderText = "Loại Ngày";
            this.txtLoaiNgay.MinimumWidth = 6;
            this.txtLoaiNgay.Name = "txtLoaiNgay";
            this.txtLoaiNgay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtLoaiGio
            // 
            this.txtLoaiGio.DataPropertyName = "LoaiGio";
            this.txtLoaiGio.HeaderText = "Loại Giờ";
            this.txtLoaiGio.MinimumWidth = 6;
            this.txtLoaiGio.Name = "txtLoaiGio";
            this.txtLoaiGio.Width = 125;
            // 
            // txtGiaLC
            // 
            this.txtGiaLC.DataPropertyName = "GiaLC";
            this.txtGiaLC.HeaderText = "Giá LC";
            this.txtGiaLC.MinimumWidth = 6;
            this.txtGiaLC.Name = "txtGiaLC";
            this.txtGiaLC.Width = 125;
            // 
            // UserListMovieChelude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLichChieu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserListMovieChelude";
            this.Size = new System.Drawing.Size(1216, 641);
            this.Load += new System.EventHandler(this.UserListMovieChelude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaLichChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbMaPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGioBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLoaiNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLoaiGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGiaLC;
    }
}
