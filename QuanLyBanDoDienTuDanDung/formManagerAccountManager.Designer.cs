namespace QuanLyBanDoDienTuDanDung
{
    partial class formManagerAccountManager
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTen = new TextBox();
            txtSoDienThoai = new TextBox();
            txtMatKhau = new TextBox();
            txtCaLamViec = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            label2 = new Label();
            txtLuong = new TextBox();
            dtgvTaiKhoanQuanLy = new DataGridView();
            btnThoat = new Button();
            label7 = new Label();
            label8 = new Label();
            txtMaQuanLy = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvTaiKhoanQuanLy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(313, 19);
            label1.Name = "label1";
            label1.Size = new Size(293, 28);
            label1.TabIndex = 0;
            label1.Text = "Quản lý tài  khoản Quản lý cơ sở";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 143);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 178);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 215);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 251);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 5;
            label6.Text = "Ca làm việc :";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(229, 135);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(188, 23);
            txtTen.TabIndex = 6;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(229, 170);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(188, 23);
            txtSoDienThoai.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(229, 207);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(188, 23);
            txtMatKhau.TabIndex = 8;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtCaLamViec
            // 
            txtCaLamViec.Location = new Point(229, 243);
            txtCaLamViec.Name = "txtCaLamViec";
            txtCaLamViec.Size = new Size(188, 23);
            txtCaLamViec.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(313, 323);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(442, 323);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(575, 323);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 289);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 13;
            label2.Text = "Lương :";
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(229, 281);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(188, 23);
            txtLuong.TabIndex = 14;
            // 
            // dtgvTaiKhoanQuanLy
            // 
            dtgvTaiKhoanQuanLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTaiKhoanQuanLy.Location = new Point(77, 390);
            dtgvTaiKhoanQuanLy.Name = "dtgvTaiKhoanQuanLy";
            dtgvTaiKhoanQuanLy.Size = new Size(743, 249);
            dtgvTaiKhoanQuanLy.TabIndex = 15;
            dtgvTaiKhoanQuanLy.CellContentClick += dtgvTaiKhoanQuanLy_CellContentClick;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(790, 655);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(58, 62);
            label7.Name = "label7";
            label7.Size = new Size(298, 21);
            label7.TabIndex = 17;
            label7.Text = "Thêm, Xóa, Sửa tài khoản \"Quản lý Cơ sở\"";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(107, 108);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 18;
            label8.Text = "Mã quản lý :";
            // 
            // txtMaQuanLy
            // 
            txtMaQuanLy.Location = new Point(229, 100);
            txtMaQuanLy.Name = "txtMaQuanLy";
            txtMaQuanLy.Size = new Size(188, 23);
            txtMaQuanLy.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(442, 103);
            label9.Name = "label9";
            label9.Size = new Size(288, 15);
            label9.TabIndex = 20;
            label9.Text = "* Nhập mã quản lý để thực hiện xóa và sửa tài khoản.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Location = new Point(442, 246);
            label10.Name = "label10";
            label10.Size = new Size(261, 15);
            label10.TabIndex = 21;
            label10.Text = "* Ca làm việc :  1 = 'Ca 6h - 14h' ; 2 = '14h - 22h'.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(442, 173);
            label11.Name = "label11";
            label11.Size = new Size(199, 15);
            label11.TabIndex = 22;
            label11.Text = "* Số điện thoại phải có đủ 10 chữ số.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(442, 284);
            label12.Name = "label12";
            label12.Size = new Size(269, 15);
            label12.TabIndex = 23;
            label12.Text = "* Lương phải là một số dương,  không được <= 0.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(58, 352);
            label13.Name = "label13";
            label13.Size = new Size(265, 21);
            label13.TabIndex = 24;
            label13.Text = "Danh sách tài khoản \"Quản lý Cơ sở\"";
            // 
            // formManagerAccountManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 690);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtMaQuanLy);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnThoat);
            Controls.Add(dtgvTaiKhoanQuanLy);
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
            Name = "formManagerAccountManager";
            Text = "Quản lý tài khoản Quản lý cơ sở";
            Load += formManagerAccountManager_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgvTaiKhoanQuanLy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTen;
        private TextBox txtSoDienThoai;
        private TextBox txtMatKhau;
        private TextBox txtMaQuanLy;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtCaLamViec;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Label label2;
        private TextBox txtLuong;
        private DataGridView dtgvTaiKhoanQuanLy;
        private Button btnThoat;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}