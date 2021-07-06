using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Book_re
{
    public partial class BookInfoForm : Form
    {
        string GetTitle;

        public BookInfoForm(string btitle)
        {
            InitializeComponent();
            this.GetTitle = btitle;
            txt_booksearch.Text = GetTitle;
        }

        private void bt_booksearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = txt_booksearch.Text; // 검색할 문자열
                //string url = "https://openapi.naver.com/v1/search/book_adv.xml?query=" + query;
                string url = $"https://openapi.naver.com/v1/search/book.xml?query={query}&display=1&start=1";
                Console.WriteLine(url);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("X-Naver-Client-Id", "l87hDaOsW43gnG4tEuHr"); // 클라이언트 아이디
                request.Headers.Add("X-Naver-Client-Secret", "hbrV0_tmzo");       // 클라이언트 시크릿
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string status = response.StatusCode.ToString();
                if (status == "OK")
                {
                    Stream stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    string text = reader.ReadToEnd();
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("Error 발생=" + status);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void MakeBook(XmlNode xn)
        {
            throw new NotImplementedException();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
