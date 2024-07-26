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
    public partial class formBillDetail : Form
    {
        private MyDatabase myDatabase;
        public formBillDetail(string maHoaDon, string ngayLap, string tenNhanVien, string tenHangHoa, int soLuong, int thanhTien)
        {
            InitializeComponent();
            myDatabase = new MyDatabase();

            txtMaHoaDon.Text = maHoaDon;
            txtNgayLap.Text = ngayLap;
            txtTenNhanVienBanHang.Text = tenNhanVien;
            txtTenHangHoa.Text = tenHangHoa;
            txtSoLuong.Text = soLuong.ToString();
            txtThanhTien.Text = thanhTien.ToString("N0");
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            formManagerBill formManagerBillPage = new formManagerBill();
            formManagerBillPage.Show();
            this.Hide();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                myDatabase.ConnectToDatabase();

                using (SqlCommand cmd = new SqlCommand("CapNhatTrangThaiHoaDon", myDatabase.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHoaDon.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Trạng thái hóa đơn đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myDatabase.CloseConnection();
            }
        }
    }
}
