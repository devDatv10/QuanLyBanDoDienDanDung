﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoDienTuDanDung
{
    public partial class formLoginStaff : Form
    {
        private MyDatabase myDatabase;

        public static string maNhanVienBanHang { get; private set; }
        public formLoginStaff()
        {
            InitializeComponent();
            myDatabase = new MyDatabase();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            formChosseLogin welcomeForm = new formChosseLogin();
            welcomeForm.Show();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String userName, passWord;

            userName = txtTaiKhoan.Text;
            passWord = txtMatKhau.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Tài khoản và mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Focus();
                    return;
                }

                if (txtTaiKhoan.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Focus();
                    return;
                }

                myDatabase.ConnectToDatabase();

                String query = @"SELECT tk.*, cn.VaiTro
                                 FROM TaiKhoan tk
                                 INNER JOIN ConNguoi cn ON tk.UserName = cn.SoDienThoai
                                 WHERE tk.UserName = @userName AND tk.PassWord = @passWord";

                SqlDataAdapter sda = new SqlDataAdapter(query, myDatabase.GetConnection());

                sda.SelectCommand.Parameters.AddWithValue("@userName", txtTaiKhoan.Text);
                sda.SelectCommand.Parameters.AddWithValue("@passWord", txtMatKhau.Text);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    DataRow row = dtable.Rows[0];
                    int vaiTro = Convert.ToInt32(row["VaiTro"]);

                    maNhanVienBanHang = row["MaConNguoi"].ToString();

                    if (vaiTro == 2)
                    {
                        userName = txtTaiKhoan.Text;
                        passWord = txtMatKhau.Text;

                        formStaffPage staffPage = new formStaffPage();
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        staffPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền truy cập vào trang Nhân viên bán hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    txtTaiKhoan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể xác thực tài khoản: " + ex.Message);
            }
            finally
            {
                myDatabase.CloseConnection();
            }
        }

        private void ckbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
