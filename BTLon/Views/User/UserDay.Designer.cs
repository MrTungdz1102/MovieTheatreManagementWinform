namespace BTLon.Views.User
{
    partial class UserDay
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
            this.dgvLoaiNgay = new System.Windows.Forms.DataGridView();
            this.txtLoaiNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiaNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiNgay
            // 
            this.dgvLoaiNgay.AllowUserToAddRows = false;
            this.dgvLoaiNgay.AllowUserToResizeColumns = false;
            this.dgvLoaiNgay.AllowUserToResizeRows = false;
            this.dgvLoaiNgay.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLoaiNgay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiNgay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvLoaiNgay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiNgay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiNgay.ColumnHeadersHeight = 35;
            this.dgvLoaiNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtLoaiNgay,
            this.txtGiaNgay,
            this.txtMoTa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiNgay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiNgay.EnableHeadersVisualStyles = false;
            this.dgvLoaiNgay.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLoaiNgay.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaiNgay.Name = "dgvLoaiNgay";
            this.dgvLoaiNgay.ReadOnly = true;
            this.dgvLoaiNgay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiNgay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiNgay.RowHeadersVisible = false;
            this.dgvLoaiNgay.RowHeadersWidth = 51;
            this.dgvLoaiNgay.RowTemplate.Height = 26;
            this.dgvLoaiNgay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiNgay.Size = new System.Drawing.Size(422, 228);
            this.dgvLoaiNgay.TabIndex = 10;
            this.dgvLoaiNgay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiNgay_CellClick);
            // 
            // txtLoaiNgay
            // 
            this.txtLoaiNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtLoaiNgay.DataPropertyName = "LoaiNgay";
            this.txtLoaiNgay.HeaderText = "Loại ngày";
            this.txtLoaiNgay.MinimumWidth = 6;
            this.txtLoaiNgay.Name = "txtLoaiNgay";
            this.txtLoaiNgay.ReadOnly = true;
            this.txtLoaiNgay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtLoaiNgay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtGiaNgay
            // 
            this.txtGiaNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtGiaNgay.DataPropertyName = "GiaNgay";
            this.txtGiaNgay.FillWeight = 140F;
            this.txtGiaNgay.HeaderText = "Giá ngày";
            this.txtGiaNgay.MinimumWidth = 6;
            this.txtGiaNgay.Name = "txtGiaNgay";
            this.txtGiaNgay.ReadOnly = true;
            this.txtGiaNgay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtMoTa
            // 
            this.txtMoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMoTa.DataPropertyName = "MoTa";
            this.txtMoTa.HeaderText = "Mô tả";
            this.txtMoTa.MinimumWidth = 6;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtMoTa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLoaiNgay);
            this.Name = "UserDay";
            this.Size = new System.Drawing.Size(422, 228);
            this.Load += new System.EventHandler(this.UserDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNgay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLoaiNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGiaNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMoTa;
    }
}
