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

namespace JoinMember
{   
    public partial class Member_Login : Form
    {
        public bool test = false;
        TextBox[] txtList;
        const string IdPlaceholder = "아이디";
        const string PwPlaceholder = "비밀번호";
        public Member_Login()
        {
            InitializeComponent();
            //ID, Password TextBox Placeholder 설정
            txtList = new TextBox[] { txt_ID_login, txt_PW_login };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == txt_ID_login) txt.Text = IdPlaceholder;
                else if (txt == txt_PW_login) txt.Text = PwPlaceholder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
                if (txt == txt_PW_login) txt_PW_login.PasswordChar = '*';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                if (txt == txt_ID_login) txt.Text = IdPlaceholder;
                else if (txt == txt_PW_login) { txt.Text = PwPlaceholder; txt_PW_login.PasswordChar = default; }
            }
        }

        private void bt_join_login_Click(object sender, EventArgs e)
        {
            new Join_Main().ShowDialog();
        }

        private void bt_login_login_Click(object sender, EventArgs e)
        {
           loginexe(txt_ID_login.Text, txt_PW_login.Text);
        }

        private void loginexe(string login_id, string login_password)
        {                       
            // 로그인 할 id 를 검색
            string sql = "SELECT * FROM member WHERE id=\'" + login_id + "\' ";
            Join_DBM.ConnectDB();
            SqlCommand cmd = new SqlCommand(sql, Join_DBM.conn);
            SqlDataReader mdr = cmd.ExecuteReader();
            bool login = false; // 로그인 여부 확인
            while (mdr.Read())
            {
                // 검색된 아이디와 비밀번호가 일치한 경우 로그인된 것으로 봄
                if (login_id == (string)mdr["id"] && login_password == (string)mdr["pwd"])
                { //sql상에 컬럼이름 id, pwd
                    login = true;
                    MessageBox.Show("로그인 성공");
                    Application.OpenForms["Join_Main"].Close();
                }
            }
            mdr.Close();
            if (login)
            {

                this.LoginID = txt_ID_login.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("아이디/암호를 확인해 주세요.");
            }
        }
        public string LoginID
        {
            get;
            private set;
        }
        private void bt_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
