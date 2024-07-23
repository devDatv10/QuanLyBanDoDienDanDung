using Microsoft.Data.SqlClient;
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
    public partial class formManagerAccountManager : Form
    {
        private MyDatabase myDatabase;
        public formManagerAccountManager()
        {
            InitializeComponent();
            myDatabase = new MyDatabase();
        }

        private void formManagerAccountManager_Load_1(object sender, EventArgs e)
        {
            LoadManagerAccounts();
        }

        private void LoadManagerAccounts()
        {
            try
            {
                myDatabase.ConnectToDatabase();
                SqlCommand cmd = new SqlCommand("LayDanhSachTaiKhoanQuanLy", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgvTaiKhoanQuanLy.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                myDatabase.CloseConnection();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtCaLamViec.Text))
                {
                    MessageBox.Show("Thông tin không được để trống. Vui lòng nhập đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTen.Focus();
                    return;
                }

                if (txtSoDienThoai.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoDienThoai.Focus();
                    return;
                }

                if (!int.TryParse(txtLuong.Text, out int luong) || luong <= 0)
                {
                    MessageBox.Show("Lương phải là một số dương hợp lệ và lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLuong.Focus();
                    return;
                }

                myDatabase.ConnectToDatabase();

                if (myDatabase.IsPhoneNumberExists(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong CSDL. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoDienThoai.Focus();
                    return;
                }



                SqlCommand cmd = new SqlCommand("ThemQuanLyCoSo", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                cmd.Parameters.AddWithValue("@CaLamViec", int.Parse(txtCaLamViec.Text));
                cmd.Parameters.AddWithValue("@Luong", int.Parse(txtLuong.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm tài khoản quản lý cơ sở vaò CSDL thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Clear();
                txtSoDienThoai.Clear();
                txtMatKhau.Clear();
                txtCaLamViec.Clear();
                txtLuong.Clear();

                LoadManagerAccounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                myDatabase.CloseConnection();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaQuanLy.Text))
            {
                MessageBox.Show("Vui lòng nhập mã quản lý để thực hiện 'Xóa'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaQuanLy.Focus();
                return;
            }

            DialogResult res;
            res = MessageBox.Show("Bạn có chắc muốn xóa tài khoản quản lý cơ sở này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    myDatabase.ConnectToDatabase();

                    DataRow currentManagerInfo = myDatabase.GetManagerInfo(txtMaQuanLy.Text);
                    if (currentManagerInfo == null)
                    {
                        MessageBox.Show("Không tìm thấy tài khoản quản lý cơ sở với mã bạn cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("XoaQuanLyCoSo", myDatabase.GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaQuanLy", txtMaQuanLy.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa tài khoản quản lý cơ sở thành công khỏi CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadManagerAccounts();

                    txtMaQuanLy.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    myDatabase.CloseConnection();
                }
            }
            else
            {
                this.Show();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaQuanLy.Text))
            {
                MessageBox.Show("Vui lòng nhập mã quản lý để thực hiện 'Sửa'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaQuanLy.Focus();
                return;
            }

            try
            {
                myDatabase.ConnectToDatabase();

                DataRow currentManagerInfo = myDatabase.GetManagerInfo(txtMaQuanLy.Text);
                if (currentManagerInfo == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản quản lý cơ sở với mã bạn cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaQuanLy.Focus();
                    return;
                }

                string ten = string.IsNullOrWhiteSpace(txtTen.Text) ? currentManagerInfo["Ten"].ToString() : txtTen.Text;
                string soDienThoai = string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ? currentManagerInfo["SoDienThoai"].ToString() : txtSoDienThoai.Text;
                string matKhau = string.IsNullOrWhiteSpace(txtMatKhau.Text) ? currentManagerInfo["PassWord"].ToString() : txtMatKhau.Text;
                int caLamViec = string.IsNullOrWhiteSpace(txtCaLamViec.Text) ? (int)currentManagerInfo["CaLamViec"] : int.Parse(txtCaLamViec.Text);
                int luong = string.IsNullOrWhiteSpace(txtLuong.Text) ? (int)currentManagerInfo["Luong"] : int.Parse(txtLuong.Text);

                if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) && txtSoDienThoai.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoDienThoai.Focus();
                    return;
                }

                if (luong <= 0)
                {
                    MessageBox.Show("Lương phải là một số dương hợp lệ và lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLuong.Focus();
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) && txtSoDienThoai.Text != currentManagerInfo["SoDienThoai"].ToString() && myDatabase.IsPhoneNumberExists(soDienThoai, txtMaQuanLy.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoDienThoai.Focus();
                    return;
                }

                SqlCommand cmd = new SqlCommand("SuaQuanLyCoSo", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaQuanLy", txtMaQuanLy.Text);
                cmd.Parameters.AddWithValue("@Ten", ten);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@CaLamViec", caLamViec);
                cmd.Parameters.AddWithValue("@Luong", luong);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật tài khoản quản lý cơ sở thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadManagerAccounts();

                txtMaQuanLy.Clear();
                txtTen.Clear();
                txtSoDienThoai.Clear();
                txtMaQuanLy.Clear();
                txtSoDienThoai.Clear();
                txtLuong.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                myDatabase.CloseConnection();
            }
        }




        private void dtgvTaiKhoanQuanLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            formAdminPage formAdminPage = new formAdminPage();
            formAdminPage.Show();
            this.Hide();
        }
    }
}
