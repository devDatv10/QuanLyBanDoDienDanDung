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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyBanDoDienTuDanDung
{
    public partial class formProductStatistic : Form
    {
        private MyDatabase myDatabase;
        public formProductStatistic()
        {
            InitializeComponent();
            myDatabase = new MyDatabase();
        }

        private void formProductStatistic_Load(object sender, EventArgs e)
        {
            LoadChartProductStatistic(DateTime.Now);
            //lblNgayThongKeSanPham.Text = $"Biểu đồ thống kê ngày: {DateTime.Now.ToString("dd/MM/yyyy")}";
        }

        private void chartSanPhamBanChay_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadChartProductStatistic(DateTime ngayThongKe)
        {
            try
            {
                myDatabase.ConnectToDatabase();

                SqlCommand cmd = new SqlCommand("ThongKeSanPhamTheoNgay", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NgayThongKe", ngayThongKe);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chartSanPhamBanChay.Series.Clear();
                chartSanPhamBanChay.ChartAreas.Clear();
                chartSanPhamBanChay.ChartAreas.Add(new ChartArea());

                Series series = new Series
                {
                    Name = "Sản phẩm bán chạy",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Pie
                };

                chartSanPhamBanChay.Series.Add(series);

                if (dt.Rows.Count == 0)
                {
                    DataPoint point = new DataPoint
                    {
                        AxisLabel = "Không có dữ liệu",
                        YValues = new double[] { 100 }
                    };
                    point.Label = "Không có dữ liệu (0%)";
                    point.Color = Color.Gray;

                    series.Points.Add(point);
                }
                else
                {
                    int totalQuantity = dt.AsEnumerable().Sum(row => row.Field<int>("SoLuongBanDuoc"));

                    foreach (DataRow row in dt.Rows)
                    {
                        string productName = row["TenHangHoa"].ToString();
                        int quantitySold = Convert.ToInt32(row["SoLuongBanDuoc"]);
                        double percentage = (double)quantitySold / totalQuantity * 100;

                        DataPoint point = new DataPoint
                        {
                            AxisLabel = productName,
                            YValues = new double[] { percentage }
                        };
                        point.Label = $"{productName} ({percentage.ToString("0")}%)";

                        series.Points.Add(point);
                    }
                }

                chartSanPhamBanChay.Legends.Add(new Legend());

                lblNgayThongKeSanPham.Text = $"Ngày thống kê: {ngayThongKe.ToString("dd/MM/yyyy")}";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime selectedDate;
            if (DateTime.TryParse(txtNhapNgayThongKe.Text, out selectedDate))
            {
                LoadChartProductStatistic(selectedDate);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ngày theo định dạng hướng dẫn bên dưới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            formManagerPage formManagerPage = new formManagerPage();
            formManagerPage.Show();
            this.Hide();
        }

        
    }
}
