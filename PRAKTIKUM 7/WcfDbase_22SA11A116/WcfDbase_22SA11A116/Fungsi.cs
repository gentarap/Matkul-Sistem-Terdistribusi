using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WcfDbase_22SA11A116
{
    public class Fungsi
    {
        static SqlConnection conn;
        static SqlDataAdapter sdaUser;
        static DataSet dsUser;

        public static DataSet dataGrid(string query, string tabel)
        {
            conn = Koneksi.Conn;
            sdaUser = new SqlDataAdapter(query, conn);
            dsUser = new DataSet();

            try
            {
                conn.Open();
                sdaUser.Fill(dsUser, tabel);
                return dsUser;
            }
            catch (SqlException ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
