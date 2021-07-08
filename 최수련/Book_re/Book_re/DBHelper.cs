using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void BookRnetCount(string bid)
        {
            ConnectDB();
            string sqlcommand = "update Csharp_Team.dbo.book set count=count+1 where isbn=@p";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p", bid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void RentBook(string pid, string bid, string bname)
        {
            ConnectDB();
            string sqlcommand = "Insert Into Csharp_Team.dbo.rentBook(pid, rentDate, returnDate, bid, bname) values (@p1, @p2, @p3, @p4, @p5)";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.AddWithValue("@p1", pid);
            cmd.Parameters.AddWithValue("@p2", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@p3", DateTime.Now.AddDays(14).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@p4", bid);
            cmd.Parameters.AddWithValue("@p5", bname);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            
            conn.Close();

            MessageBox.Show("대여가 완료되었습니다.");
        }

        public static void ReturnBook(string pid, string bid) //반납
        {
            ConnectDB();
            string sqlcommand = "update Csharp_Team.dbo.rentBook set returnCheck = '1' where pid=@p1 and bid=@p2 and returnCheck='0'";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.AddWithValue("@p1", pid);
            cmd.Parameters.AddWithValue("@p2", bid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void ExtendDate(string pid, string bid) //연장
        {
            try
            {
                ConnectDB();
                string sqlcommand = "update Csharp_Team.dbo.rentBook set exCheck = '1', returnDate=DATEADD(DAY,14,returnDate) where pid=@p1 and bid=@p2 and exCheck='0'";
                da = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p1", pid);
                cmd.Parameters.AddWithValue("@p2", bid);

                cmd.CommandText = sqlcommand;

                da.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                MessageBox.Show("연장 되었습니다.");
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("이미 연장된 책입니다.");
            }
            
        }

        public static void CheckRent(string bid)
        {
            ConnectDB();
            string sqlcommand = "select returnCheck from Csharp_Team.dbo.rentBook where bid=@p and returnCheck='0'";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p", bid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            conn.Close();
        }

        public static void UpdateOverDue(string pid, int overdueDay)
        {
            ConnectDB();
            string sqlcommand = "update Csharp_Team.dbo.member set overdue=(DATEADD(DD,@p1,Getdate())) where id = @p2;";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p1", overdueDay);
            cmd.Parameters.AddWithValue("@p2", pid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static DateTime CheckOverdue(string pid, string bid)
        {
            string returnedDate;
            ConnectDB();
            string sqlcommand = "select returnDate from Csharp_Team.dbo.rentBook where pid=@p1 and bid=@p2 and returnCheck='0'";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p1", pid);
            cmd.Parameters.AddWithValue("@p2", bid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            returnedDate = (string)cmd.ExecuteScalar();
            DateTime returntime = DateTime.ParseExact(returnedDate + "", "yyyyMMdd", null);

            conn.Close();
            return returntime;
        }

        public static void ReadRentalList(string pid)
        {
            ConnectDB();
            string sqlcommand = "select * from Csharp_Team.dbo.rentBook where pid=@p and returnCheck='0'";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p", pid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            da.Fill(ds);

            conn.Close();
        }
    }
}
