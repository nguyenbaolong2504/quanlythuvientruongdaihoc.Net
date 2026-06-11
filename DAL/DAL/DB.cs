using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DB
    {
        private string ConnectionString =  @"Data Source=DESKTOP-8UK0LDD\SQLEXPRESS;Initial Catalog=QuanLyThuVienEaut;Integrated Security=True";

        public SqlConnection Connection;
         public DB()
        {
            Connection = new SqlConnection(ConnectionString);
        }
    }
}
