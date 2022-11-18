namespace BTLon.Views.User
{
    partial class Rank
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartRank = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblDoanhSoNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartRank2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblChiTieuKH = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.cbbThongKe = new System.Windows.Forms.ComboBox();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartRank)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRank2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartRank
            // 
            chartArea1.BackColor = System.Drawing.Color.Snow;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea1.Name = "ChartArea1";
            this.chartRank.ChartAreas.Add(chartArea1);
            this.chartRank.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRank.Legends.Add(legend1);
            this.chartRank.Location = new System.Drawing.Point(0, 0);
            this.chartRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartRank.Name = "chartRank";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "ChiTieu";
            this.chartRank.Series.Add(series1);
            this.chartRank.Size = new System.Drawing.Size(282, 171);
            this.chartRank.TabIndex = 18;
            this.chartRank.Text = "chart3";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.lblDoanhSoNV);
            this.panel16.Controls.Add(this.lblTenNV);
            this.panel16.Controls.Add(this.label3);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel16.Location = new System.Drawing.Point(305, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(273, 171);
            this.panel16.TabIndex = 3;
            // 
            // lblDoanhSoNV
            // 
            this.lblDoanhSoNV.AutoSize = true;
            this.lblDoanhSoNV.CausesValidation = false;
            this.lblDoanhSoNV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhSoNV.Location = new System.Drawing.Point(53, 112);
            this.lblDoanhSoNV.Name = "lblDoanhSoNV";
            this.lblDoanhSoNV.Size = new System.Drawing.Size(137, 34);
            this.lblDoanhSoNV.TabIndex = 29;
            this.lblDoanhSoNV.Text = "Doanh số:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(46, 73);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(153, 26);
            this.lblTenNV.TabIndex = 28;
            this.lblTenNV.Text = "Trần Anh Tuấn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(53, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hạng nhất:";
            // 
            // chartRank2
            // 
            chartArea2.BackColor = System.Drawing.Color.Snow;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea2.Name = "ChartArea1";
            this.chartRank2.ChartAreas.Add(chartArea2);
            this.chartRank2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartRank2.Legends.Add(legend2);
            this.chartRank2.Location = new System.Drawing.Point(0, 0);
            this.chartRank2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartRank2.Name = "chartRank2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "DoanhSo";
            this.chartRank2.Series.Add(series2);
            this.chartRank2.Size = new System.Drawing.Size(269, 171);
            this.chartRank2.TabIndex = 18;
            this.chartRank2.Text = "chart1";
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(587, 25);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(28, 638);
            this.panel11.TabIndex = 14;
            // 
            // lblChiTieuKH
            // 
            this.lblChiTieuKH.AutoSize = true;
            this.lblChiTieuKH.CausesValidation = false;
            this.lblChiTieuKH.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTieuKH.Location = new System.Drawing.Point(67, 97);
            this.lblChiTieuKH.Name = "lblChiTieuKH";
            this.lblChiTieuKH.Size = new System.Drawing.Size(137, 34);
            this.lblChiTieuKH.TabIndex = 26;
            this.lblChiTieuKH.Text = "Doanh số:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(60, 59);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(153, 26);
            this.lblTenKH.TabIndex = 25;
            this.lblTenKH.Text = "Trần Anh Tuấn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbThang);
            this.panel2.Controls.Add(this.cbbThongKe);
            this.panel2.Controls.Add(this.cbbNam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(24, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 69);
            this.panel2.TabIndex = 1;
            // 
            // cbbThang
            // 
            this.cbbThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbThang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(367, 17);
            this.cbbThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(132, 34);
            this.cbbThang.TabIndex = 17;
            this.cbbThang.Text = "Tháng 10";
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged);
            // 
            // cbbThongKe
            // 
            this.cbbThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbThongKe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThongKe.FormattingEnabled = true;
            this.cbbThongKe.Location = new System.Drawing.Point(41, 17);
            this.cbbThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbThongKe.Name = "cbbThongKe";
            this.cbbThongKe.Size = new System.Drawing.Size(137, 34);
            this.cbbThongKe.TabIndex = 16;
            this.cbbThongKe.Text = "Theo tháng";
            this.cbbThongKe.SelectedIndexChanged += new System.EventHandler(this.cbbThongKe_SelectedIndexChanged);
            // 
            // cbbNam
            // 
            this.cbbNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbNam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(210, 17);
            this.cbbNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(134, 34);
            this.cbbNam.TabIndex = 15;
            this.cbbNam.Text = "Năm 2021";
            this.cbbNam.SelectedIndexChanged += new System.EventHandler(this.cbbNam_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(67, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 34);
            this.label8.TabIndex = 21;
            this.label8.Text = "Hạng nhất:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvKH);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(587, 638);
            this.panel4.TabIndex = 13;
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.AllowUserToResizeColumns = false;
            this.dgvKH.AllowUserToResizeRows = false;
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.ColumnHeadersHeight = 44;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKH.EnableHeadersVisualStyles = false;
            this.dgvKH.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKH.Location = new System.Drawing.Point(24, 279);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKH.RowHeadersVisible = false;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 26;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(563, 359);
            this.dgvKH.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khách hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKH";
            this.dataGridViewTextBoxColumn2.FillWeight = 140F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ChiTieu";
            this.dataGridViewTextBoxColumn4.HeaderText = "Chi  tiêu";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(24, 240);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(563, 39);
            this.panel10.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top 5 khách hàng chi tiêu nhiều nhất";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(24, 69);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(563, 171);
            this.panel6.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblChiTieuKH);
            this.panel8.Controls.Add(this.lblTenKH);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(307, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(256, 171);
            this.panel8.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(282, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(25, 171);
            this.panel7.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.chartRank);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(282, 171);
            this.panel9.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 638);
            this.panel5.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 663);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 22);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 25);
            this.panel1.TabIndex = 11;
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToResizeColumns = false;
            this.dgvNV.AllowUserToResizeRows = false;
            this.dgvNV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNV.ColumnHeadersHeight = 44;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvNV.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNV.EnableHeadersVisualStyles = false;
            this.dgvNV.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvNV.Location = new System.Drawing.Point(0, 0);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNV.RowHeadersVisible = false;
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 26;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(578, 359);
            this.dgvNV.TabIndex = 10;
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMaNV.DataPropertyName = "MaNV";
            this.txtMaNV.HeaderText = "Mã nhân viên";
            this.txtMaNV.MinimumWidth = 6;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTenNV.DataPropertyName = "TenNV";
            this.txtTenNV.FillWeight = 140F;
            this.txtTenNV.HeaderText = "Tên nhân viên";
            this.txtTenNV.MinimumWidth = 6;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNgaySinh.DataPropertyName = "SDT";
            this.txtNgaySinh.HeaderText = "Số điện thoại";
            this.txtNgaySinh.MinimumWidth = 6;
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtDiaChi.DataPropertyName = "DoanhSo";
            this.txtDiaChi.HeaderText = "Doanh số";
            this.txtDiaChi.MinimumWidth = 6;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(1193, 25);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(28, 638);
            this.panel12.TabIndex = 15;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(615, 25);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(578, 69);
            this.panel13.TabIndex = 16;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(615, 94);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(578, 171);
            this.panel14.TabIndex = 17;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(269, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(36, 171);
            this.panel17.TabIndex = 16;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.chartRank2);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(269, 171);
            this.panel15.TabIndex = 15;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.label2);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(615, 265);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(578, 39);
            this.panel18.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top 5 nhân viên đóng góp nhiều nhất";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.dgvNV);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(615, 304);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(578, 359);
            this.panel19.TabIndex = 20;
            // 
            // Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Rank";
            this.Size = new System.Drawing.Size(1221, 685);
            this.Load += new System.EventHandler(this.Rank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRank)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRank2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRank;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblDoanhSoNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRank2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblChiTieuKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.ComboBox cbbThongKe;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiaChi;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel19;
    }
}
