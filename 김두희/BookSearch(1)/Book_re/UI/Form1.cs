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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        DataManager instances = new DataManager();


        private void bt_search_Click(object sender, EventArgs e)
        {
            instances.Load(txt_search.Text);
            new BookSearcher(DataManager.searchbooks, DataManager.LoginDone).ShowDialog();

            /*
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                string url_base = "https://www.dlibrary.go.kr/openapi/call.do";
                string key = "ucLBdEXFmXJ26tm8oH1LPA==";
                string title = txt_search.Text;


                string URL = $"{url_base}?dist_key={key}&func_id=3&sw={title}&sf=";
                //Console.WriteLine(URL);

                var json = wc.DownloadString(URL);

                JObject obj = JObject.Parse(json);



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


                new BookSearcher(DataManager.books, DataManager.LoginDone).ShowDialog();

            }
            */
        }
    }
}
