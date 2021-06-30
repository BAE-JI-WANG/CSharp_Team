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

namespace CSharp_TeamProject
{
    public partial class MainForm1 : Form
    {

        public MainForm1()
        {
            InitializeComponent();
        }

        private void bt_bookSearch_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txt_bookSearch.Text))
            {
                MessageBox.Show("책제목을 입력해주세요");
            }
            else {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    string url_base = "https://www.dlibrary.go.kr/openapi/call.do";
                    string key = "ucLBdEXFmXJ26tm8oH1LPA==";
                    string title = txt_bookSearch.Text;


                    string URL = $"{url_base}?dist_key={key}&func_id=3&sw={title}&sf=";
                    //Console.WriteLine(URL);

                    var json = wc.DownloadString(URL);

                    JObject obj = JObject.Parse(json);



                    foreach (var item in obj["result"])
                    {
                        book tempbook = new book();

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
                        pyear = writer.Replace("</span>", "");
                        pyear = result.Replace("<span class=\"word\">", "");

                        tempbook.Title = result;
                        tempbook.Isbn = item["ndl_bib_no"].ToString();
                        try
                        {
                            tempbook.Author = writer;
                            tempbook.Publisher = publisher;
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }

                        tempbook.Year = pyear;
                        DataManager.books.Add(tempbook);
                    }


                    //1. DataManager 클래스 만들어서 거기서 MainForm1과 BookSearch 화면이 접근할 수 있는 List를 만든다.


                    //2. 그 리스트에 위 반복문처럼 (foreach문) title등 넣는다.

                    //3. 다음 화면 불러들일 때 이 리스트를 넘겨서, DataSource에 넣는다.

                    new BookSearch(DataManager.books).ShowDialog();
                }


            }


        }
    }
}
