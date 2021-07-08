using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_re
{
    public partial class Mypage : Form
    {

        public Mypage()
        {
            InitializeComponent();
        }

        DataManager instances = new DataManager();

        private void bt_borrow_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            instances.Return("1234", dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            instances.Extend("1234", dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());
        }
    }
}
