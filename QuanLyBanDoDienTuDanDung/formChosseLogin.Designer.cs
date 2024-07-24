namespace QuanLyBanDoDienTuDanDung
{
    partial class formChosseLogin
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
            btnDangNhapAdmin = new Button();
            btnDangNhapQuanLyCoSo = new Button();
            btnDangNhapNhanVienBanHang = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnQuayLai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 28);
            label1.Name = "label1";
            label1.Size = new Size(311, 28);
            label1.TabIndex = 0;
            label1.Text = "Màn hình đăng nhập với các Actor";
            // 
            // btnDangNhapAdmin
            // 
            btnDangNhapAdmin.Location = new Point(83, 124);
            btnDangNhapAdmin.Name = "btnDangNhapAdmin";
            btnDangNhapAdmin.Size = new Size(75, 40);
            btnDangNhapAdmin.TabIndex = 1;
            btnDangNhapAdmin.Text = "Admin";
            btnDangNhapAdmin.UseVisualStyleBackColor = true;
            btnDangNhapAdmin.Click += btnAd_Click;
            // 
            // btnDangNhapQuanLyCoSo
            // 
            btnDangNhapQuanLyCoSo.Location = new Point(244, 124);
            btnDangNhapQuanLyCoSo.Name = "btnDangNhapQuanLyCoSo";
            btnDangNhapQuanLyCoSo.Size = new Size(86, 40);
            btnDangNhapQuanLyCoSo.TabIndex = 2;
            btnDangNhapQuanLyCoSo.Text = "Quản lý cơ sở";
            btnDangNhapQuanLyCoSo.UseVisualStyleBackColor = true;
            btnDangNhapQuanLyCoSo.Click += btnDangNhapQuanLyCoSo_Click;
            // 
            // btnDangNhapNhanVienBanHang
            // 
            btnDangNhapNhanVienBanHang.Location = new Point(413, 124);
            btnDangNhapNhanVienBanHang.Name = "btnDangNhapNhanVienBanHang";
            btnDangNhapNhanVienBanHang.Size = new Size(90, 40);
            btnDangNhapNhanVienBanHang.TabIndex = 3;
            btnDangNhapNhanVienBanHang.Text = "Nhân viên bán hàng";
            btnDangNhapNhanVienBanHang.UseVisualStyleBackColor = true;
            btnDangNhapNhanVienBanHang.Click += btnDangNhapNhanVienBanHang_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 200);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 4;
            label2.Text = "Đăng nhập với Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 200);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 5;
            label3.Text = "Đăng nhập với Quản lý";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 200);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 6;
            label4.Text = "Đăng nhập với nhân viên";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(12, 253);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(75, 23);
            btnQuayLai.TabIndex = 7;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // formChosseLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 304);
            Controls.Add(btnQuayLai);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDangNhapNhanVienBanHang);
            Controls.Add(btnDangNhapQuanLyCoSo);
            Controls.Add(btnDangNhapAdmin);
            Controls.Add(label1);
            Name = "formChosseLogin";
            Text = "Màn hình chọn Actor đăng nhập";
            Load += formChosseLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDangNhapAdmin;
        private Button btnDangNhapQuanLyCoSo;
        private Button btnDangNhapNhanVienBanHang;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnQuayLai;
    }
}