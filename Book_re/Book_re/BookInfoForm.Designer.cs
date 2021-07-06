
namespace Book_re
{
    partial class BookInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_booksearch = new Sunny.UI.UIButton();
            this.txt_booksearch = new Sunny.UI.UIRichTextBox();
            this.bt_exit = new Sunny.UI.UIImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.bt_booksearch);
            this.panel1.Controls.Add(this.txt_booksearch);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 679);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 302);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(536, 118);
            this.dataGridView1.TabIndex = 7;
            // 
            // bt_booksearch
            // 
            this.bt_booksearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_booksearch.FillColor = System.Drawing.Color.Maroon;
            this.bt_booksearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bt_booksearch.Location = new System.Drawing.Point(518, 68);
            this.bt_booksearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_booksearch.Name = "bt_booksearch";
            this.bt_booksearch.Radius = 15;
            this.bt_booksearch.RectColor = System.Drawing.Color.Black;
            this.bt_booksearch.Size = new System.Drawing.Size(100, 35);
            this.bt_booksearch.Style = Sunny.UI.UIStyle.Custom;
            this.bt_booksearch.TabIndex = 6;
            this.bt_booksearch.Text = "Search";
            this.bt_booksearch.Click += new System.EventHandler(this.bt_booksearch_Click);
            // 
            // txt_booksearch
            // 
            this.txt_booksearch.AutoWordSelection = true;
            this.txt_booksearch.FillColor = System.Drawing.Color.White;
            this.txt_booksearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_booksearch.Location = new System.Drawing.Point(41, 68);
            this.txt_booksearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_booksearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_booksearch.Name = "txt_booksearch";
            this.txt_booksearch.Padding = new System.Windows.Forms.Padding(2);
            this.txt_booksearch.Radius = 20;
            this.txt_booksearch.RectColor = System.Drawing.Color.Silver;
            this.txt_booksearch.RectDisableColor = System.Drawing.Color.Maroon;
            this.txt_booksearch.Size = new System.Drawing.Size(456, 36);
            this.txt_booksearch.Style = Sunny.UI.UIStyle.Custom;
            this.txt_booksearch.TabIndex = 5;
            this.txt_booksearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_exit
            // 
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bt_exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.Image")));
            this.bt_exit.Location = new System.Drawing.Point(606, 3);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(29, 28);
            this.bt_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_exit.TabIndex = 4;
            this.bt_exit.TabStop = false;
            this.bt_exit.Text = null;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(648, 689);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookInfoForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfoForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIImageButton bt_exit;
        private Sunny.UI.UIButton bt_booksearch;
        private Sunny.UI.UIRichTextBox txt_booksearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}