using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
