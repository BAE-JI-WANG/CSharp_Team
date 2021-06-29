
namespace CSharp_TeamProject
{
    partial class MainForm1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_bookChart = new System.Windows.Forms.Button();
            this.bt_libraryREC = new System.Windows.Forms.Button();
            this.txt_bookSearch = new System.Windows.Forms.TextBox();
            this.bt_bookSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.bt_bookChart);
            this.panel1.Controls.Add(this.bt_libraryREC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 81);
            this.panel1.TabIndex = 0;
            // 
            // bt_bookChart
            // 
            this.bt_bookChart.BackColor = System.Drawing.Color.Transparent;
            this.bt_bookChart.Location = new System.Drawing.Point(179, 0);
            this.bt_bookChart.Name = "bt_bookChart";
            this.bt_bookChart.Size = new System.Drawing.Size(148, 81);
            this.bt_bookChart.TabIndex = 1;
            this.bt_bookChart.Text = "책 유형별 차트";
            this.bt_bookChart.UseVisualStyleBackColor = false;
            // 
            // bt_libraryREC
            // 
            this.bt_libraryREC.BackColor = System.Drawing.Color.Transparent;
            this.bt_libraryREC.Location = new System.Drawing.Point(32, 0);
            this.bt_libraryREC.Name = "bt_libraryREC";
            this.bt_libraryREC.Size = new System.Drawing.Size(148, 81);
            this.bt_libraryREC.TabIndex = 0;
            this.bt_libraryREC.Text = "도사관 추천";
            this.bt_libraryREC.UseVisualStyleBackColor = false;
            // 
            // txt_bookSearch
            // 
            this.txt_bookSearch.Location = new System.Drawing.Point(168, 129);
            this.txt_bookSearch.Name = "txt_bookSearch";
            this.txt_bookSearch.Size = new System.Drawing.Size(492, 21);
            this.txt_bookSearch.TabIndex = 1;
            // 
            // bt_bookSearch
            // 
            this.bt_bookSearch.Location = new System.Drawing.Point(675, 128);
            this.bt_bookSearch.Name = "bt_bookSearch";
            this.bt_bookSearch.Size = new System.Drawing.Size(99, 23);
            this.bt_bookSearch.TabIndex = 2;
            this.bt_bookSearch.Text = "검색";
            this.bt_bookSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(129, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "제목";
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_bookSearch);
            this.Controls.Add(this.txt_bookSearch);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_bookChart;
        private System.Windows.Forms.Button bt_libraryREC;
        private System.Windows.Forms.TextBox txt_bookSearch;
        private System.Windows.Forms.Button bt_bookSearch;
        private System.Windows.Forms.Label label1;
    }
}

