namespace BTLon.Views.User
{
    partial class UserTypeFilm
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
            this.dgvLoaiPhim = new System.Windows.Forms.DataGridView();
            this.txtMaLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiPhim
            // 
            this.dgvLoaiPhim.AllowUserToAddRows = false;
            this.dgvLoaiPhim.AllowUserToResizeColumns = false;
            this.dgvLoaiPhim.AllowUserToResizeRows = false;
            this.dgvLoaiPhim.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLoaiPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiPhim.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvLoaiPhim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiPhim.ColumnHeadersHeight = 35;
            this.dgvLoaiPhim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaLP,
            this.txtTenLP});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiPhim.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiPhim.EnableHeadersVisualStyles = false;
            this.dgvLoaiPhim.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLoaiPhim.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaiPhim.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLoaiPhim.Name = "dgvLoaiPhim";
            this.dgvLoaiPhim.ReadOnly = true;
            this.dgvLoaiPhim.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhim.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiPhim.RowHeadersVisible = false;
            this.dgvLoaiPhim.RowHeadersWidth = 51;
            this.dgvLoaiPhim.RowTemplate.Height = 26;
            this.dgvLoaiPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhim.Size = new System.Drawing.Size(563, 281);
            this.dgvLoaiPhim.TabIndex = 9;
            this.dgvLoaiPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiPhim_CellClick);
            // 
            // txtMaLP
            // 
            this.txtMaLP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMaLP.DataPropertyName = "MaLP";
            this.txtMaLP.HeaderText = "Mã loại phim";
            this.txtMaLP.MinimumWidth = 6;
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.ReadOnly = true;
            this.txtMaLP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtMaLP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtTenLP
            // 
            this.txtTenLP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTenLP.DataPropertyName = "TenLP";
            this.txtTenLP.FillWeight = 140F;
            this.txtTenLP.HeaderText = "Tên loại phim";
            this.txtTenLP.MinimumWidth = 6;
            this.txtTenLP.Name = "txtTenLP";
            this.txtTenLP.ReadOnly = true;
            this.txtTenLP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserTypeFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLoaiPhim);
            this.Name = "UserTypeFilm";
            this.Size = new System.Drawing.Size(563, 281);
            this.Load += new System.EventHandler(this.UserTypeFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenLP;
    }
}
