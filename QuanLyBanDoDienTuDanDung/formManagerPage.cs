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
    public partial class formManagerPage : Form
    {
        private MyDatabase myDatabase;
        public formManagerPage()
        {
            InitializeComponent();
            myDatabase = new MyDatabase();
        }

        private void btnChonQuanLySanPham_Click(object sender, EventArgs e)
        {
            formManagerProduct formmanagerProductPage = new formManagerProduct();
            formmanagerProductPage.Show();
            this.Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn muốn thoát đăng xuất khỏi tài khoản Quản Lý Cơ Sở?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btnChonThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            formRevenueStatistic formRevenueStatisticPage = new formRevenueStatistic();
            formRevenueStatisticPage.Show();
            this.Hide();
        }
    }
}
