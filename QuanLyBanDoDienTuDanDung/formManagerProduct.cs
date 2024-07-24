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
    public partial class formManagerProduct : Form
    {
        private MyDatabase myDatabase;
        public formManagerProduct()
        {
            InitializeComponent();
            myDatabase = new MyDatabase();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formManagerProduct_Load(object sender, EventArgs e)
        {
            LoadListProduct();
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

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image (*.JpG; *.png; *.Gif) | *.JpG; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptbHinhAnh.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            formManagerPage formManagerPage = new formManagerPage();
            formManagerPage.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHangHoa.Text) || string.IsNullOrWhiteSpace(txtMoTa.Text) || string.IsNullOrWhiteSpace(txtDonViTinh.Text) || string.IsNullOrWhiteSpace(txtGia.Text) || string.IsNullOrWhiteSpace(txtThongSoKyThuat.Text))
            {
                MessageBox.Show("Thông tin hàng hóa không được để trống. Vui lòng nhập đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                myDatabase.ConnectToDatabase();

                string tenHangHoa = txtTenHangHoa.Text;
                string moTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text;
                string thongSoKythuat = string.IsNullOrWhiteSpace(txtThongSoKyThuat.Text) ? null : txtThongSoKyThuat.Text;
                string donViTinh = string.IsNullOrWhiteSpace(txtDonViTinh.Text) ? null : txtDonViTinh.Text;
                int gia = int.Parse(txtGia.Text);
                byte[] hinhAnh = null;

                if (ptbHinhAnh.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ptbHinhAnh.Image.Save(ms, ptbHinhAnh.Image.RawFormat);
                        hinhAnh = ms.ToArray();
                    }
                }

                SqlCommand cmd = new SqlCommand("ThemHangHoa", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TenHangHoa", tenHangHoa);
                cmd.Parameters.AddWithValue("@MoTa", (object)moTa ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ThongSoKyThuat", (object)moTa ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DonViTinh", (object)donViTinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@HinhAnh", (object)hinhAnh ?? DBNull.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHangHoa.Clear();
                txtMoTa.Clear();
                txtThongSoKyThuat.Clear();
                txtDonViTinh.Clear();
                txtGia.Clear();
                ptbHinhAnh.Image = null;

                LoadListProduct();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHangHoa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hàng hóa để thực hiện 'Xóa'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHangHoa.Focus();
                return;
            }

            DialogResult res;
            res = MessageBox.Show("Bạn có chắc muốn xóa hàng hóa này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    myDatabase.ConnectToDatabase();

                    DataRow currentStaffInfo = myDatabase.GetProductInfo(txtMaHangHoa.Text);
                    if (currentStaffInfo == null)
                    {
                        MessageBox.Show("Không tìm thấy hàng hóa với mã bạn cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("XoaHangHoa ", myDatabase.GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaHangHoa", txtMaHangHoa.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa hàng hóa thành công khỏi CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadListProduct();

                    txtMaHangHoa.Clear();
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
            if (string.IsNullOrWhiteSpace(txtMaHangHoa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hàng hóa để thực hiện 'Sửa'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHangHoa.Focus();
                return;
            }

            try
            {
                myDatabase.ConnectToDatabase();

                DataRow currentProductInfo = myDatabase.GetProductInfo(txtMaHangHoa.Text);
                if (currentProductInfo == null)
                {
                    MessageBox.Show("Không tìm thấy hàng hóa với mã bạn cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenHangHoa = string.IsNullOrWhiteSpace(txtTenHangHoa.Text) ? currentProductInfo["TenHangHoa"].ToString() : txtTenHangHoa.Text;
                string moTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? currentProductInfo["MoTa"].ToString() : txtMoTa.Text;
                string thongSoKyThuat = string.IsNullOrWhiteSpace(txtThongSoKyThuat.Text) ? currentProductInfo["ThongSoKyThuat"].ToString() : txtThongSoKyThuat.Text;
                string donViTinh = string.IsNullOrWhiteSpace(txtDonViTinh.Text) ? currentProductInfo["DonViTinh"].ToString() : txtDonViTinh.Text;
                int gia = string.IsNullOrWhiteSpace(txtGia.Text) ? (int)currentProductInfo["Gia"] : int.Parse(txtGia.Text);

                ImageConverter converter = new ImageConverter();
                byte[] hinhAnh = ptbHinhAnh.Image != null ? (byte[])converter.ConvertTo(ptbHinhAnh.Image, typeof(byte[])) : (byte[])currentProductInfo["HinhAnh"];

                if (tenHangHoa == currentProductInfo["TenHangHoa"].ToString() &&
                    moTa == currentProductInfo["MoTa"].ToString() &&
                    thongSoKyThuat == currentProductInfo["ThongSoKyThuat"].ToString() &&
                    donViTinh == currentProductInfo["DonViTinh"].ToString() &&
                    gia == (int)currentProductInfo["Gia"] &&
                    hinhAnh.SequenceEqual((byte[])currentProductInfo["HinhAnh"]))
                {
                    MessageBox.Show("Không có thay đổi nào để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (gia <= 0)
                {
                    MessageBox.Show("Giá phải là một số dương hợp lệ và lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGia.Focus();
                    return;
                }

                SqlCommand cmd = new SqlCommand("SuaHangHoa", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHangHoa", txtMaHangHoa.Text);
                cmd.Parameters.AddWithValue("@TenHangHoa", tenHangHoa);
                cmd.Parameters.AddWithValue("@MoTa", moTa);
                cmd.Parameters.AddWithValue("@ThongSoKyThuat", thongSoKyThuat);
                cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thông tin hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadListProduct();

                txtMaHangHoa.Clear();
                txtTenHangHoa.Clear();
                txtMoTa.Clear();
                txtThongSoKyThuat.Clear();
                txtDonViTinh.Clear();
                txtGia.Clear();
                ptbHinhAnh.Image = null;
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



        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
