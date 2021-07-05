using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
            //MessageBox.Show(GetTitle);
            //WebRequest request = null;
            //request = WebRequest.Create("https://openapi.naver.com/v1/search/book_adv.xml");
            //request.Headers.Add("X-Naver-Client-Id", "l87hDaOsW43gnG4tEuHr");
            //request.Headers.Add("X-Naver-Client-Secret", "hbrV0_tmzo");

            string qeury_str = "https://openapi.naver.com/v1/search/book_adv.xml?key=l87hDaOsW43gnG4tEuHr&query={1}";
            string key = "l87hDaOsW43gnG4tEuHr";

            string query = txt_booksearch.Text;
            string real_query = string.Format(qeury_str, key, query);

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(real_query);
            XmlNode rn = xdoc.SelectSingleNode("rss");
            XmlNode cn = rn.SelectSingleNode("channel");
            XmlNodeList xnl = cn.SelectNodes("item");

            foreach (XmlNode xn in xnl)
            {
                string d_titl = xn.SelectSingleNode("d_titl").InnerText;
                string d_auth = xn.SelectSingleNode("d_auth").InnerText;
                string d_cont = xn.SelectSingleNode("d_cont").InnerText;
                string d_isbn = xn.SelectSingleNode("d_isbn").InnerText;
                string d_publ = xn.SelectSingleNode("d_publ").InnerText;
                string d_dafr = xn.SelectSingleNode("d_dafr").InnerText;
                string d_dato = xn.SelectSingleNode("d_dato").InnerText;
                string d_catg = xn.SelectSingleNode("d_catg").InnerText;

                string constr = @"Data Source";

                using (SqlConnection scon = new SqlConnection())
                {
                    scon.Open();

                    string context = @"INSERT Movie VALUES (@TITLE,@)";
                }
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
