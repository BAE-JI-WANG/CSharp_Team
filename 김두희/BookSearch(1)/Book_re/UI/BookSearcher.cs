using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_re
{
    public partial class BookSearcher : Form
    {
        public BookSearcher(List<Book> books, string userId)
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = books;
            lb_RentDate.Text = DateTime.Now.ToLongDateString();
            lb_ReturnPlanDate.Value = DateTime.Now.AddDays(14);
        }
        public BookSearcher()
        {
            InitializeComponent();
            lb_RentDate.Text = DateTime.Now.ToLongDateString();
            lb_ReturnPlanDate.Value = DateTime.Now.AddDays(14);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //상세정보
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string toremove = "span";
            string bname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            label_isbn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label_bname.Text = bname.Replace(toremove, "");
            label_publisher.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            label_pyear.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            label_writer.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        //검색
        private void bt_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_search.Text))
            {
                MessageBox.Show("책제목을 입력해주세요");
            }
            else
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    string url_base = "https://www.dlibrary.go.kr/openapi/call.do";
                    string key = "ucLBdEXFmXJ26tm8oH1LPA==";
                    string title = txt_search.Text;


                    string URL = $"{url_base}?dist_key={key}&func_id=3&sw={title}&sf=";
                    Console.WriteLine(URL);

                    var json = wc.DownloadString(URL);

                    JObject obj = JObject.Parse(json);

                    DataManager.books.Clear();

                    foreach (var item in obj["result"])
                    {
                        Book tempbook = new Book();

                        if (item["title"] != null && item["author"] != null && item["publisher"] != null)
                        {
                            string bname = item["title"].ToString();
                            string writer = item["author"].ToString();
                            string publisher = item["publisher"].ToString();
                            string pyear = item["publisher_year"].ToString();
                            string result = string.Empty;
                            result = bname.Replace("</span>", "");
                            result = result.Replace("<span class=\"word\">", "");
                            writer = writer.Replace("</span>", "");
                            writer = writer.Replace("<span class=\"word\">", "");
                            publisher = publisher.Replace("</span>", "");
                            publisher = publisher.Replace("<span class=\"word\">", "");
                            pyear = pyear.Replace("</span>", "");
                            pyear = pyear.Replace("<span class=\"word\">", "");
                            try
                            {
                                tempbook.Title = result;
                                tempbook.Isbn = item["ndl_bib_no"].ToString();
                                tempbook.Author = writer;
                                tempbook.Publisher = publisher;
                                tempbook.Year = pyear;
                            }
                            catch (Exception ex)
                            {
                                continue;
                            }

                            DataManager.books.Add(tempbook);
                        }


                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.books;

                }


            }
        }


        // 대여
        private void bt_borrow_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
