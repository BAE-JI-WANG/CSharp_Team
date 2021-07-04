
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
            System.Windows.Forms.Button bt_booksearch;
            this.txt_booksearch = new System.Windows.Forms.TextBox();
            bt_booksearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_booksearch
            // 
            bt_booksearch.Location = new System.Drawing.Point(673, 12);
            bt_booksearch.Name = "bt_booksearch";
            bt_booksearch.Size = new System.Drawing.Size(75, 23);
            bt_booksearch.TabIndex = 0;
            bt_booksearch.Text = "button1";
            bt_booksearch.UseVisualStyleBackColor = true;
            bt_booksearch.Click += new System.EventHandler(this.bt_booksearch_Click);
            // 
            // txt_booksearch
            // 
            this.txt_booksearch.Location = new System.Drawing.Point(87, 15);
            this.txt_booksearch.Name = "txt_booksearch";
            this.txt_booksearch.Size = new System.Drawing.Size(529, 20);
            this.txt_booksearch.TabIndex = 1;
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_booksearch);
            this.Controls.Add(bt_booksearch);
            this.Name = "BookInfoForm";
            this.Text = "BookInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_booksearch;
    }
}