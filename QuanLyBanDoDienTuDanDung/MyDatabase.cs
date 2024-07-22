using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace QuanLyBanDoDienTuDanDung
{
    public class MyDatabase
    {
        private SqlConnection conn;

        public MyDatabase()
        {
            // Lấy chuỗi kết nối từ App.config
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        public void ConnectToDatabase()
        {
            try
            {
                conn.Open();
                // Thực hiện các thao tác với cơ sở dữ liệu
                Console.WriteLine("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
