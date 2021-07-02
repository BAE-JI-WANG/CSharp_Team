
namespace Book_re
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGV_Subject = new Sunny.UI.UIDataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_signup = new Sunny.UI.UIButton();
            this.bt_signin = new Sunny.UI.UIButton();
            this.bt_exit = new Sunny.UI.UIImageButton();
            this.bt_search = new Sunny.UI.UIButton();
            this.txt_search = new Sunny.UI.UITextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_chart = new Sunny.UI.UIImageButton();
            this.bt_recommend = new Sunny.UI.UIImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Subject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_recommend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.uiTabControl1);
            this.panel1.Controls.Add(this.DGV_Subject);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bt_signup);
            this.panel1.Controls.Add(this.bt_signin);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Controls.Add(this.bt_search);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 690);
            this.panel1.TabIndex = 0;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage4);
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(493, 220);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(603, 434);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.Maroon;
            this.uiTabControl1.TabIndex = 10;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.Firebrick;
            this.uiTabControl1.TabSelectedForeColor = System.Drawing.Color.White;
            this.uiTabControl1.TabSelectedHighColor = System.Drawing.Color.Brown;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(603, 394);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(0, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(603, 394);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(603, 394);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(603, 394);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGV_Subject
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DGV_Subject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Subject.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Subject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Subject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Subject.EnableHeadersVisualStyles = false;
            this.DGV_Subject.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DGV_Subject.GridColor = System.Drawing.Color.Maroon;
            this.DGV_Subject.Location = new System.Drawing.Point(196, 220);
            this.DGV_Subject.Name = "DGV_Subject";
            this.DGV_Subject.ReadOnly = true;
            this.DGV_Subject.RectColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Subject.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGV_Subject.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Subject.RowTemplate.Height = 29;
            this.DGV_Subject.SelectedIndex = -1;
            this.DGV_Subject.ShowGridLine = true;
            this.DGV_Subject.Size = new System.Drawing.Size(240, 434);
            this.DGV_Subject.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(860, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1005, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // bt_signup
            // 
            this.bt_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_signup.FillColor = System.Drawing.Color.Transparent;
            this.bt_signup.FillDisableColor = System.Drawing.Color.Transparent;
            this.bt_signup.FillHoverColor = System.Drawing.Color.Transparent;
            this.bt_signup.FillPressColor = System.Drawing.Color.Transparent;
            this.bt_signup.FillSelectedColor = System.Drawing.Color.Transparent;
            this.bt_signup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_signup.ForeColor = System.Drawing.Color.Black;
            this.bt_signup.Location = new System.Drawing.Point(1025, 11);
            this.bt_signup.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.RectColor = System.Drawing.Color.Transparent;
            this.bt_signup.RectDisableColor = System.Drawing.Color.Transparent;
            this.bt_signup.RectHoverColor = System.Drawing.Color.Transparent;
            this.bt_signup.RectPressColor = System.Drawing.Color.Transparent;
            this.bt_signup.RectSelectedColor = System.Drawing.Color.Transparent;
            this.bt_signup.Size = new System.Drawing.Size(100, 35);
            this.bt_signup.Style = Sunny.UI.UIStyle.Custom;
            this.bt_signup.TabIndex = 5;
            this.bt_signup.Text = "Sign up";
            // 
            // bt_signin
            // 
            this.bt_signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_signin.FillColor = System.Drawing.Color.Transparent;
            this.bt_signin.FillDisableColor = System.Drawing.Color.Transparent;
            this.bt_signin.FillHoverColor = System.Drawing.Color.Transparent;
            this.bt_signin.FillPressColor = System.Drawing.Color.Transparent;
            this.bt_signin.FillSelectedColor = System.Drawing.Color.Transparent;
            this.bt_signin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_signin.ForeColor = System.Drawing.Color.Black;
            this.bt_signin.Location = new System.Drawing.Point(899, 11);
            this.bt_signin.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_signin.Name = "bt_signin";
            this.bt_signin.RectColor = System.Drawing.Color.Transparent;
            this.bt_signin.RectDisableColor = System.Drawing.Color.Transparent;
            this.bt_signin.RectHoverColor = System.Drawing.Color.Transparent;
            this.bt_signin.RectPressColor = System.Drawing.Color.Transparent;
            this.bt_signin.RectSelectedColor = System.Drawing.Color.Transparent;
            this.bt_signin.Size = new System.Drawing.Size(100, 35);
            this.bt_signin.Style = Sunny.UI.UIStyle.Custom;
            this.bt_signin.TabIndex = 4;
            this.bt_signin.Text = "Sign in";
            // 
            // bt_exit
            // 
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bt_exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.Image")));
            this.bt_exit.Location = new System.Drawing.Point(1146, 11);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(60, 60);
            this.bt_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_exit.TabIndex = 3;
            this.bt_exit.TabStop = false;
            this.bt_exit.Text = null;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_search
            // 
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_search.FillColor = System.Drawing.Color.Maroon;
            this.bt_search.FillDisableColor = System.Drawing.Color.Maroon;
            this.bt_search.FillHoverColor = System.Drawing.Color.Maroon;
            this.bt_search.FillPressColor = System.Drawing.Color.Maroon;
            this.bt_search.FillSelectedColor = System.Drawing.Color.Maroon;
            this.bt_search.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bt_search.Location = new System.Drawing.Point(1050, 98);
            this.bt_search.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_search.Name = "bt_search";
            this.bt_search.Radius = 15;
            this.bt_search.RectColor = System.Drawing.Color.Maroon;
            this.bt_search.Size = new System.Drawing.Size(100, 51);
            this.bt_search.Style = Sunny.UI.UIStyle.Custom;
            this.bt_search.TabIndex = 2;
            this.bt_search.Text = "Search";
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.FillColor = System.Drawing.Color.White;
            this.txt_search.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_search.ForeColor = System.Drawing.Color.Silver;
            this.txt_search.Location = new System.Drawing.Point(196, 98);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Maximum = 2147483647D;
            this.txt_search.Minimum = -2147483648D;
            this.txt_search.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_search.Name = "txt_search";
            this.txt_search.Padding = new System.Windows.Forms.Padding(5);
            this.txt_search.Radius = 20;
            this.txt_search.RectColor = System.Drawing.Color.Silver;
            this.txt_search.Size = new System.Drawing.Size(832, 51);
            this.txt_search.Style = Sunny.UI.UIStyle.Custom;
            this.txt_search.TabIndex = 1;
            this.txt_search.Text = "제목을 입력하세요.";
            this.txt_search.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(121, 690);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bt_chart);
            this.panel3.Controls.Add(this.bt_recommend);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(10, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 672);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aladin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "       장르별 \r\n 보유 책 현황";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aladin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = " 도서관 \r\n   추천";
            // 
            // bt_chart
            // 
            this.bt_chart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_chart.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bt_chart.Image = ((System.Drawing.Image)(resources.GetObject("bt_chart.Image")));
            this.bt_chart.Location = new System.Drawing.Point(20, 306);
            this.bt_chart.Name = "bt_chart";
            this.bt_chart.Size = new System.Drawing.Size(60, 60);
            this.bt_chart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_chart.TabIndex = 2;
            this.bt_chart.TabStop = false;
            this.bt_chart.Text = null;
            // 
            // bt_recommend
            // 
            this.bt_recommend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_recommend.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bt_recommend.Image = ((System.Drawing.Image)(resources.GetObject("bt_recommend.Image")));
            this.bt_recommend.Location = new System.Drawing.Point(19, 149);
            this.bt_recommend.Name = "bt_recommend";
            this.bt_recommend.Size = new System.Drawing.Size(60, 60);
            this.bt_recommend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_recommend.TabIndex = 1;
            this.bt_recommend.TabStop = false;
            this.bt_recommend.Text = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1230, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.uiTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Subject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_recommend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIButton bt_search;
        private Sunny.UI.UITextBox txt_search;
        private Sunny.UI.UIImageButton bt_chart;
        private Sunny.UI.UIImageButton bt_recommend;
        private Sunny.UI.UIImageButton bt_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton bt_signin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UIButton bt_signup;
        private Sunny.UI.UIDataGridView DGV_Subject;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

