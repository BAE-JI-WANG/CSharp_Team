using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_re
{
    class DBHelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void ConnectDB()
        {
            string connect = string.Format("Data Source={0}; Initial Catalog = {1}; User ID = team; Password = 1234; Timeout = 3",
                "192.168.0.84", "Csharp_Team");
            conn = new SqlConnection(connect);
            conn.Open();
        }

        public static void SearchBname(string bname)
        {
            ConnectDB();
            string sqlcommand = "Select * from dbo.book where bname like '%'+@p+'%'";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();
            Form1 form1 = new Form1();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p", bname);
            cmd.CommandText = sqlcommand;
            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds);

            conn.Close();
        }

    }
}
