using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALTacGia
    {
        DB db = new DB();

        public DataTable LoadDanhSachTacGia()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TacGia", db.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public int InsertTacGia(string maTacGia, string tenTacGia, string gioiTinh, string queQuan)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TacGia VALUES (@MaTG, @TenTG, @GioiTinh, @QueQuan)", db.Connection);
            cmd.Parameters.AddWithValue("@MaTG", maTacGia);
            cmd.Parameters.AddWithValue("@TenTG", tenTacGia);
            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@QueQuan", queQuan);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();
            return result;
        }

        public int UpdateTacGia(string maTacGia, string tenTacGia, string gioiTinh, string queQuan)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TacGia SET TenTacGia = @TenTG, GioiTinh = @GioiTinh, QueQuan = @QueQuan WHERE MaTacGia = @MaTG", db.Connection);
            cmd.Parameters.AddWithValue("@MaTG", maTacGia);
            cmd.Parameters.AddWithValue("@TenTG", tenTacGia);
            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@QueQuan", queQuan);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();
            return result;
        }

        public int DeleteTacGia(string maTacGia)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TacGia WHERE MaTacGia = @MaTG", db.Connection);
            cmd.Parameters.AddWithValue("@MaTG", maTacGia);

            db.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            db.Connection.Close();
            return result;
        }
    }
}
