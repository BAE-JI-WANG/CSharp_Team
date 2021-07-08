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

            
        }
    }
}
