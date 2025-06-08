using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfDbase_22SA11A116
{
    public class Koneksi
    {
        static string conn;

        public static SqlConnection Conn
        {
            get
            {
                return new SqlConnection(conn);
            }
        }

        static Koneksi()
        {
            // Koneksi ke database SQL Server jika otentikasi yang digunakan bertipe Windows Authentication
            string connStr = "server=LAPTOP-3D73H9VQ\\SQLEXPRESS01; database=master; integrated security=true";

            // Koneksi ke database SQL Server jika otentikasi yang digunakan bertipe SQL Server Authentication
            // string connStr = "server=localhost; database=kepegawaian; user id=sa; password=xxxx";

            conn = connStr;
        }
    }
}
