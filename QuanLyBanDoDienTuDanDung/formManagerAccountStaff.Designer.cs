namespace QuanLyBanDoDienTuDanDung
{
    partial class formManagerAccountStaff
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
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtMaNhanVien = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnThoat = new Button();
            dtgvTaiKhoanNhanVien = new DataGridView();
            txtLuong = new TextBox();
            label2 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtCaLamViec = new TextBox();
            txtMatKhau = new TextBox();
            txtSoDienThoai = new TextBox();
            txtTen = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvTaiKhoanNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(44, 347);
            label13.Name = "label13";
            label13.Size = new Size(306, 21);
            label13.TabIndex = 48;
            label13.Text = "Danh sách tài khoản \"Nhân viên bán hàng\"";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(428, 279);
            label12.Name = "label12";
            label12.Size = new Size(269, 15);
            label12.TabIndex = 47;
            label12.Text = "* Lương phải là một số dương,  không được <= 0.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(428, 168);
            label11.Name = "label11";
            label11.Size = new Size(199, 15);
            label11.TabIndex = 46;
            label11.Text = "* Số điện thoại phải có đủ 10 chữ số.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Location = new Point(428, 241);
            label10.Name = "label10";
            label10.Size = new Size(261, 15);
            label10.TabIndex = 45;
            label10.Text = "* Ca làm việc :  1 = 'Ca 6h - 14h' ; 2 = '14h - 22h'.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(428, 98);
            label9.Name = "label9";
            label9.Size = new Size(301, 15);
            label9.TabIndex = 44;
            label9.Text = "* Nhập mã nhân viên để thực hiện xóa và sửa tài khoản.";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(215, 95);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(188, 23);
            txtMaNhanVien.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 103);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 42;
            label8.Text = "Mã nhân viên  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(44, 57);
            label7.Name = "label7";
            label7.Size = new Size(339, 21);
            label7.TabIndex = 41;
            label7.Text = "Thêm, Xóa, Sửa tài khoản \"Nhân viên bán hàng\"";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(776, 650);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 40;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // dtgvTaiKhoanNhanVien
            // 
            dtgvTaiKhoanNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTaiKhoanNhanVien.Location = new Point(63, 385);
            dtgvTaiKhoanNhanVien.Name = "dtgvTaiKhoanNhanVien";
            dtgvTaiKhoanNhanVien.Size = new Size(743, 249);
            dtgvTaiKhoanNhanVien.TabIndex = 39;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(215, 276);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(188, 23);
            txtLuong.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 284);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 37;
            label2.Text = "Lương :";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(561, 318);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 36;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(428, 318);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 35;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(299, 318);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 34;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtCaLamViec
            // 
            txtCaLamViec.Location = new Point(215, 238);
            txtCaLamViec.Name = "txtCaLamViec";
            txtCaLamViec.Size = new Size(188, 23);
            txtCaLamViec.TabIndex = 33;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(215, 202);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(188, 23);
            txtMatKhau.TabIndex = 32;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(215, 165);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(188, 23);
            txtSoDienThoai.TabIndex = 31;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(215, 130);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(188, 23);
            txtTen.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 246);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 29;
            label6.Text = "Ca làm việc :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 210);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 28;
            label5.Text = "Mật khẩu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 173);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 27;
            label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 138);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 26;
            label3.Text = "Tên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(299, 14);
            label1.Name = "label1";
            label1.Size = new Size(350, 28);
            label1.TabIndex = 25;
            label1.Text = "Quản lý tài  khoản Nhân viên bán hàng";
            // 
            // formManagerAccountStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 687);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnThoat);
            Controls.Add(dtgvTaiKhoanNhanVien);
            Controls.Add(txtLuong);
            Controls.Add(label2);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtCaLamViec);
            Controls.Add(txtMatKhau);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTen);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "formManagerAccountStaff";
            Text = "formManagerAccountStaff";
            Load += formManagerAccountStaff_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvTaiKhoanNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtMaNhanVien;
        private Label label8;
        private Label label7;
        private Button btnThoat;
        private DataGridView dtgvTaiKhoanNhanVien;
        private TextBox txtLuong;
        private Label label2;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtCaLamViec;
        private TextBox txtMatKhau;
        private TextBox txtSoDienThoai;
        private TextBox txtTen;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}