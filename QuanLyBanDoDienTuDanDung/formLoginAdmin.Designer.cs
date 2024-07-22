namespace QuanLyBanDoDienTuDanDung
{
    partial class formLoginAdmin
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
            btnQuayLai = new Button();
            btnDangNhap = new Button();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            ckbHienMatKhau = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(118, 24);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 77);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 121);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu :";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(23, 177);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(75, 23);
            btnQuayLai.TabIndex = 3;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(328, 177);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(75, 23);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(142, 69);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(147, 23);
            txtTaiKhoan.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(142, 113);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(147, 23);
            txtMatKhau.TabIndex = 6;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // ckbHienMatKhau
            // 
            ckbHienMatKhau.AutoSize = true;
            ckbHienMatKhau.Location = new Point(142, 142);
            ckbHienMatKhau.Name = "ckbHienMatKhau";
            ckbHienMatKhau.Size = new Size(104, 19);
            ckbHienMatKhau.TabIndex = 7;
            ckbHienMatKhau.Text = "Hiện mật khẩu";
            ckbHienMatKhau.UseVisualStyleBackColor = true;
            ckbHienMatKhau.CheckedChanged += ckbHienMatKhau_CheckedChanged;
            // 
            // formLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 212);
            Controls.Add(ckbHienMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(btnDangNhap);
            Controls.Add(btnQuayLai);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formLoginAdmin";
            Text = "Đăng nhập Admin";
            Load += formLoginAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnQuayLai;
        private Button btnDangNhap;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private CheckBox ckbHienMatKhau;
    }
}