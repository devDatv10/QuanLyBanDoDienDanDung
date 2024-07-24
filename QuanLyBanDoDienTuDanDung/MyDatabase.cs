using System;
using System.Configuration;
using System.Data;
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

        public bool IsPhoneNumberExists(string phoneNumber, string maQuanLy = null)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM ConNguoi WHERE SoDienThoai = @SoDienThoai";
                if (!string.IsNullOrEmpty(maQuanLy))
                {
                    query += " AND MaConNguoi != @MaConNguoi";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoDienThoai", phoneNumber);
                if (!string.IsNullOrEmpty(maQuanLy))
                {
                    cmd.Parameters.AddWithValue("@MaConNguoi", maQuanLy);
                }

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        public DataRow GetManagerInfo(string maQuanLy)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                cn.Ten, 
                cn.SoDienThoai, 
                tk.PassWord,
                qlcs.CaLamViec, 
                qlcs.Luong 
            FROM ConNguoi cn
            INNER JOIN TaiKhoan tk ON cn.MaConNguoi = tk.MaConNguoi
            INNER JOIN QuanLyCoSo qlcs ON cn.MaConNguoi = qlcs.MaQuanLy
            WHERE cn.MaConNguoi = @MaConNguoi", conn);
                cmd.Parameters.AddWithValue("@MaConNguoi", maQuanLy);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }

        public DataRow GetStaffInfo(string maNhanVien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                cn.Ten, 
                cn.SoDienThoai, 
                tk.PassWord,
                nvbh.CaLamViec, 
                nvbh.Luong 
            FROM ConNguoi cn
            INNER JOIN TaiKhoan tk ON cn.MaConNguoi = tk.MaConNguoi
            INNER JOIN NhanVienBanHang nvbh ON cn.MaConNguoi = nvbh.MaNhanVien
            WHERE cn.MaConNguoi = @MaConNguoi", conn);
                cmd.Parameters.AddWithValue("@MaConNguoi", maNhanVien);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }

        public DataRow GetProductInfo(string maHangHoa)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                MaHangHoa, 
                TenHangHoa, 
                MoTa, 
                ThongSoKyThuat,
                DonViTinh, 
                Gia, 
                HinhAnh
            FROM HangHoa
            WHERE MaHangHoa = @MaHangHoa", conn);
                cmd.Parameters.AddWithValue("@MaHangHoa", maHangHoa);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }

    }
}
