using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALSinhVien
    {
        DB db = new DB();

        public DataTable LoadDanhSachSinhVien()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM SinhVien", db.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public int InsertSinhVien(string maSV, string hoTen, string lop, string khoa)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO SinhVien VALUES (@MaSV, @HoTen, @Lop, @Khoa)", db.Connection);
            cmd.Parameters.AddWithValue("@MaSV", maSV);
            cmd.Parameters.AddWithValue("@HoTen", hoTen);
            cmd.Parameters.AddWithValue("@Lop", lop);
            cmd.Parameters.AddWithValue("@Khoa", khoa);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return result;
        }

        public int UpdateSinhVien(string maSV, string hoTen, string lop, string khoa)
        {
            SqlCommand cmd = new SqlCommand("UPDATE SinhVien SET HoTenSV = @HoTen, Lop = @Lop, Khoa = @Khoa WHERE MaSV = @MaSV", db.Connection);
            cmd.Parameters.AddWithValue("@MaSV", maSV);
            cmd.Parameters.AddWithValue("@HoTen", hoTen);
            cmd.Parameters.AddWithValue("@Lop", lop);
            cmd.Parameters.AddWithValue("@Khoa", khoa);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return result;
        }

        public int DeleteSinhVien(string maSV)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM SinhVien WHERE MaSV = @MaSV", db.Connection);
            cmd.Parameters.AddWithValue("@MaSV", maSV);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return result;
        }
    }
}

