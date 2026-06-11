using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    static class DataAcess
    {
        private static string DuongDan = @"Data Source=DESKTOP-8UK0LDD\SQLEXPRESS;Initial Catalog=QuanLyThuVienEaut;Integrated Security=True";
        private static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(DuongDan);
        }
        public static DataTable GetTable(string sql)
        {
            SqlConnection con = TaoKetNoi();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
              ad.Fill(dt);
            con.Close();
            ad.Dispose();
            return dt;
        }
        public  static void themsuaxoa(string sql)
        {
            SqlConnection con = TaoKetNoi();
            con.Open();
            SqlCommand lenh = new SqlCommand(sql, con);
            lenh.ExecuteNonQuery();
            con.Close();
            lenh.Dispose();
        }
    }
}
