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
    public partial class formStaffPage : Form
    {
        public formStaffPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnChonHoaDon_Click(object sender, EventArgs e)
        {
            formManagerBill formManagerBillPage = new formManagerBill();
            formManagerBillPage.Show();
            this.Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn muốn thoát đăng xuất khỏi tài khoản Nhân viên bán hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                formChosseLogin formChosseLoginPage = new formChosseLogin();
                formChosseLoginPage.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void btnChonThongKeSanPham_Click(object sender, EventArgs e)
        {
            formProductStatistic formProductStatisticPage = new formProductStatistic();
            formProductStatisticPage.Show();
            this.Hide();
        }
    }
}
