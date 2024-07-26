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
        public formBillDetail(string maHoaDon, string ngayLap, string tenNhanVien, string tenHangHoa, int soLuong, int thanhTien)
        {
            InitializeComponent();

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

        }
    }
}
