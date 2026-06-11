using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class  DALMuon
    {
        DB db= new DB();  

        public DataTable LoadDanhSachMuon()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Phieu",db.Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public int InsertMuon(string MaPhieu, string MaSV, string MaSach, string TenSV, string TenSach, DateTime NgayMuon, DateTime NgayTra, int SDT, string TrangThai)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Phieu VALUES (@MaPhieu, @MaSV, @MaSach, @TenSV, @TenSach, @NgayMuon, @NgayTra, @Sdt, @TrangThai)",     db.Connection);
            cmd.Parameters.AddWithValue("@MaPhieu", MaPhieu);
            cmd.Parameters.AddWithValue("@MaSV", MaSV);
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@TenSV", TenSV);
            cmd.Parameters.AddWithValue("@TenSach", TenSach);
            cmd.Parameters.AddWithValue("@NgayMuon", NgayMuon);
            cmd.Parameters.AddWithValue("@NgayTra", NgayTra);
            cmd.Parameters.AddWithValue("@Sdt", SDT);
            cmd.Parameters.AddWithValue("@TrangThai", TrangThai);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return result;
        }

        public int UpdateMuon(string MaPhieu, string MaSV, string MaSach, string TenSV, string TenSach, DateTime NgayMuon, DateTime NgayTra, int SDT, string TrangThai)
        {
            SqlCommand cmd = new SqlCommand(
                "UPDATE Phieu SET MaSV = @MaSV, MaSach = @MaSach, TenSV = @TenSV, TenSach = @TenSach, NgayMuon = @NgayMuon, NgayTra = @NgayTra, Sdt = @Sdt, TrangThai = @TrangThai WHERE MaPhieu = @MaPhieu",
                db.Connection
            );
            cmd.Parameters.AddWithValue("@MaPhieu", MaPhieu);
            cmd.Parameters.AddWithValue("@MaSV", MaSV);
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@TenSV", TenSV);
            cmd.Parameters.AddWithValue("@TenSach", TenSach);
            cmd.Parameters.AddWithValue("@NgayMuon", NgayMuon);
            cmd.Parameters.AddWithValue("@NgayTra", NgayTra);
            cmd.Parameters.AddWithValue("@Sdt", SDT);
            cmd.Parameters.AddWithValue("@TrangThai", TrangThai);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return result;
        }

        public int DeleteMuon(string maPhieu)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Phieu WHERE MaPhieu = @MaPhieu",  db.Connection);
            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return result;
        }
        public int UpdateTrangThai(string maPhieu, string trangThai)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Phieu SET TrangThai = @TrangThai WHERE MaPhieu = @MaPhieu", db.Connection);
            cmd.Parameters.AddWithValue("@TrangThai", trangThai);
            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();
            return result;
        }
    }
}

