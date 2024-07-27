namespace QuanLyBanDoDienTuDanDung
{
    partial class formStaffPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnChonHoaDon = new Button();
            btnChonThongKeSanPham = new Button();
            btnDangXuat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(171, 24);
            label1.Name = "label1";
            label1.Size = new Size(244, 28);
            label1.TabIndex = 0;
            label1.Text = "Trang Nhân Viên Bán Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(41, 70);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 1;
            label2.Text = "Chọn chức năng : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 143);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Quản lý hóa đơn";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 192);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 3;
            label4.Text = "Quản lý thống kê sản phẩm";
            // 
            // btnChonHoaDon
            // 
            btnChonHoaDon.Location = new Point(362, 135);
            btnChonHoaDon.Name = "btnChonHoaDon";
            btnChonHoaDon.Size = new Size(75, 23);
            btnChonHoaDon.TabIndex = 4;
            btnChonHoaDon.Text = "Chọn";
            btnChonHoaDon.UseVisualStyleBackColor = true;
            btnChonHoaDon.Click += btnChonHoaDon_Click;
            // 
            // btnChonThongKeSanPham
            // 
            btnChonThongKeSanPham.Location = new Point(362, 184);
            btnChonThongKeSanPham.Name = "btnChonThongKeSanPham";
            btnChonThongKeSanPham.Size = new Size(75, 23);
            btnChonThongKeSanPham.TabIndex = 5;
            btnChonThongKeSanPham.Text = "Chọn";
            btnChonThongKeSanPham.UseVisualStyleBackColor = true;
            btnChonThongKeSanPham.Click += btnChonThongKeSanPham_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(466, 243);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(75, 23);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // formStaffPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 287);
            Controls.Add(btnDangXuat);
            Controls.Add(btnChonThongKeSanPham);
            Controls.Add(btnChonHoaDon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formStaffPage";
            Text = "Trang Nhân viên bán hàng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnChonHoaDon;
        private Button btnChonThongKeSanPham;
        private Button btnDangXuat;
    }
}