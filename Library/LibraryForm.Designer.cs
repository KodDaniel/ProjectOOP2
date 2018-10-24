namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.BTNChangeBook = new System.Windows.Forms.Button();
            this.TabBook = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddBookDescription_label = new System.Windows.Forms.Label();
            this.AddBookDescription_txtbox = new System.Windows.Forms.TextBox();
            this.DeleteBook_Btn = new System.Windows.Forms.Button();
            this.ListAllBooks_label = new System.Windows.Forms.Label();
            this.ListAllBooks_Btn = new System.Windows.Forms.Button();
            this.ListAllBooks_listbox = new System.Windows.Forms.ListBox();
            this.AddBook_btn = new System.Windows.Forms.Button();
            this.AddBookNumberOfCopies_label = new System.Windows.Forms.Label();
            this.AddBookAuthor_label = new System.Windows.Forms.Label();
            this.AddBookTitle_label = new System.Windows.Forms.Label();
            this.AddBookAuthor_txtbox = new System.Windows.Forms.TextBox();
            this.AddBookNumberOfCopies_txtbox = new System.Windows.Forms.TextBox();
            this.AddBookTitle_txtbox = new System.Windows.Forms.TextBox();
            this.AddBook_label = new System.Windows.Forms.Label();
            this.SearchForBooksByAuthor_label = new System.Windows.Forms.Label();
            this.SearchBookByAuthor_txtbox = new System.Windows.Forms.TextBox();
            this.SearchForBooksByAuthor_ListBox = new System.Windows.Forms.ListBox();
            this.SearchForBookByAuthor_Btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabBook.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(889, 245);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(182, 238);
            this.lbBooks.TabIndex = 0;
            // 
            // BTNChangeBook
            // 
            this.BTNChangeBook.Location = new System.Drawing.Point(879, 501);
            this.BTNChangeBook.Margin = new System.Windows.Forms.Padding(2);
            this.BTNChangeBook.Name = "BTNChangeBook";
            this.BTNChangeBook.Size = new System.Drawing.Size(192, 59);
            this.BTNChangeBook.TabIndex = 1;
            this.BTNChangeBook.Text = "TEST: Change the book title";
            this.BTNChangeBook.UseVisualStyleBackColor = true;
            this.BTNChangeBook.Click += new System.EventHandler(this.BTNChangeBook_Click);
            // 
            // TabBook
            // 
            this.TabBook.Controls.Add(this.tabPage1);
            this.TabBook.Controls.Add(this.tabPage2);
            this.TabBook.Location = new System.Drawing.Point(-1, 3);
            this.TabBook.Name = "TabBook";
            this.TabBook.SelectedIndex = 0;
            this.TabBook.Size = new System.Drawing.Size(864, 629);
            this.TabBook.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.AddBookDescription_label);
            this.tabPage1.Controls.Add(this.AddBookDescription_txtbox);
            this.tabPage1.Controls.Add(this.DeleteBook_Btn);
            this.tabPage1.Controls.Add(this.ListAllBooks_label);
            this.tabPage1.Controls.Add(this.ListAllBooks_Btn);
            this.tabPage1.Controls.Add(this.ListAllBooks_listbox);
            this.tabPage1.Controls.Add(this.AddBook_btn);
            this.tabPage1.Controls.Add(this.AddBookNumberOfCopies_label);
            this.tabPage1.Controls.Add(this.AddBookAuthor_label);
            this.tabPage1.Controls.Add(this.AddBookTitle_label);
            this.tabPage1.Controls.Add(this.AddBookAuthor_txtbox);
            this.tabPage1.Controls.Add(this.AddBookNumberOfCopies_txtbox);
            this.tabPage1.Controls.Add(this.AddBookTitle_txtbox);
            this.tabPage1.Controls.Add(this.AddBook_label);
            this.tabPage1.Controls.Add(this.SearchForBooksByAuthor_label);
            this.tabPage1.Controls.Add(this.SearchBookByAuthor_txtbox);
            this.tabPage1.Controls.Add(this.SearchForBooksByAuthor_ListBox);
            this.tabPage1.Controls.Add(this.SearchForBookByAuthor_Btn);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(856, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // AddBookDescription_label
            // 
            this.AddBookDescription_label.AutoSize = true;
            this.AddBookDescription_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookDescription_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBookDescription_label.Location = new System.Drawing.Point(234, 161);
            this.AddBookDescription_label.Name = "AddBookDescription_label";
            this.AddBookDescription_label.Size = new System.Drawing.Size(89, 20);
            this.AddBookDescription_label.TabIndex = 17;
            this.AddBookDescription_label.Text = "Description";
            // 
            // AddBookDescription_txtbox
            // 
            this.AddBookDescription_txtbox.Location = new System.Drawing.Point(208, 184);
            this.AddBookDescription_txtbox.Multiline = true;
            this.AddBookDescription_txtbox.Name = "AddBookDescription_txtbox";
            this.AddBookDescription_txtbox.Size = new System.Drawing.Size(160, 44);
            this.AddBookDescription_txtbox.TabIndex = 16;
            // 
            // DeleteBook_Btn
            // 
            this.DeleteBook_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBook_Btn.Location = new System.Drawing.Point(541, 286);
            this.DeleteBook_Btn.Name = "DeleteBook_Btn";
            this.DeleteBook_Btn.Size = new System.Drawing.Size(142, 34);
            this.DeleteBook_Btn.TabIndex = 15;
            this.DeleteBook_Btn.Text = "Delete book";
            this.DeleteBook_Btn.UseVisualStyleBackColor = true;
            // 
            // ListAllBooks_label
            // 
            this.ListAllBooks_label.AutoSize = true;
            this.ListAllBooks_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListAllBooks_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListAllBooks_label.Location = new System.Drawing.Point(421, 7);
            this.ListAllBooks_label.Name = "ListAllBooks_label";
            this.ListAllBooks_label.Size = new System.Drawing.Size(339, 44);
            this.ListAllBooks_label.TabIndex = 14;
            this.ListAllBooks_label.Text = "All books (with Title, Author, Description, \r\navailable  number of copies and so " +
    "on)";
            // 
            // ListAllBooks_Btn
            // 
            this.ListAllBooks_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListAllBooks_Btn.Location = new System.Drawing.Point(541, 246);
            this.ListAllBooks_Btn.Name = "ListAllBooks_Btn";
            this.ListAllBooks_Btn.Size = new System.Drawing.Size(142, 34);
            this.ListAllBooks_Btn.TabIndex = 13;
            this.ListAllBooks_Btn.Text = "List all books";
            this.ListAllBooks_Btn.UseVisualStyleBackColor = true;
            this.ListAllBooks_Btn.Click += new System.EventHandler(this.ListAllBooks_Btn_Click);
            // 
            // ListAllBooks_listbox
            // 
            this.ListAllBooks_listbox.FormattingEnabled = true;
            this.ListAllBooks_listbox.Location = new System.Drawing.Point(425, 54);
            this.ListAllBooks_listbox.Name = "ListAllBooks_listbox";
            this.ListAllBooks_listbox.Size = new System.Drawing.Size(408, 186);
            this.ListAllBooks_listbox.TabIndex = 12;
            this.ListAllBooks_listbox.SelectedIndexChanged += new System.EventHandler(this.ListAllBooks_listbox_SelectedIndexChanged);
            // 
            // AddBook_btn
            // 
            this.AddBook_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBook_btn.Location = new System.Drawing.Point(217, 283);
            this.AddBook_btn.Name = "AddBook_btn";
            this.AddBook_btn.Size = new System.Drawing.Size(142, 34);
            this.AddBook_btn.TabIndex = 11;
            this.AddBook_btn.Text = "Add book";
            this.AddBook_btn.UseVisualStyleBackColor = true;
            // 
            // AddBookNumberOfCopies_label
            // 
            this.AddBookNumberOfCopies_label.AutoSize = true;
            this.AddBookNumberOfCopies_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookNumberOfCopies_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBookNumberOfCopies_label.Location = new System.Drawing.Point(226, 231);
            this.AddBookNumberOfCopies_label.Name = "AddBookNumberOfCopies_label";
            this.AddBookNumberOfCopies_label.Size = new System.Drawing.Size(133, 20);
            this.AddBookNumberOfCopies_label.TabIndex = 10;
            this.AddBookNumberOfCopies_label.Text = "Number of copies";
            // 
            // AddBookAuthor_label
            // 
            this.AddBookAuthor_label.AutoSize = true;
            this.AddBookAuthor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookAuthor_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBookAuthor_label.Location = new System.Drawing.Point(243, 102);
            this.AddBookAuthor_label.Name = "AddBookAuthor_label";
            this.AddBookAuthor_label.Size = new System.Drawing.Size(57, 20);
            this.AddBookAuthor_label.TabIndex = 9;
            this.AddBookAuthor_label.Text = "Author";
            // 
            // AddBookTitle_label
            // 
            this.AddBookTitle_label.AutoSize = true;
            this.AddBookTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookTitle_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBookTitle_label.Location = new System.Drawing.Point(243, 46);
            this.AddBookTitle_label.Name = "AddBookTitle_label";
            this.AddBookTitle_label.Size = new System.Drawing.Size(38, 20);
            this.AddBookTitle_label.TabIndex = 8;
            this.AddBookTitle_label.Text = "Title";
            // 
            // AddBookAuthor_txtbox
            // 
            this.AddBookAuthor_txtbox.Location = new System.Drawing.Point(217, 125);
            this.AddBookAuthor_txtbox.Name = "AddBookAuthor_txtbox";
            this.AddBookAuthor_txtbox.Size = new System.Drawing.Size(151, 20);
            this.AddBookAuthor_txtbox.TabIndex = 7;
            // 
            // AddBookNumberOfCopies_txtbox
            // 
            this.AddBookNumberOfCopies_txtbox.Location = new System.Drawing.Point(217, 254);
            this.AddBookNumberOfCopies_txtbox.Name = "AddBookNumberOfCopies_txtbox";
            this.AddBookNumberOfCopies_txtbox.Size = new System.Drawing.Size(151, 20);
            this.AddBookNumberOfCopies_txtbox.TabIndex = 6;
            // 
            // AddBookTitle_txtbox
            // 
            this.AddBookTitle_txtbox.Location = new System.Drawing.Point(217, 69);
            this.AddBookTitle_txtbox.Name = "AddBookTitle_txtbox";
            this.AddBookTitle_txtbox.Size = new System.Drawing.Size(151, 20);
            this.AddBookTitle_txtbox.TabIndex = 5;
            // 
            // AddBook_label
            // 
            this.AddBook_label.AutoSize = true;
            this.AddBook_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBook_label.Location = new System.Drawing.Point(234, 7);
            this.AddBook_label.Name = "AddBook_label";
            this.AddBook_label.Size = new System.Drawing.Size(88, 22);
            this.AddBook_label.TabIndex = 4;
            this.AddBook_label.Text = "Add Book";
            // 
            // SearchForBooksByAuthor_label
            // 
            this.SearchForBooksByAuthor_label.AutoSize = true;
            this.SearchForBooksByAuthor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForBooksByAuthor_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchForBooksByAuthor_label.Location = new System.Drawing.Point(35, 7);
            this.SearchForBooksByAuthor_label.Name = "SearchForBooksByAuthor_label";
            this.SearchForBooksByAuthor_label.Size = new System.Drawing.Size(63, 22);
            this.SearchForBooksByAuthor_label.TabIndex = 3;
            this.SearchForBooksByAuthor_label.Text = "Author";
            // 
            // SearchBookByAuthor_txtbox
            // 
            this.SearchBookByAuthor_txtbox.Location = new System.Drawing.Point(9, 32);
            this.SearchBookByAuthor_txtbox.Name = "SearchBookByAuthor_txtbox";
            this.SearchBookByAuthor_txtbox.Size = new System.Drawing.Size(151, 20);
            this.SearchBookByAuthor_txtbox.TabIndex = 2;
            this.SearchBookByAuthor_txtbox.TextChanged += new System.EventHandler(this.SearchBookByAuthor_txtbox_TextChanged);
            // 
            // SearchForBooksByAuthor_ListBox
            // 
            this.SearchForBooksByAuthor_ListBox.FormattingEnabled = true;
            this.SearchForBooksByAuthor_ListBox.Location = new System.Drawing.Point(6, 69);
            this.SearchForBooksByAuthor_ListBox.Name = "SearchForBooksByAuthor_ListBox";
            this.SearchForBooksByAuthor_ListBox.Size = new System.Drawing.Size(186, 199);
            this.SearchForBooksByAuthor_ListBox.TabIndex = 1;
            // 
            // SearchForBookByAuthor_Btn
            // 
            this.SearchForBookByAuthor_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchForBookByAuthor_Btn.Location = new System.Drawing.Point(18, 283);
            this.SearchForBookByAuthor_Btn.Name = "SearchForBookByAuthor_Btn";
            this.SearchForBookByAuthor_Btn.Size = new System.Drawing.Size(142, 34);
            this.SearchForBookByAuthor_Btn.TabIndex = 0;
            this.SearchForBookByAuthor_Btn.Text = "Search for book by author";
            this.SearchForBookByAuthor_Btn.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 644);
            this.Controls.Add(this.TabBook);
            this.Controls.Add(this.BTNChangeBook);
            this.Controls.Add(this.lbBooks);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.TabBook.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button BTNChangeBook;
        private System.Windows.Forms.TabControl TabBook;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label SearchForBooksByAuthor_label;
        private System.Windows.Forms.TextBox SearchBookByAuthor_txtbox;
        private System.Windows.Forms.ListBox SearchForBooksByAuthor_ListBox;
        private System.Windows.Forms.Button SearchForBookByAuthor_Btn;
        private System.Windows.Forms.Button ListAllBooks_Btn;
        private System.Windows.Forms.ListBox ListAllBooks_listbox;
        private System.Windows.Forms.Button AddBook_btn;
        private System.Windows.Forms.Label AddBookNumberOfCopies_label;
        private System.Windows.Forms.Label AddBookAuthor_label;
        private System.Windows.Forms.Label AddBookTitle_label;
        private System.Windows.Forms.TextBox AddBookAuthor_txtbox;
        private System.Windows.Forms.TextBox AddBookNumberOfCopies_txtbox;
        private System.Windows.Forms.TextBox AddBookTitle_txtbox;
        private System.Windows.Forms.Label AddBook_label;
        private System.Windows.Forms.Label ListAllBooks_label;
        private System.Windows.Forms.Label AddBookDescription_label;
        private System.Windows.Forms.TextBox AddBookDescription_txtbox;
        private System.Windows.Forms.Button DeleteBook_Btn;
    }
}

