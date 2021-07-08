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
                string connect = string.Format("Data Source=({0}); " +
                            "Initial Catalog = {1};" +
                            "Integrated Security = {2};" +
                            "Timeout = 3"
                            , "local", "Csharp_Team", "SSPI");
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
    }
}
