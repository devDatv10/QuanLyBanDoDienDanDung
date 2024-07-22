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
    public partial class formChosseLogin : Form
    {
        public formChosseLogin()
        {
            InitializeComponent();
        }

        private void formChosseLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            formLoginAdmin loginForm = new formLoginAdmin();
            loginForm.Show();
            this.Hide();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            formWelcome welcomeForm = new formWelcome();
            welcomeForm.Show();
            this.Close();
        }

        private void btnDangNhapQuanLyCoSo_Click(object sender, EventArgs e)
        {
            formLoginManager loginForm = new formLoginManager();
            loginForm.Show();
            this.Hide();
        }

        private void btnDangNhapNhanVienBanHang_Click(object sender, EventArgs e)
        {
            formLoginStaff loginForm = new formLoginStaff();
            loginForm.Show();
            this.Hide();
        }
    }
}
