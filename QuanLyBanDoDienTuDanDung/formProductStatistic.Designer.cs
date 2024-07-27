namespace QuanLyBanDoDienTuDanDung
{
    partial class formProductStatistic
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblNgayThongKeSanPham = new Label();
            chartSanPhamBanChay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            txtNhapNgayThongKe = new TextBox();
            btnThongKe = new Button();
            btnThoat = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartSanPhamBanChay).BeginInit();
            SuspendLayout();
            // 
            // lblNgayThongKeSanPham
            // 
            lblNgayThongKeSanPham.AutoSize = true;
            lblNgayThongKeSanPham.Font = new Font("Segoe UI", 12F);
            lblNgayThongKeSanPham.Location = new Point(366, 558);
            lblNgayThongKeSanPham.Name = "lblNgayThongKeSanPham";
            lblNgayThongKeSanPham.Size = new Size(165, 21);
            lblNgayThongKeSanPham.TabIndex = 15;
            lblNgayThongKeSanPham.Text = "Biểu đồ thống kê ngày";
            // 
            // chartSanPhamBanChay
            // 
            chartArea1.Name = "ChartArea1";
            chartSanPhamBanChay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartSanPhamBanChay.Legends.Add(legend1);
            chartSanPhamBanChay.Location = new Point(110, 194);
            chartSanPhamBanChay.Name = "chartSanPhamBanChay";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Sản phẩm";
            chartSanPhamBanChay.Series.Add(series1);
            chartSanPhamBanChay.Size = new Size(697, 349);
            chartSanPhamBanChay.TabIndex = 14;
            chartSanPhamBanChay.Text = "Sơ đồ thể hiện sản phẩm bán chạy nhất trong ngày";
            chartSanPhamBanChay.Click += chartSanPhamBanChay_Click;
            // 
            // txtNhapNgayThongKe
            // 
            txtNhapNgayThongKe.Location = new Point(237, 86);
            txtNhapNgayThongKe.Name = "txtNhapNgayThongKe";
            txtNhapNgayThongKe.Size = new Size(181, 23);
            txtNhapNgayThongKe.TabIndex = 13;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(456, 86);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(75, 23);
            btnThongKe.TabIndex = 12;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(812, 585);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 152);
            label3.Name = "label3";
            label3.Size = new Size(287, 15);
            label3.TabIndex = 10;
            label3.Text = "Biểu đồ thể hiện sản phẩm bán chạy nhất trong ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 94);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 9;
            label2.Text = "Nhập ngày thống kê :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(237, 29);
            label1.Name = "label1";
            label1.Size = new Size(414, 28);
            label1.TabIndex = 8;
            label1.Text = "Thống kê Sản phẩm bán chạy nhất trong ngày";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 124);
            label4.Name = "label4";
            label4.Size = new Size(155, 15);
            label4.TabIndex = 16;
            label4.Text = "* Định dạng : yyyy-MM-dd .";
            // 
            // formProductStatistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 620);
            Controls.Add(label4);
            Controls.Add(lblNgayThongKeSanPham);
            Controls.Add(chartSanPhamBanChay);
            Controls.Add(txtNhapNgayThongKe);
            Controls.Add(btnThongKe);
            Controls.Add(btnThoat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formProductStatistic";
            Text = "Trang thống kê sản phẩm";
            Load += formProductStatistic_Load;
            ((System.ComponentModel.ISupportInitialize)chartSanPhamBanChay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNgayThongKeSanPham;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSanPhamBanChay;
        private TextBox txtNhapNgayThongKe;
        private Button btnThongKe;
        private Button btnThoat;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}