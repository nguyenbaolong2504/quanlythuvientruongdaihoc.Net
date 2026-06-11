using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALSach
    {
        DB db = new DB();
        public DataTable LoadDanhSachSach()
        {
            SqlCommand sqlCommand= new SqlCommand("SELECT * FROM Sach", db.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public int InsertSach(string MaSach, string TenSach, string TacGia, int NamXB,int SoLuong)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Sach VALUES (@MaSach,@TenSach,@TacGia,@NamXB,@SoLuong)", db.Connection);
            cmd.Parameters.AddWithValue("@MaSach",MaSach);
            cmd.Parameters.AddWithValue("@TenSach",TenSach );
            cmd.Parameters.AddWithValue("@TacGia",TacGia);
            cmd.Parameters.AddWithValue("@NamXB", NamXB);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return result;
        }

        public int UpdateSach(string MaSach, string TenSach, string TacGia, int NamXB, int SoLuong)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Sach SET TenSach = @TenSach, TacGia = @TacGia ,SoLuong = @SoLuong WHERE MaSach = @MaSach", db.Connection);
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@TenSach", TenSach);
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            cmd.Parameters.AddWithValue("@NamXB", NamXB);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return result;
        }

        public int DeleteSach(string MaSach)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Sach WHERE MaSach = @MaSach", db.Connection);
            cmd.Parameters.AddWithValue("@MaSach", MaSach);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return result;
        }
        public int CapNhatSoLuongSach(string maSach, int thayDoi)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Sach SET SoLuong = SoLuong + @thayDoi WHERE MaSach = @MaSach", db.Connection);
            cmd.Parameters.AddWithValue("@thayDoi", thayDoi);
            cmd.Parameters.AddWithValue("@MaSach", maSach);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return result;
        }

        public bool KiemTraSachTonKho(string maSach)
        {
            SqlCommand cmd = new SqlCommand("SELECT SoLuong FROM Sach WHERE MaSach = @MaSach", db.Connection);
            cmd.Parameters.AddWithValue("@MaSach", maSach);

            db.Connection.Open();
            object result = cmd.ExecuteScalar();
            db.Connection.Close();

            if (result != null && int.TryParse(result.ToString(), out int soLuong))
            {
                return soLuong > 0;
            }
            return false;
        }
        public bool KiemTraSachTonTai(string maSach, string tenSach)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UK0LDD\SQLEXPRESS;Initial Catalog=QuanLyThuVienEaut;Integrated Security=True"))
            {
                string sql = "SELECT COUNT(*) FROM Sach WHERE MaSach = @MaSach AND TenSach = @TenSach";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                cmd.Parameters.AddWithValue("@TenSach", tenSach);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                return count > 0;
            }
        }

    }
}
