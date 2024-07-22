namespace QuanLyBanDoDienTuDanDung
{
    public partial class formWelcome : Form
    {
        public formWelcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            formChosseLogin loginForm = new formChosseLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
