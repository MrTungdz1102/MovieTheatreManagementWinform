namespace BTLon.Views.User
{
    partial class Trend
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartSP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chartPhim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbThongKe = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panelKH = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartSP)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhim)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSP
            // 
            chartArea1.BackColor = System.Drawing.Color.Snow;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Black;
            this.chartSP.ChartAreas.Add(chartArea1);
            this.chartSP.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSP.Legends.Add(legend1);
            this.chartSP.Location = new System.Drawing.Point(0, 0);
            this.chartSP.Name = "chartSP";
            this.chartSP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chartSP.Series.Add(series1);
            this.chartSP.Size = new System.Drawing.Size(578, 198);
            this.chartSP.TabIndex = 18;
            this.chartSP.Text = "chart2";
            // 
            // cbbNam
            // 
            this.cbbNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbNam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(185, 22);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(146, 34);
            this.cbbNam.TabIndex = 16;
            this.cbbNam.Text = "Năm 2021";
            this.cbbNam.SelectedIndexChanged += new System.EventHandler(this.cbbNam_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvPhim);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 324);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(557, 299);
            this.panel9.TabIndex = 25;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhim.ColumnHeadersHeight = 44;
            this.dgvPhim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhim.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhim.RowHeadersVisible = false;
            this.dgvPhim.RowHeadersWidth = 51;
            this.dgvPhim.RowTemplate.Height = 26;
            this.dgvPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhim.Size = new System.Drawing.Size(557, 299);
            this.dgvPhim.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPhim";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phim";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenPhim";
            this.dataGridViewTextBoxColumn2.FillWeight = 140F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên phim";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoVe";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số vé";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DoanhThu";
            this.dataGridViewTextBoxColumn4.HeaderText = "DoanhThu";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 286);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(557, 38);
            this.panel8.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top 5  phim doanh thu cao nhất";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.chartPhim);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 88);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(557, 198);
            this.panel7.TabIndex = 23;
            // 
            // chartPhim
            // 
            chartArea2.BackColor = System.Drawing.Color.Snow;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea2.Name = "ChartArea1";
            this.chartPhim.ChartAreas.Add(chartArea2);
            this.chartPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartPhim.Legends.Add(legend2);
            this.chartPhim.Location = new System.Drawing.Point(0, 0);
            this.chartPhim.Name = "chartPhim";
            this.chartPhim.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "DoanhThu";
            this.chartPhim.Series.Add(series2);
            this.chartPhim.Size = new System.Drawing.Size(557, 198);
            this.chartPhim.TabIndex = 17;
            this.chartPhim.Text = "chart1";
            // 
            // cbbThongKe
            // 
            this.cbbThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbThongKe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThongKe.FormattingEnabled = true;
            this.cbbThongKe.Location = new System.Drawing.Point(18, 22);
            this.cbbThongKe.Name = "cbbThongKe";
            this.cbbThongKe.Size = new System.Drawing.Size(146, 34);
            this.cbbThongKe.TabIndex = 15;
            this.cbbThongKe.Text = "Theo tháng";
            this.cbbThongKe.SelectedIndexChanged += new System.EventHandler(this.cbbThongKe_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbbThang);
            this.panel6.Controls.Add(this.cbbThongKe);
            this.panel6.Controls.Add(this.cbbNam);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(557, 88);
            this.panel6.TabIndex = 22;
            // 
            // cbbThang
            // 
            this.cbbThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbThang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(359, 22);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(146, 34);
            this.cbbThang.TabIndex = 17;
            this.cbbThang.Text = "Tháng 10";
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.panel12);
            this.panel13.Controls.Add(this.panel11);
            this.panel13.Controls.Add(this.panel10);
            this.panel13.Controls.Add(this.panel3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(583, 31);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(608, 623);
            this.panel13.TabIndex = 38;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dgvSP);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(30, 324);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(578, 299);
            this.panel14.TabIndex = 37;
            // 
            // dgvSP
            // 
            this.dgvSP.AllowUserToAddRows = false;
            this.dgvSP.AllowUserToResizeColumns = false;
            this.dgvSP.AllowUserToResizeRows = false;
            this.dgvSP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSP.ColumnHeadersHeight = 44;
            this.dgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaNV,
            this.txtTenNV,
            this.txtNgaySinh,
            this.txtDiaChi});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSP.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSP.EnableHeadersVisualStyles = false;
            this.dgvSP.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSP.Location = new System.Drawing.Point(0, 0);
            this.dgvSP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSP.RowHeadersVisible = false;
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 26;
            this.dgvSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSP.Size = new System.Drawing.Size(578, 299);
            this.dgvSP.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMaNV.DataPropertyName = "MaSP";
            this.txtMaNV.HeaderText = "Mã sản phẩm";
            this.txtMaNV.MinimumWidth = 6;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTenNV.DataPropertyName = "TenSP";
            this.txtTenNV.FillWeight = 140F;
            this.txtTenNV.HeaderText = "Tên sản phẩm";
            this.txtTenNV.MinimumWidth = 6;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNgaySinh.DataPropertyName = "SoLuongBanDuoc";
            this.txtNgaySinh.HeaderText = "Số lượng";
            this.txtNgaySinh.MinimumWidth = 6;
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtDiaChi.DataPropertyName = "DoanhThu";
            this.txtDiaChi.HeaderText = "DoanhThu";
            this.txtDiaChi.MinimumWidth = 6;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(30, 286);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(578, 38);
            this.panel12.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top 5 sản phẩm doanh thu cao nhất";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.chartSP);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(30, 88);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(578, 198);
            this.panel11.TabIndex = 35;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(30, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(578, 88);
            this.panel10.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 623);
            this.panel3.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(26, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(557, 623);
            this.panel5.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1191, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 623);
            this.panel4.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(26, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 31);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(26, 654);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 31);
            this.panel1.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(79, 24);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.Text = "Theo tháng";
            // 
            // panelKH
            // 
            this.panelKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelKH.Location = new System.Drawing.Point(0, 0);
            this.panelKH.Name = "panelKH";
            this.panelKH.Size = new System.Drawing.Size(26, 685);
            this.panelKH.TabIndex = 28;
            // 
            // Trend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panelKH);
            this.Name = "Trend";
            this.Size = new System.Drawing.Size(1221, 685);
            this.Load += new System.EventHandler(this.Trend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSP)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPhim)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSP;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhim;
        private System.Windows.Forms.ComboBox cbbThongKe;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panelKH;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiaChi;
        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
