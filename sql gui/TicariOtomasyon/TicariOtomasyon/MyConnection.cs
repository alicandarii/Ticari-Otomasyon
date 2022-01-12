using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TicariOtomasyon
{
    public class MyConnection
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;

        public SqlConnection Connect()
        {
            string sqlText = "Data Source=DESKTOP-AUDP32O;Initial Catalog=TicariOtomasyon;Integrated Security=True";
            conn = new SqlConnection(sqlText);
            conn.Open();
            return conn;
        }
        public void ConnectionWizard()
        {
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            else conn.Close();
        }

    }
}
