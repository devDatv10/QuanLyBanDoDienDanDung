namespace QuanLyBanDoDienTuDanDung
{
    partial class formManagerBill
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
            btnTimKiemHangHoa = new Button();
            txtThanhTien = new TextBox();
            label2 = new Label();
            btnGiam = new Button();
            btnTang = new Button();
            txtSoLuong = new TextBox();
            btnXemChiTietHoaDon = new Button();
            label13 = new Label();
            txtMaHoaDon = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnThoat = new Button();
            dtgvThongTinHangHoa = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            btnLap = new Button();
            txtGia = new TextBox();
            txtMaHangHoa = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvThongTinHangHoa).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiemHangHoa
            // 
            btnTimKiemHangHoa.Location = new Point(470, 128);
            btnTimKiemHangHoa.Name = "btnTimKiemHangHoa";
            btnTimKiemHangHoa.Size = new Size(75, 23);
            btnTimKiemHangHoa.TabIndex = 101;
            btnTimKiemHangHoa.Text = "Tìm kiếm";
            btnTimKiemHangHoa.UseVisualStyleBackColor = true;
            btnTimKiemHangHoa.Click += btnTimKiemHangHoa_Click;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(248, 252);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(188, 23);
            txtThanhTien.TabIndex = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 260);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 99;
            label2.Text = "Thành tiền :";
            // 
            // btnGiam
            // 
            btnGiam.Font = new Font("Segoe UI", 7F);
            btnGiam.Location = new Point(260, 163);
            btnGiam.Name = "btnGiam";
            btnGiam.Size = new Size(27, 23);
            btnGiam.TabIndex = 98;
            btnGiam.Text = "-";
            btnGiam.UseVisualStyleBackColor = true;
            // 
            // btnTang
            // 
            btnTang.Font = new Font("Segoe UI", 7F);
            btnTang.Location = new Point(392, 163);
            btnTang.Name = "btnTang";
            btnTang.Size = new Size(27, 23);
            btnTang.TabIndex = 97;
            btnTang.Text = "+";
            btnTang.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(311, 163);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(56, 23);
            txtSoLuong.TabIndex = 96;
            // 
            // btnXemChiTietHoaDon
            // 
            btnXemChiTietHoaDon.Location = new Point(723, 316);
            btnXemChiTietHoaDon.Name = "btnXemChiTietHoaDon";
            btnXemChiTietHoaDon.Size = new Size(75, 23);
            btnXemChiTietHoaDon.TabIndex = 95;
            btnXemChiTietHoaDon.Text = "Xem";
            btnXemChiTietHoaDon.UseVisualStyleBackColor = true;
            btnXemChiTietHoaDon.Click += btnXemChiTietHoaDon_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(77, 345);
            label13.Name = "label13";
            label13.Size = new Size(153, 21);
            label13.TabIndex = 94;
            label13.Text = "Danh sách Hàng hóa";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(248, 93);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(188, 23);
            txtMaHoaDon.TabIndex = 93;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(126, 101);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 92;
            label8.Text = "Mã hóa đơn  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(77, 55);
            label7.Name = "label7";
            label7.Size = new Size(191, 21);
            label7.TabIndex = 91;
            label7.Text = "Thêm, Xóa, Sửa \"Hóa đơn\"";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(809, 648);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 90;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dtgvThongTinHangHoa
            // 
            dtgvThongTinHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvThongTinHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvThongTinHangHoa.Location = new Point(96, 383);
            dtgvThongTinHangHoa.Name = "dtgvThongTinHangHoa";
            dtgvThongTinHangHoa.Size = new Size(743, 249);
            dtgvThongTinHangHoa.TabIndex = 89;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(594, 316);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 88;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(461, 316);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 87;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLap
            // 
            btnLap.Location = new Point(332, 316);
            btnLap.Name = "btnLap";
            btnLap.Size = new Size(75, 23);
            btnLap.TabIndex = 86;
            btnLap.Text = "Lập";
            btnLap.UseVisualStyleBackColor = true;
            btnLap.Click += btnLap_Click;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(248, 200);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(188, 23);
            txtGia.TabIndex = 85;
            // 
            // txtMaHangHoa
            // 
            txtMaHangHoa.Location = new Point(248, 128);
            txtMaHangHoa.Name = "txtMaHangHoa";
            txtMaHangHoa.Size = new Size(188, 23);
            txtMaHangHoa.TabIndex = 84;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 208);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 83;
            label5.Text = "Giá :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 171);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 82;
            label4.Text = "Số lượng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 136);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 81;
            label3.Text = "Mã hàng hóa :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(422, 13);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 80;
            label1.Text = "Quản lý Hóa Đơn";
            // 
            // formManagerBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 688);
            Controls.Add(btnTimKiemHangHoa);
            Controls.Add(txtThanhTien);
            Controls.Add(label2);
            Controls.Add(btnGiam);
            Controls.Add(btnTang);
            Controls.Add(txtSoLuong);
            Controls.Add(btnXemChiTietHoaDon);
            Controls.Add(label13);
            Controls.Add(txtMaHoaDon);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnThoat);
            Controls.Add(dtgvThongTinHangHoa);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLap);
            Controls.Add(txtGia);
            Controls.Add(txtMaHangHoa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "formManagerBill";
            Text = "Trang quản lý Hóa đơn";
            Load += formManagerBill_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvThongTinHangHoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiemHangHoa;
        private TextBox txtThanhTien;
        private Label label2;
        private Button btnGiam;
        private Button btnTang;
        private TextBox txtSoLuong;
        private Button btnXemChiTietHoaDon;
        private Label label13;
        private TextBox txtMaHoaDon;
        private Label label8;
        private Label label7;
        private Button btnThoat;
        private DataGridView dtgvThongTinHangHoa;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLap;
        private TextBox txtGia;
        private TextBox txtMaHangHoa;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}