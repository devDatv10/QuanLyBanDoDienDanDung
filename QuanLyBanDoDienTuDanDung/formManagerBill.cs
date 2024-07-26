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
    public partial class formManagerBill : Form
    {
        private MyDatabase myDatabase;
        private string maNhanVienBanHang;
        public formManagerBill()
        {
            InitializeComponent();
            myDatabase = new MyDatabase();
            SetDefaultValues();
            AttachEventHandlers();
            maNhanVienBanHang = formLoginStaff.maNhanVienBanHang.ToString();
        }

        private void SetDefaultValues()
        {
            txtSoLuong.Text = "1";
        }

        private void AttachEventHandlers()
        {
            btnTang.Click += btnTang_Click;
            btnGiam.Click += btnGiam_Click;
            btnTimKiemHangHoa.Click += btnTimKiemHangHoa_Click;
        }

        private void formManagerBill_Load(object sender, EventArgs e)
        {
            LoadListProduct();
            LoadListBill();
        }

        private void LoadListBill()
        {
            try
            {
                myDatabase.ConnectToDatabase();

                SqlCommand cmd = new SqlCommand("LayDanhSachHoaDon", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgvDanhSachHoaDon.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myDatabase.CloseConnection();
            }
        }

        private void LoadListProduct()
        {
            try
            {
                myDatabase.ConnectToDatabase();

                SqlCommand cmd = new SqlCommand("LayDanhSachHangHoa", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgvThongTinHangHoa.DataSource = dt;
                dtgvThongTinHangHoa.RowTemplate.Height = 100;

                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dtgvThongTinHangHoa.Columns[6];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myDatabase.CloseConnection();
            }
        }

        private void btnTimKiemHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                myDatabase.ConnectToDatabase();

                SqlCommand cmd = new SqlCommand("TimKiemHangHoa", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHangHoa", txtMaHangHoa.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    int giaSanPham = Convert.ToInt32(row["Gia"]);
                    txtGia.Text = giaSanPham.ToString();

                    UpdateThanhTien();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hàng hóa với mã bạn cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myDatabase.CloseConnection();
            }
        }

        private void UpdateThanhTien()
        {
            int soLuong;
            int giaSanPham;

            if (int.TryParse(txtSoLuong.Text, out soLuong) && int.TryParse(txtGia.Text, out giaSanPham))
            {
                int thanhTien = soLuong * giaSanPham;
                txtThanhTien.Text = thanhTien.ToString();
            }
            else
            {
                txtThanhTien.Text = "0";
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            int currentValue;
            if (int.TryParse(txtSoLuong.Text, out currentValue))
            {
                currentValue++;
                txtSoLuong.Text = currentValue.ToString();
                UpdateThanhTien();
            }
            else
            {
                MessageBox.Show("Giá trị hiện tại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            int currentValue;
            if (int.TryParse(txtSoLuong.Text, out currentValue))
            {
                if (currentValue > 1)
                {
                    currentValue--;
                    txtSoLuong.Text = currentValue.ToString();
                    UpdateThanhTien();
                }
                else
                {
                    MessageBox.Show("Giá trị không thể nhỏ hơn 1.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            try
            {
                myDatabase.ConnectToDatabase();

                SqlCommand cmd = new SqlCommand("ThemHoaDon", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVienBanHang);
                cmd.Parameters.AddWithValue("@MaHangHoa", txtMaHangHoa.Text);
                cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                cmd.Parameters.AddWithValue("@ThanhTien", int.Parse(txtThanhTien.Text.Replace(",", "")));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Hóa đơn đã được tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMaHangHoa.Clear();
                SetDefaultValues();
                txtGia.Clear();
                txtThanhTien.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo hóa đơn: " + ex.Message);
            }
            finally
            {
                myDatabase.CloseConnection();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHoaDon.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn để thực hiện 'Xóa'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHoaDon.Focus();
                return;
            }

            DialogResult res;
            res = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    myDatabase.ConnectToDatabase();

                    DataRow currentStaffInfo = myDatabase.GetBillInfo(txtMaHoaDon.Text);
                    if (currentStaffInfo == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn với mã bạn cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("XoaHoaDon ", myDatabase.GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHoaDon.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa hóa đơn thành công khỏi CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadListBill();

                    txtMaHoaDon.Clear();
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

        private void btnXemChiTietHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                myDatabase.ConnectToDatabase();

                SqlCommand cmd = new SqlCommand("XemChiTietHoaDon", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHoaDon.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    string maHoaDon = row["MaHoaDon"].ToString();
                    string ngayLap = row["NgayLap"].ToString();
                    string tenNhanVien = row["TenNhanVien"].ToString();
                    string tenHangHoa = row["TenHangHoa"].ToString();
                    int soLuong = Convert.ToInt32(row["SoLuong"]);
                    int thanhTien = Convert.ToInt32(row["ThanhTien"]);

                    formBillDetail billDetailForm = new formBillDetail(maHoaDon, ngayLap, tenNhanVien, tenHangHoa, soLuong, thanhTien);
                    billDetailForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chi tiết hóa đơn với mã hóa đơn đã cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem chi tiết hóa đơn: " + ex.Message);
            }
            finally
            {
                myDatabase.CloseConnection();
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            formStaffPage staffPage = new formStaffPage();
            staffPage.Show();
            this.Hide();
        }


    }
}
