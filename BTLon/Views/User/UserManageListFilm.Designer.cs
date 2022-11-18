namespace BTLon.Views.User
{
    partial class UserManageListFilm
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
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.txtMaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDaoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNamSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiaVeCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhim
            // 
            this.dgvPhim.AllowUserToAddRows = false;
            this.dgvPhim.AllowUserToResizeColumns = false;
            this.dgvPhim.AllowUserToResizeRows = false;
            this.dgvPhim.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhim.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPhim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhim.ColumnHeadersHeight = 44;
            this.dgvPhim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaPhim,
            this.txtTenPhim,
            this.txtDaoDien,
            this.txtNamSX,
            this.txtNuocSX,
            this.txtThoiLuong,
            this.txtMaLP,
            this.txtTenDD,
            this.txtGiaVeCB});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhim.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhim.EnableHeadersVisualStyles = false;
            this.dgvPhim.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPhim.Location = new System.Drawing.Point(0, 0);
            this.dgvPhim.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhim.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhim.RowHeadersVisible = false;
            this.dgvPhim.RowHeadersWidth = 51;
            this.dgvPhim.RowTemplate.Height = 26;
            this.dgvPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhim.Size = new System.Drawing.Size(1216, 641);
            this.dgvPhim.TabIndex = 9;
            this.dgvPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellClick);
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMaPhim.DataPropertyName = "MaPhim";
            this.txtMaPhim.HeaderText = "Mã phim";
            this.txtMaPhim.MinimumWidth = 6;
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTenPhim.DataPropertyName = "TenPhim";
            this.txtTenPhim.FillWeight = 140F;
            this.txtTenPhim.HeaderText = "Tên phim";
            this.txtTenPhim.MinimumWidth = 6;
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtDaoDien.DataPropertyName = "DaoDien";
            this.txtDaoDien.HeaderText = "Đạo diễn";
            this.txtDaoDien.MinimumWidth = 6;
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtNamSX
            // 
            this.txtNamSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNamSX.DataPropertyName = "NamSX";
            this.txtNamSX.HeaderText = "Năm SX";
            this.txtNamSX.MinimumWidth = 6;
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNuocSX.DataPropertyName = "NuocSX";
            this.txtNuocSX.HeaderText = "Nước SX";
            this.txtNuocSX.MinimumWidth = 6;
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.DataPropertyName = "ThoiLuong";
            this.txtThoiLuong.HeaderText = "Thời lượng";
            this.txtThoiLuong.MinimumWidth = 6;
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Width = 125;
            // 
            // txtMaLP
            // 
            this.txtMaLP.DataPropertyName = "MaLP";
            this.txtMaLP.HeaderText = "Mã LP";
            this.txtMaLP.MinimumWidth = 6;
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.Width = 125;
            // 
            // txtTenDD
            // 
            this.txtTenDD.DataPropertyName = "TenDD";
            this.txtTenDD.HeaderText = "Định Dạng";
            this.txtTenDD.MinimumWidth = 6;
            this.txtTenDD.Name = "txtTenDD";
            this.txtTenDD.Width = 125;
            // 
            // txtGiaVeCB
            // 
            this.txtGiaVeCB.DataPropertyName = "GiaVeCoBan";
            this.txtGiaVeCB.HeaderText = "Giá Vé Cơ Bản";
            this.txtGiaVeCB.MinimumWidth = 6;
            this.txtGiaVeCB.Name = "txtGiaVeCB";
            this.txtGiaVeCB.Width = 125;
            // 
            // UserManageListFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPhim);
            this.Name = "UserManageListFilm";
            this.Size = new System.Drawing.Size(1216, 641);
            this.Load += new System.EventHandler(this.userListManageFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDaoDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNamSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNuocSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtThoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGiaVeCB;
    }
}
