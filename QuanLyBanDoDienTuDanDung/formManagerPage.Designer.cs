namespace QuanLyBanDoDienTuDanDung
{
    partial class formManagerPage
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
            btnChonQuanLySanPham = new Button();
            btnChonThongKeDoanhThu = new Button();
            btnDangXuat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(204, 21);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 0;
            label1.Text = "Trang Quản lý cơ sở";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(36, 77);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 1;
            label2.Text = "Chọn chức năng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 149);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 2;
            label3.Text = "Quản lý sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 193);
            label4.Name = "label4";
            label4.Size = new Size(156, 15);
            label4.TabIndex = 3;
            label4.Text = "Quản lý thống kê doanh thu";
            // 
            // btnChonQuanLySanPham
            // 
            btnChonQuanLySanPham.Location = new Point(396, 141);
            btnChonQuanLySanPham.Name = "btnChonQuanLySanPham";
            btnChonQuanLySanPham.Size = new Size(75, 23);
            btnChonQuanLySanPham.TabIndex = 4;
            btnChonQuanLySanPham.Text = "Chọn";
            btnChonQuanLySanPham.UseVisualStyleBackColor = true;
            // 
            // btnChonThongKeDoanhThu
            // 
            btnChonThongKeDoanhThu.Location = new Point(396, 185);
            btnChonThongKeDoanhThu.Name = "btnChonThongKeDoanhThu";
            btnChonThongKeDoanhThu.Size = new Size(75, 23);
            btnChonThongKeDoanhThu.TabIndex = 5;
            btnChonThongKeDoanhThu.Text = "Chọn";
            btnChonThongKeDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(481, 251);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(75, 23);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // formManagerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 295);
            Controls.Add(btnDangXuat);
            Controls.Add(btnChonThongKeDoanhThu);
            Controls.Add(btnChonQuanLySanPham);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formManagerPage";
            Text = "Trang  Quản lý cơ sở";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnChonQuanLySanPham;
        private Button btnChonThongKeDoanhThu;
        private Button btnDangXuat;
    }
}