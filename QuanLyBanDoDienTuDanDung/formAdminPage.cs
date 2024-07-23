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
    public partial class formAdminPage : Form
    {
        public formAdminPage()
        {
            InitializeComponent();
        }

        private void btnChonQuanLyCoSo_Click(object sender, EventArgs e)
        {
            formManagerAccountManager managerAccountManagerPage = new formManagerAccountManager();
            managerAccountManagerPage.Show();
            this.Hide();
        }

        private void btnChonQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            formManagerAccountStaff managerAccountStaffPage = new formManagerAccountStaff();
            managerAccountStaffPage.Show();
            this.Hide();
        }

        private void formAdminPage_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn muốn thoát đăng xuất khỏi tài khoản Admin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}
