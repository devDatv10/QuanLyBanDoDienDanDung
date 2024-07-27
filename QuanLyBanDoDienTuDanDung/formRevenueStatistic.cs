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
    public partial class formRevenueStatistic : Form
    {
        private MyDatabase myDatabase;
        public formRevenueStatistic()
        {
            InitializeComponent();
            myDatabase = new MyDatabase();
        }

        private void formRevenueStatistic_Load(object sender, EventArgs e)
        {
            LoadChartRevenueStatistic();
        }

        private void LoadChartRevenueStatistic()
        {
            try
            {
                myDatabase.ConnectToDatabase();

                SqlCommand cmd = new SqlCommand("ThongKeDoanhThu", myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chartDoanhThuBayNgay.Series.Clear();
                chartDoanhThuBayNgay.ChartAreas[0].AxisY.Minimum = 0;
                chartDoanhThuBayNgay.ChartAreas[0].AxisY.Maximum = 50000000;
                chartDoanhThuBayNgay.ChartAreas[0].AxisY.LabelStyle.Format = "{0:N0}";

                Series series = new Series
                {
                    Name = "Tổng doanh thu",
                    Color = System.Drawing.Color.Blue,
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                chartDoanhThuBayNgay.Series.Add(series);

                foreach (DataRow row in dt.Rows)
                {
                    DateTime ngay = Convert.ToDateTime(row["Ngay"]);
                    int tongDoanhThu = Convert.ToInt32(row["TongDoanhThu"]);

                    DataPoint point = new DataPoint
                    {
                        XValue = ngay.ToOADate(),
                        YValues = new double[] { tongDoanhThu }
                    };
                    point.Label = tongDoanhThu.ToString("N0");
                    point.LabelForeColor = System.Drawing.Color.Red;

                    series.Points.Add(point);
                }

                chartDoanhThuBayNgay.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                chartDoanhThuBayNgay.ChartAreas[0].AxisX.Interval = 1;
                chartDoanhThuBayNgay.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
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


        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            formManagerPage formManagerPage = new formManagerPage();
            formManagerPage.Show();
            this.Hide();
        }
    }
}
