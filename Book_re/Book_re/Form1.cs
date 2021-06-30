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
    public partial class Form1 : Form
    {
        public bool test = false;
        Sunny.UI.UITextBox[] txtList;
        const string searchHold = "검색어를 입력하세요.";

        public Form1()
        {
            InitializeComponent();
            DataLoad();

            //ID, Password TextBox Placeholder 설정
            txtList = new Sunny.UI.UITextBox[] { txt_search };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == txt_search) txt.Text = searchHold;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            Sunny.UI.UITextBox txt = (Sunny.UI.UITextBox)sender;
            if (txt.Text == searchHold)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            Sunny.UI.UITextBox txt = (Sunny.UI.UITextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                if (txt == txt_search) txt.Text = searchHold;
            }
        }

        private void DataLoad()
        {
            DataManager.Load();
            DGV_Subject.DataSource = null;
            DGV_Subject.DataSource = DataManager.rank;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DGV_Subject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uiTabControl1.SelectedIndex = DGV_Subject.CurrentRow.Index;
        }
    }
}
