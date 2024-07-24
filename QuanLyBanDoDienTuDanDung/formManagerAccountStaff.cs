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
    public partial class formManagerAccountStaff : Form
    {
        private MyDatabase myDatabase;
        public formManagerAccountStaff()
        {
            InitializeComponent();
            myDatabase = new MyDatabase();
        }

        private void formManagerAccountStaff_Load(object sender, EventArgs e)
        {
            LoadStaffAccounts();
        }

        private void LoadStaffAccounts()
        {
            try
            {
                myDatabase.ConnectToDatabase();
                SqlCommand cmd = new SqlCommand("LayDanhSachTaiKhoanNhanVien", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgvTaiKhoanNhanVien.DataSource = dt;
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
                    MessageBox.Show("Thông tin nhân viên bán hàng không được để trống. Vui lòng nhập đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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



                SqlCommand cmd = new SqlCommand("ThemNhanVienBanHang", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                cmd.Parameters.AddWithValue("@CaLamViec", int.Parse(txtCaLamViec.Text));
                cmd.Parameters.AddWithValue("@Luong", int.Parse(txtLuong.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm tài khoản nhân viên bán hàng vaò CSDL thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Clear();
                txtSoDienThoai.Clear();
                txtMatKhau.Clear();
                txtCaLamViec.Clear();
                txtLuong.Clear();

                LoadStaffAccounts();
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
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên bán hàng để thực hiện 'Xóa'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }

            DialogResult res;
            res = MessageBox.Show("Bạn có chắc muốn xóa tài khoản nhân viên bán hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    myDatabase.ConnectToDatabase();

                    DataRow currentStaffInfo = myDatabase.GetStaffInfo(txtMaNhanVien.Text);
                    if (currentStaffInfo == null)
                    {
                        MessageBox.Show("Không tìm thấy tài khoản nhân viên bán hàng với mã bạn cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("XoaNhanVienBanHang", myDatabase.GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa tài khoản nhân viên bán hàng thành công khỏi CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadStaffAccounts();

                    txtMaNhanVien.Clear();
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
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên bán hàng để thực hiện 'Sửa'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }

            try
            {
                myDatabase.ConnectToDatabase();

                DataRow currentStaffInfo = myDatabase.GetStaffInfo(txtMaNhanVien.Text);
                if (currentStaffInfo == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản nhân viên cơ sở với mã bạn cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string ten = string.IsNullOrWhiteSpace(txtTen.Text) ? currentStaffInfo["Ten"].ToString() : txtTen.Text;
                string soDienThoai = string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ? currentStaffInfo["SoDienThoai"].ToString() : txtSoDienThoai.Text;
                string matKhau = string.IsNullOrWhiteSpace(txtMatKhau.Text) ? currentStaffInfo["PassWord"].ToString() : txtMatKhau.Text;
                int caLamViec = string.IsNullOrWhiteSpace(txtCaLamViec.Text) ? (int)currentStaffInfo["CaLamViec"] : int.Parse(txtCaLamViec.Text);
                int luong = string.IsNullOrWhiteSpace(txtLuong.Text) ? (int)currentStaffInfo["Luong"] : int.Parse(txtLuong.Text);

                if (ten == currentStaffInfo["Ten"].ToString() &&
                    soDienThoai == currentStaffInfo["SoDienThoai"].ToString() &&
                    matKhau == currentStaffInfo["PassWord"].ToString() &&
                    caLamViec == (int)currentStaffInfo["CaLamViec"]&&
                    luong == (int)currentStaffInfo["Luong"])
                {
                    MessageBox.Show("Không có thay đổi nào để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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

                if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) && txtSoDienThoai.Text != currentStaffInfo["SoDienThoai"].ToString() && myDatabase.IsPhoneNumberExists(soDienThoai, txtMaNhanVien.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoDienThoai.Focus();
                    return;
                }

                SqlCommand cmd = new SqlCommand("SuaNhanVienBanHang", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                cmd.Parameters.AddWithValue("@Ten", ten);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@CaLamViec", caLamViec);
                cmd.Parameters.AddWithValue("@Luong", luong);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật tài khoản nhân viên cơ sở thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadStaffAccounts();

                txtMaNhanVien.Clear();
                txtTen.Clear();
                txtSoDienThoai.Clear();
                txtMaNhanVien.Clear();
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

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            formAdminPage formAdminPage = new formAdminPage();
            formAdminPage.Show();
            this.Hide();
        }

        private void dtgvTaiKhoanNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
