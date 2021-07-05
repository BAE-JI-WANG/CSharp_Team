using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JoinMember
{
    public class Join_DBM
    {
        public static SqlConnection conn;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void ConnectDB()
        {//MSSQL 접속해주는 함수
            try
            {
                string connect = string.Format("Data Source={0};" +
                "Initial Catalog = {1};" +
                "Persist Security Info = True;"+
                "User ID=team;Password=1234",
                "192.168.0.84,1433", "Csharp_Team");
                conn = new SqlConnection(connect);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void Query_Select()
        {
            ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM member";

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "member");

            conn.Close();
        }

        public static void Query_Insert(string name, string gender,
                    string id, string pwd, string email, string phone)
        {
            ConnectDB();

            try
            {
                string sqlcommand = "Insert Into member(name, gender, id, pwd, email, phone)" +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6)";
                
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", name);
                cmd.Parameters.AddWithValue("@p2", gender);
                cmd.Parameters.AddWithValue("@p3", id);
                cmd.Parameters.AddWithValue("@p4", pwd);
                cmd.Parameters.AddWithValue("@p5", email);
                cmd.Parameters.AddWithValue("@p6", phone);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();//실행
                conn.Close();
            }
            catch (Exception ex1)
            {
                throw new Exception(ex1.Message);
            }

        }

        public static void Query_Update(string name, string gender,
                    string id, string pwd, string email, string phone)
        {
            ConnectDB();
            try
            {
                string sqlcommand = "Update member set name=@p1, gender=@p2, " +
                    "id=@p3, pwd=@p4, email=@p5, phone=@p6 where id=@p7";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", name);
                cmd.Parameters.AddWithValue("@p2", gender);
                cmd.Parameters.AddWithValue("@p3", id);
                cmd.Parameters.AddWithValue("@p4", pwd);
                cmd.Parameters.AddWithValue("@p5", email);
                cmd.Parameters.AddWithValue("@p6", phone);
                cmd.Parameters.AddWithValue("@p7", id);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1);
            }
        }

        public static void Query_Delete()
        {
            ConnectDB();
            try
            {
                string sqlcommand = "DELETE TB_CUST";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1);
            }
        }
        public static void Query_Delete(string cust_id)
        {
            ConnectDB();
            try
            {
                string sqlcommand = "DELETE TB_CUST where CUST_ID=@p1";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", cust_id);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1);
            }
        }
    }
}