namespace QuanLyBanDoDienTuDanDung
{
    partial class formBillDetail
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
            label5 = new Label();
            label6 = new Label();
            txtMaHoaDon = new TextBox();
            txtTenNhanVienBanHang = new TextBox();
            txtTenHangHoa = new TextBox();
            txtSoLuong = new TextBox();
            txtThanhTien = new TextBox();
            btnQuayLai = new Button();
            btnInHoaDon = new Button();
            label7 = new Label();
            txtNgayLap = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 105);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(235, 21);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 1;
            label2.Text = "Chi tiết Hóa Đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 185);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên lập hóa đơn :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 224);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Tên hàng hóa :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 263);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Số lượng :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 327);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 5;
            label6.Text = "Thành tiền : ";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(266, 97);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(160, 23);
            txtMaHoaDon.TabIndex = 6;
            // 
            // txtTenNhanVienBanHang
            // 
            txtTenNhanVienBanHang.Location = new Point(266, 177);
            txtTenNhanVienBanHang.Name = "txtTenNhanVienBanHang";
            txtTenNhanVienBanHang.Size = new Size(160, 23);
            txtTenNhanVienBanHang.TabIndex = 7;
            // 
            // txtTenHangHoa
            // 
            txtTenHangHoa.Location = new Point(266, 216);
            txtTenHangHoa.Name = "txtTenHangHoa";
            txtTenHangHoa.Size = new Size(160, 23);
            txtTenHangHoa.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(361, 255);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(65, 23);
            txtSoLuong.TabIndex = 9;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(425, 319);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(149, 23);
            txtThanhTien.TabIndex = 10;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(35, 393);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(75, 23);
            btnQuayLai.TabIndex = 11;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(545, 380);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(75, 23);
            btnInHoaDon.TabIndex = 12;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(101, 145);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 13;
            label7.Text = "Ngày lập :";
            // 
            // txtNgayLap
            // 
            txtNgayLap.Location = new Point(266, 137);
            txtNgayLap.Name = "txtNgayLap";
            txtNgayLap.Size = new Size(160, 23);
            txtNgayLap.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(109, 58);
            label8.Name = "label8";
            label8.Size = new Size(317, 15);
            label8.TabIndex = 15;
            label8.Text = "* Thực hiện In hóa đơn để cập nhật trang thái của Hóa đơn";
            // 
            // formBillDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 440);
            Controls.Add(label8);
            Controls.Add(txtNgayLap);
            Controls.Add(label7);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnQuayLai);
            Controls.Add(txtThanhTien);
            Controls.Add(txtSoLuong);
            Controls.Add(txtTenHangHoa);
            Controls.Add(txtTenNhanVienBanHang);
            Controls.Add(txtMaHoaDon);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formBillDetail";
            Text = "Trang chi tiết hóa đơn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaHoaDon;
        private TextBox txtTenNhanVienBanHang;
        private TextBox txtTenHangHoa;
        private TextBox txtSoLuong;
        private TextBox txtThanhTien;
        private Button btnQuayLai;
        private Button btnInHoaDon;
        private Label label7;
        private TextBox txtNgayLap;
        private Label label8;
    }
}