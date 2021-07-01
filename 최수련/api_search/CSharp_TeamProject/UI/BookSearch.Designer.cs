﻿
namespace CSharp_TeamProject
{
    partial class BookSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bt_bookSearch = new System.Windows.Forms.Button();
            this.txt_bookSearch = new System.Windows.Forms.TextBox();
            this.PickReturnPlanDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.PickRentDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gr_bookDeatail = new System.Windows.Forms.GroupBox();
            this.label_pyear = new System.Windows.Forms.Label();
            this.label_publisher = new System.Windows.Forms.Label();
            this.label_writer = new System.Windows.Forms.Label();
            this.label_bname = new System.Windows.Forms.Label();
            this.label_isbn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.gr_bookDeatail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(884, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "제목";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "저자";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "출판사";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "발행연도";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(CSharp_TeamProject.book);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(5, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "제목";
            // 
            // bt_bookSearch
            // 
            this.bt_bookSearch.Location = new System.Drawing.Point(511, 50);
            this.bt_bookSearch.Name = "bt_bookSearch";
            this.bt_bookSearch.Size = new System.Drawing.Size(99, 27);
            this.bt_bookSearch.TabIndex = 5;
            this.bt_bookSearch.Text = "검색";
            this.bt_bookSearch.UseVisualStyleBackColor = true;
            this.bt_bookSearch.Click += new System.EventHandler(this.bt_bookSearch_Click);
            // 
            // txt_bookSearch
            // 
            this.txt_bookSearch.Location = new System.Drawing.Point(44, 52);
            this.txt_bookSearch.Name = "txt_bookSearch";
            this.txt_bookSearch.Size = new System.Drawing.Size(446, 21);
            this.txt_bookSearch.TabIndex = 4;
            // 
            // PickReturnPlanDate
            // 
            this.PickReturnPlanDate.Location = new System.Drawing.Point(336, 127);
            this.PickReturnPlanDate.MinDate = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            this.PickReturnPlanDate.Name = "PickReturnPlanDate";
            this.PickReturnPlanDate.Size = new System.Drawing.Size(154, 21);
            this.PickReturnPlanDate.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(261, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "반납예정일";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PickRentDate
            // 
            this.PickRentDate.Location = new System.Drawing.Point(85, 127);
            this.PickRentDate.MinDate = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            this.PickRentDate.Name = "PickRentDate";
            this.PickRentDate.Size = new System.Drawing.Size(154, 21);
            this.PickRentDate.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "대여일";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(511, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 40;
            this.button1.Text = "대여";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gr_bookDeatail
            // 
            this.gr_bookDeatail.Controls.Add(this.label_pyear);
            this.gr_bookDeatail.Controls.Add(this.label_publisher);
            this.gr_bookDeatail.Controls.Add(this.label_writer);
            this.gr_bookDeatail.Controls.Add(this.label_bname);
            this.gr_bookDeatail.Controls.Add(this.label_isbn);
            this.gr_bookDeatail.Controls.Add(this.label7);
            this.gr_bookDeatail.Controls.Add(this.label8);
            this.gr_bookDeatail.Controls.Add(this.label3);
            this.gr_bookDeatail.Controls.Add(this.label4);
            this.gr_bookDeatail.Controls.Add(this.label6);
            this.gr_bookDeatail.Location = new System.Drawing.Point(632, 12);
            this.gr_bookDeatail.Name = "gr_bookDeatail";
            this.gr_bookDeatail.Size = new System.Drawing.Size(264, 171);
            this.gr_bookDeatail.TabIndex = 41;
            this.gr_bookDeatail.TabStop = false;
            this.gr_bookDeatail.Text = "상세정보";
            // 
            // label_pyear
            // 
            this.label_pyear.AutoSize = true;
            this.label_pyear.Location = new System.Drawing.Point(74, 146);
            this.label_pyear.Name = "label_pyear";
            this.label_pyear.Size = new System.Drawing.Size(11, 12);
            this.label_pyear.TabIndex = 19;
            this.label_pyear.Text = "-";
            // 
            // label_publisher
            // 
            this.label_publisher.AutoSize = true;
            this.label_publisher.Location = new System.Drawing.Point(49, 118);
            this.label_publisher.Name = "label_publisher";
            this.label_publisher.Size = new System.Drawing.Size(11, 12);
            this.label_publisher.TabIndex = 18;
            this.label_publisher.Text = "-";
            // 
            // label_writer
            // 
            this.label_writer.AutoSize = true;
            this.label_writer.Location = new System.Drawing.Point(45, 93);
            this.label_writer.Name = "label_writer";
            this.label_writer.Size = new System.Drawing.Size(11, 12);
            this.label_writer.TabIndex = 17;
            this.label_writer.Text = "-";
            // 
            // label_bname
            // 
            this.label_bname.AutoSize = true;
            this.label_bname.Location = new System.Drawing.Point(74, 65);
            this.label_bname.Name = "label_bname";
            this.label_bname.Size = new System.Drawing.Size(11, 12);
            this.label_bname.TabIndex = 16;
            this.label_bname.Text = "-";
            // 
            // label_isbn
            // 
            this.label_isbn.AutoSize = true;
            this.label_isbn.Location = new System.Drawing.Point(49, 38);
            this.label_isbn.Name = "label_isbn";
            this.label_isbn.Size = new System.Drawing.Size(11, 12);
            this.label_isbn.TabIndex = 15;
            this.label_isbn.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "발행연도 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "출판사 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "저자 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "도서 이름 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Isbn :";
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 604);
            this.Controls.Add(this.gr_bookDeatail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PickReturnPlanDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PickRentDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_bookSearch);
            this.Controls.Add(this.txt_bookSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookSearch";
            this.Text = "BookRent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.gr_bookDeatail.ResumeLayout(false);
            this.gr_bookDeatail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_bookSearch;
        private System.Windows.Forms.TextBox txt_bookSearch;
        private System.Windows.Forms.DateTimePicker PickReturnPlanDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PickRentDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gr_bookDeatail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_pyear;
        private System.Windows.Forms.Label label_publisher;
        private System.Windows.Forms.Label label_writer;
        private System.Windows.Forms.Label label_bname;
        private System.Windows.Forms.Label label_isbn;
    }
}