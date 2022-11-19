namespace BTLon.Views.User
{
    partial class UserRoom
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
            this.dgvPhongChieu = new System.Windows.Forms.DataGridView();
            this.txtMaPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuongGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongChieu
            // 
            this.dgvPhongChieu.AllowUserToAddRows = false;
            this.dgvPhongChieu.AllowUserToResizeColumns = false;
            this.dgvPhongChieu.AllowUserToResizeRows = false;
            this.dgvPhongChieu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhongChieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhongChieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPhongChieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongChieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhongChieu.ColumnHeadersHeight = 35;
            this.dgvPhongChieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaPC,
            this.txtTenPC,
            this.txtSoLuongGhe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongChieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhongChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongChieu.EnableHeadersVisualStyles = false;
            this.dgvPhongChieu.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPhongChieu.Location = new System.Drawing.Point(0, 0);
            this.dgvPhongChieu.Name = "dgvPhongChieu";
            this.dgvPhongChieu.ReadOnly = true;
            this.dgvPhongChieu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongChieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhongChieu.RowHeadersVisible = false;
            this.dgvPhongChieu.RowHeadersWidth = 51;
            this.dgvPhongChieu.RowTemplate.Height = 26;
            this.dgvPhongChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongChieu.Size = new System.Drawing.Size(422, 228);
            this.dgvPhongChieu.TabIndex = 9;
            this.dgvPhongChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongChieu_CellClick);
            // 
            // txtMaPC
            // 
            this.txtMaPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMaPC.DataPropertyName = "MaPC";
            this.txtMaPC.HeaderText = "Mã phòng chiếu";
            this.txtMaPC.MinimumWidth = 6;
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.ReadOnly = true;
            this.txtMaPC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtMaPC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtTenPC
            // 
            this.txtTenPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTenPC.DataPropertyName = "TenPC";
            this.txtTenPC.FillWeight = 140F;
            this.txtTenPC.HeaderText = "Tên phòng chiếu";
            this.txtTenPC.MinimumWidth = 6;
            this.txtTenPC.Name = "txtTenPC";
            this.txtTenPC.ReadOnly = true;
            this.txtTenPC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtSoLuongGhe
            // 
            this.txtSoLuongGhe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtSoLuongGhe.DataPropertyName = "SoLuongGhe";
            this.txtSoLuongGhe.HeaderText = "Số lượng ghế";
            this.txtSoLuongGhe.MinimumWidth = 6;
            this.txtSoLuongGhe.Name = "txtSoLuongGhe";
            this.txtSoLuongGhe.ReadOnly = true;
            this.txtSoLuongGhe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtSoLuongGhe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPhongChieu);
            this.Name = "UserRoom";
            this.Size = new System.Drawing.Size(422, 228);
            this.Load += new System.EventHandler(this.UserRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSoLuongGhe;
    }
}
