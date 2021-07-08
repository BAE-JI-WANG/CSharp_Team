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
        {//접속해주는 함수
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
                Console.WriteLine("connect Fail");
            }
        }

        public static void Query_Select()
        {
            try
            {
                ConnectDB();//연결

                //SQL 명령어 선언
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select distinct rank() over(order by sum(count) desc) as 순위, rtrim(category) as category from book group by category";

                //DataAdapter와 DataSet으로 DB table 불러오기
                da = new SqlDataAdapter(cmd); //select 구문이 들어감

                ds = new DataSet();
                da.Fill(ds, "book");//SELECT * FROM TB_CUST의 결과가 da에 입력됨

                //dataGridView에 DB에서 가져온 데이터 입력하기
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "TB_CUST";
                conn.Close(); //연결 해제~중요함
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void count(string query)
        {
            try
            {
                ConnectDB();//연결

                //SQL 명령어 선언
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;

                //DataAdapter와 DataSet으로 DB table 불러오기
                da = new SqlDataAdapter(cmd); //select 구문이 들어감

                ds = new DataSet();
                da.Fill(ds);//SELECT * FROM TB_CUST의 결과가 da에 입력됨

                //dataGridView에 DB에서 가져온 데이터 입력하기
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "TB_CUST";
                conn.Close(); //연결 해제~중요함
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void BookRank(string category)
        {
            try
            {
                ConnectDB();//연결

                //SQL 명령어 선언
                SqlCommand cmd = new SqlCommand();
                SqlParameter parameter = cmd.Parameters.AddWithValue("@category", category);
                cmd.Connection = conn;
                cmd.CommandText = "select rank() over(order by count desc) as bookrank," +
                    "controlNumber, rtrim(bname) as title, rtrim(author) as writer, publisher, pyear, rtrim(category) as category from book where category = @category";

                //DataAdapter와 DataSet으로 DB table 불러오기
                da = new SqlDataAdapter(cmd); //select 구문이 들어감
                
                ds = new DataSet();
                da.Fill(ds, "book");//SELECT * FROM TB_CUST의 결과가 da에 입력됨

                //dataGridView에 DB에서 가져온 데이터 입력하기
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "TB_CUST";
                conn.Close(); //연결 해제~중요함
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //member관련
        public static void ConnectDB_member()
        {//MSSQL 접속해주는 함수
            try
            {
                string connect = string.Format("Data Source={0};" +
                "Initial Catalog = {1};" +
                "Persist Security Info = True;" +
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
        public static void Query_Select_member(string id="")
        {
            ConnectDB_member();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if(id=="")
                cmd.CommandText = "SELECT * FROM member";
            else
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = "SELECT * FROM member where id = @id";

            }


            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "member");

            conn.Close();
        }

        public static void Query_Insert_member(string name, string gender,
                    string id, string pwd, string email, string phone)
        {
            ConnectDB_member();
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

        public static void Query_Update_member(
                    string id, string pwd, string email, string phone)
        {
            ConnectDB_member();
            try
            {
                string sqlcommand = "Update member set " +
                    "pwd=@p1, email=@p2, phone=@p3 where id=@p4";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", pwd);
                cmd.Parameters.AddWithValue("@p2", email);
                cmd.Parameters.AddWithValue("@p3", phone);
                cmd.Parameters.AddWithValue("@p4", id);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1);
            }
        }

        public static void Query_Delete_member()
        {
            ConnectDB_member();
            try
            {
                string sqlcommand = "DELETE member";
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
        public static void Query_Delete_member(string id)
        {
            ConnectDB_member();
            try
            {
                string sqlcommand = "DELETE member where id=@p1";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", id);
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
