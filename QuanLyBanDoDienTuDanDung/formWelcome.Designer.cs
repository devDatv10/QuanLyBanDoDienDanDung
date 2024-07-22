namespace QuanLyBanDoDienTuDanDung
{
    partial class formWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnBatDau = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
            label1.TabIndex = 0;
            label1.Text = "Binh Duong University";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 70);
            label2.Name = "label2";
            label2.Size = new Size(292, 37);
            label2.TabIndex = 1;
            label2.Text = "Bán Đồ Điện Dân Dụng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(335, 253);
            label3.Name = "label3";
            label3.Size = new Size(264, 21);
            label3.TabIndex = 2;
            label3.Text = "Sinh viên thực hiện : Cao Quốc Thịnh";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(335, 219);
            label4.Name = "label4";
            label4.Size = new Size(211, 21);
            label4.TabIndex = 3;
            label4.Text = "Giảng viên : Huỳnh Anh Tuấn";
            // 
            // btnBatDau
            // 
            btnBatDau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBatDau.Location = new Point(263, 145);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(85, 33);
            btnBatDau.TabIndex = 4;
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(23, 271);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // formWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 306);
            Controls.Add(btnThoat);
            Controls.Add(btnBatDau);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đồ Điện Dân Dụng";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnBatDau;
        private Button btnThoat;
    }
}
