namespace QuanLyBanDoDienTuDanDung
{
    partial class formAdminPage
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
            btnDangXuat = new Button();
            btnChonQuanLyCoSo = new Button();
            btnChonQuanLyNhanVien = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(199, 28);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 0;
            label1.Text = "Trang Quản Trị Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(31, 88);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 1;
            label2.Text = "Chọn chức năng : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 148);
            label3.Name = "label3";
            label3.Size = new Size(185, 15);
            label3.TabIndex = 2;
            label3.Text = "Quản lý tài khoản \"Quản lý cơ sở\"";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 195);
            label4.Name = "label4";
            label4.Size = new Size(220, 15);
            label4.TabIndex = 3;
            label4.Text = "Quản lý tài khoản \"Nhân viên bán hàng\"";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = SystemColors.HighlightText;
            btnDangXuat.Location = new Point(481, 247);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(75, 23);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnChonQuanLyCoSo
            // 
            btnChonQuanLyCoSo.Location = new Point(399, 140);
            btnChonQuanLyCoSo.Name = "btnChonQuanLyCoSo";
            btnChonQuanLyCoSo.Size = new Size(75, 23);
            btnChonQuanLyCoSo.TabIndex = 5;
            btnChonQuanLyCoSo.Text = "Chọn";
            btnChonQuanLyCoSo.UseVisualStyleBackColor = true;
            // 
            // btnChonQuanLyNhanVien
            // 
            btnChonQuanLyNhanVien.Location = new Point(399, 187);
            btnChonQuanLyNhanVien.Name = "btnChonQuanLyNhanVien";
            btnChonQuanLyNhanVien.Size = new Size(75, 23);
            btnChonQuanLyNhanVien.TabIndex = 6;
            btnChonQuanLyNhanVien.Text = "Chọn";
            btnChonQuanLyNhanVien.UseVisualStyleBackColor = true;
            // 
            // formAdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(586, 290);
            Controls.Add(btnChonQuanLyNhanVien);
            Controls.Add(btnChonQuanLyCoSo);
            Controls.Add(btnDangXuat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formAdminPage";
            Text = "Trang Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDangXuat;
        private Button btnChonQuanLyCoSo;
        private Button btnChonQuanLyNhanVien;
    }
}