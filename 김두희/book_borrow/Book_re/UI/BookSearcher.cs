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
        public BookSearcher(List<SearchBook> searchBooks, string userId)
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = searchBooks;
            lb_RentDate.Text = DateTime.Now.ToLongDateString();
            lb_ReturnPlanDate.Text = DateTime.Now.AddDays(14).ToLongDateString();
        }
        public BookSearcher()
        {
            InitializeComponent();
            lb_RentDate.Text = DateTime.Now.ToLongDateString();
            lb_ReturnPlanDate.Text = DateTime.Now.AddDays(14).ToLongDateString();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        DataManager instances = new DataManager();

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
            DataManager instances = new DataManager();
            instances.Load(txt_search.Text);
            // 수련언니 이 부분만 추가하면 되는거 였어요!!
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.searchbooks;
        }


        // 대여
        private void bt_borrow_Click(object sender, EventArgs e)
        {

            
            if (로그인이 안 되어있으면)
            {
                로그인
                if (대여 중인 책인지 확인)
                {
                    MessageBox.Show("이미 대여 중인 도서입니다");
                }
                else
                {

                }
            }
            
        }
    }
    
}
