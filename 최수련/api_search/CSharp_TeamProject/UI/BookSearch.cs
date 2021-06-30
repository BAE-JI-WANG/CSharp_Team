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
using Newtonsoft.Json.Linq;

namespace CSharp_TeamProject
{
    public partial class BookSearch : Form
    {
        public BookSearch(List<book> books)
        {
            InitializeComponent();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = books;
        }
        public BookSearch()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string toremove = "span";
            string bname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            label_isbn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label_bname.Text = bname.Replace(toremove,"");
            label_publisher.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            label_pyear.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            label_writer.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void bt_bookSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                string url_base = "https://www.dlibrary.go.kr/openapi/call.do";
                string key = "ucLBdEXFmXJ26tm8oH1LPA==";
                string title = txt_bookSearch.Text;
                //string rmword1 = "<span class="word">";
                string rmword2 = "</ span >";

                string URL = $"{url_base}?dist_key={key}&func_id=3&sw={title}&sf=";
                //Console.WriteLine(URL);

                var json = wc.DownloadString(URL);

                JObject obj = JObject.Parse(json);



                foreach (var item in obj["result"])
                {
                    book tempbook = new book();

                    tempbook.Title = item["title"].ToString();
                    tempbook.Isbn = item["ndl_bib_no"].ToString();
                    try
                    {
                        tempbook.Author = item["author"].ToString();

                        tempbook.Publisher = item["publisher"].ToString();

                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                    tempbook.Year = item["publisher_year"].ToString();
                    DataManager.books.Add(tempbook);
                }

            }
        }
    }
}
