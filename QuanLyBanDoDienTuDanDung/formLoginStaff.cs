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
    public partial class formLoginStaff : Form
    {
        public formLoginStaff()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            formChosseLogin welcomeForm = new formChosseLogin();
            welcomeForm.Show();
            this.Close();
        }
    }
}
