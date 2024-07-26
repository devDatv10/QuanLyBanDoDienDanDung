namespace QuanLyBanDoDienTuDanDung
{
    partial class formRevenueStatistic
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnThoat = new Button();
            btnThongKe = new Button();
            txtNhapNgayThongKe = new TextBox();
            chartDoanhThuBayNgay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThuBayNgay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(340, 28);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 0;
            label1.Text = "Thống kê Doanh thu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 90);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập ngày thống kê :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 148);
            label3.Name = "label3";
            label3.Size = new Size(248, 15);
            label3.TabIndex = 2;
            label3.Text = "Biểu đồ thể hiện doanh thu 7 ngày trong tuần";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(814, 585);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(498, 82);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(75, 23);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // txtNhapNgayThongKe
            // 
            txtNhapNgayThongKe.Location = new Point(266, 82);
            txtNhapNgayThongKe.Name = "txtNhapNgayThongKe";
            txtNhapNgayThongKe.Size = new Size(181, 23);
            txtNhapNgayThongKe.TabIndex = 5;
            // 
            // chartDoanhThuBayNgay
            // 
            chartArea1.Name = "ChartArea1";
            chartDoanhThuBayNgay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDoanhThuBayNgay.Legends.Add(legend1);
            chartDoanhThuBayNgay.Location = new Point(139, 190);
            chartDoanhThuBayNgay.Name = "chartDoanhThuBayNgay";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDoanhThuBayNgay.Series.Add(series1);
            chartDoanhThuBayNgay.Size = new Size(643, 349);
            chartDoanhThuBayNgay.TabIndex = 6;
            chartDoanhThuBayNgay.Text = "Sơ đồ thể hiện doanh thu 7 ngày trong tuần";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(379, 555);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 7;
            label4.Text = "Biều đồ Doanh Thu";
            // 
            // formRevenueStatistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 620);
            Controls.Add(label4);
            Controls.Add(chartDoanhThuBayNgay);
            Controls.Add(txtNhapNgayThongKe);
            Controls.Add(btnThongKe);
            Controls.Add(btnThoat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formRevenueStatistic";
            Text = "Trang thống kê doanh thu";
            Load += formRevenueStatistic_Load;
            ((System.ComponentModel.ISupportInitialize)chartDoanhThuBayNgay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThoat;
        private Button btnThongKe;
        private TextBox txtNhapNgayThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThuBayNgay;
        private Label label4;
    }
}