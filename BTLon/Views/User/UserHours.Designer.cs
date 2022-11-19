namespace BTLon.Views.User
{
    partial class UserHours
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
            this.dgvLoaiGio = new System.Windows.Forms.DataGridView();
            this.txtLoaiGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiaGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiGio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiGio
            // 
            this.dgvLoaiGio.AllowUserToAddRows = false;
            this.dgvLoaiGio.AllowUserToResizeColumns = false;
            this.dgvLoaiGio.AllowUserToResizeRows = false;
            this.dgvLoaiGio.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLoaiGio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiGio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvLoaiGio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiGio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiGio.ColumnHeadersHeight = 35;
            this.dgvLoaiGio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtLoaiGio,
            this.txtGiaGio,
            this.txtMoTa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiGio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiGio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiGio.EnableHeadersVisualStyles = false;
            this.dgvLoaiGio.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLoaiGio.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaiGio.Name = "dgvLoaiGio";
            this.dgvLoaiGio.ReadOnly = true;
            this.dgvLoaiGio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiGio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiGio.RowHeadersVisible = false;
            this.dgvLoaiGio.RowHeadersWidth = 51;
            this.dgvLoaiGio.RowTemplate.Height = 26;
            this.dgvLoaiGio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiGio.Size = new System.Drawing.Size(422, 228);
            this.dgvLoaiGio.TabIndex = 11;
            this.dgvLoaiGio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiGio_CellClick);
            // 
            // txtLoaiGio
            // 
            this.txtLoaiGio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtLoaiGio.DataPropertyName = "LoaiGio";
            this.txtLoaiGio.HeaderText = "Loại giờ";
            this.txtLoaiGio.MinimumWidth = 6;
            this.txtLoaiGio.Name = "txtLoaiGio";
            this.txtLoaiGio.ReadOnly = true;
            this.txtLoaiGio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtLoaiGio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtGiaGio
            // 
            this.txtGiaGio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtGiaGio.DataPropertyName = "GiaGio";
            this.txtGiaGio.FillWeight = 140F;
            this.txtGiaGio.HeaderText = "Giá giờ";
            this.txtGiaGio.MinimumWidth = 6;
            this.txtGiaGio.Name = "txtGiaGio";
            this.txtGiaGio.ReadOnly = true;
            this.txtGiaGio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // UserHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLoaiGio);
            this.Name = "UserHours";
            this.Size = new System.Drawing.Size(422, 228);
            this.Load += new System.EventHandler(this.UserHours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiGio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLoaiGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGiaGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMoTa;
    }
}
