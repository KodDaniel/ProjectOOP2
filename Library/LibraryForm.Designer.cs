namespace Library
{
    partial class LibraryForm
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SearchBooksByAuthor_Btn = new System.Windows.Forms.Button();
            this.SearchBookByAuthor_label = new System.Windows.Forms.Label();
            this.SearchBooksByAuthor_listbox = new System.Windows.Forms.ListBox();
            this.ListAllAuthors_Btn = new System.Windows.Forms.Button();
            this.ListAllAuthors_label = new System.Windows.Forms.Label();
            this.ListAllAuthors_listbox = new System.Windows.Forms.ListBox();
            this.AddAuthor_label = new System.Windows.Forms.Label();
            this.AddAuthorName_label = new System.Windows.Forms.Label();
            this.AddAuthorName_textbox = new System.Windows.Forms.TextBox();
            this.AddAuthor_Btn = new System.Windows.Forms.Button();
            this.AddBook_Button = new System.Windows.Forms.Button();
            this.ListAllBooks_Btn = new System.Windows.Forms.Button();
            this.ListAllBooks_label = new System.Windows.Forms.Label();
            this.ListAllBooks_listBox = new System.Windows.Forms.ListBox();
            this.AddBookISBN_label = new System.Windows.Forms.Label();
            this.AddBookISBN_textbox = new System.Windows.Forms.TextBox();
            this.AddBookDescription_TextBox = new System.Windows.Forms.TextBox();
            this.AddBookDescription_label = new System.Windows.Forms.Label();
            this.AddBook_label = new System.Windows.Forms.Label();
            this.AddBookTitle_label = new System.Windows.Forms.Label();
            this.AddBookTitle_TextBox = new System.Windows.Forms.TextBox();
            this.AddBookAuthor_label = new System.Windows.Forms.Label();
            this.AddBookCopies_Label = new System.Windows.Forms.Label();
            this.AddBookAuthor_ComboBox = new System.Windows.Forms.ComboBox();
            this.AddBookNumberOfCopies_drop = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorToSearchByComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBookNumberOfCopies_drop)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1301, 616);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AuthorToSearchByComboBox);
            this.tabPage1.Controls.Add(this.SearchBooksByAuthor_Btn);
            this.tabPage1.Controls.Add(this.SearchBookByAuthor_label);
            this.tabPage1.Controls.Add(this.SearchBooksByAuthor_listbox);
            this.tabPage1.Controls.Add(this.ListAllAuthors_Btn);
            this.tabPage1.Controls.Add(this.ListAllAuthors_label);
            this.tabPage1.Controls.Add(this.ListAllAuthors_listbox);
            this.tabPage1.Controls.Add(this.AddAuthor_label);
            this.tabPage1.Controls.Add(this.AddAuthorName_label);
            this.tabPage1.Controls.Add(this.AddAuthorName_textbox);
            this.tabPage1.Controls.Add(this.AddAuthor_Btn);
            this.tabPage1.Controls.Add(this.AddBook_Button);
            this.tabPage1.Controls.Add(this.ListAllBooks_Btn);
            this.tabPage1.Controls.Add(this.ListAllBooks_label);
            this.tabPage1.Controls.Add(this.ListAllBooks_listBox);
            this.tabPage1.Controls.Add(this.AddBookISBN_label);
            this.tabPage1.Controls.Add(this.AddBookISBN_textbox);
            this.tabPage1.Controls.Add(this.AddBookDescription_TextBox);
            this.tabPage1.Controls.Add(this.AddBookDescription_label);
            this.tabPage1.Controls.Add(this.AddBook_label);
            this.tabPage1.Controls.Add(this.AddBookTitle_label);
            this.tabPage1.Controls.Add(this.AddBookTitle_TextBox);
            this.tabPage1.Controls.Add(this.AddBookAuthor_label);
            this.tabPage1.Controls.Add(this.AddBookCopies_Label);
            this.tabPage1.Controls.Add(this.AddBookAuthor_ComboBox);
            this.tabPage1.Controls.Add(this.AddBookNumberOfCopies_drop);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1293, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // SearchBooksByAuthor_Btn
            // 
            this.SearchBooksByAuthor_Btn.Location = new System.Drawing.Point(744, 551);
            this.SearchBooksByAuthor_Btn.Name = "SearchBooksByAuthor_Btn";
            this.SearchBooksByAuthor_Btn.Size = new System.Drawing.Size(281, 23);
            this.SearchBooksByAuthor_Btn.TabIndex = 43;
            this.SearchBooksByAuthor_Btn.Text = "Search books by author";
            this.SearchBooksByAuthor_Btn.UseVisualStyleBackColor = true;
            this.SearchBooksByAuthor_Btn.Click += new System.EventHandler(this.SearchBooksByAuthor_Btn_Click);
            // 
            // SearchBookByAuthor_label
            // 
            this.SearchBookByAuthor_label.AutoSize = true;
            this.SearchBookByAuthor_label.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBookByAuthor_label.Location = new System.Drawing.Point(758, 408);
            this.SearchBookByAuthor_label.Name = "SearchBookByAuthor_label";
            this.SearchBookByAuthor_label.Size = new System.Drawing.Size(217, 24);
            this.SearchBookByAuthor_label.TabIndex = 42;
            this.SearchBookByAuthor_label.Text = "Search book by author";
            // 
            // SearchBooksByAuthor_listbox
            // 
            this.SearchBooksByAuthor_listbox.FormattingEnabled = true;
            this.SearchBooksByAuthor_listbox.Location = new System.Drawing.Point(744, 463);
            this.SearchBooksByAuthor_listbox.Name = "SearchBooksByAuthor_listbox";
            this.SearchBooksByAuthor_listbox.Size = new System.Drawing.Size(531, 69);
            this.SearchBooksByAuthor_listbox.TabIndex = 41;
            // 
            // ListAllAuthors_Btn
            // 
            this.ListAllAuthors_Btn.Location = new System.Drawing.Point(360, 356);
            this.ListAllAuthors_Btn.Name = "ListAllAuthors_Btn";
            this.ListAllAuthors_Btn.Size = new System.Drawing.Size(281, 23);
            this.ListAllAuthors_Btn.TabIndex = 40;
            this.ListAllAuthors_Btn.Text = "List all authors";
            this.ListAllAuthors_Btn.UseVisualStyleBackColor = true;
            this.ListAllAuthors_Btn.Click += new System.EventHandler(this.ListAllAuthors_Btn_Click);
            // 
            // ListAllAuthors_label
            // 
            this.ListAllAuthors_label.AutoSize = true;
            this.ListAllAuthors_label.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListAllAuthors_label.Location = new System.Drawing.Point(374, 213);
            this.ListAllAuthors_label.Name = "ListAllAuthors_label";
            this.ListAllAuthors_label.Size = new System.Drawing.Size(111, 24);
            this.ListAllAuthors_label.TabIndex = 39;
            this.ListAllAuthors_label.Text = "All authors";
            // 
            // ListAllAuthors_listbox
            // 
            this.ListAllAuthors_listbox.FormattingEnabled = true;
            this.ListAllAuthors_listbox.Location = new System.Drawing.Point(360, 268);
            this.ListAllAuthors_listbox.Name = "ListAllAuthors_listbox";
            this.ListAllAuthors_listbox.Size = new System.Drawing.Size(531, 69);
            this.ListAllAuthors_listbox.TabIndex = 38;
            // 
            // AddAuthor_label
            // 
            this.AddAuthor_label.AutoSize = true;
            this.AddAuthor_label.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAuthor_label.Location = new System.Drawing.Point(935, 34);
            this.AddAuthor_label.Name = "AddAuthor_label";
            this.AddAuthor_label.Size = new System.Drawing.Size(107, 24);
            this.AddAuthor_label.TabIndex = 37;
            this.AddAuthor_label.Text = "AddAuthor";
            // 
            // AddAuthorName_label
            // 
            this.AddAuthorName_label.AutoSize = true;
            this.AddAuthorName_label.Location = new System.Drawing.Point(936, 59);
            this.AddAuthorName_label.Name = "AddAuthorName_label";
            this.AddAuthorName_label.Size = new System.Drawing.Size(35, 13);
            this.AddAuthorName_label.TabIndex = 36;
            this.AddAuthorName_label.Text = "Name";
            // 
            // AddAuthorName_textbox
            // 
            this.AddAuthorName_textbox.Location = new System.Drawing.Point(939, 75);
            this.AddAuthorName_textbox.Name = "AddAuthorName_textbox";
            this.AddAuthorName_textbox.Size = new System.Drawing.Size(253, 20);
            this.AddAuthorName_textbox.TabIndex = 35;
            // 
            // AddAuthor_Btn
            // 
            this.AddAuthor_Btn.Location = new System.Drawing.Point(939, 101);
            this.AddAuthor_Btn.Name = "AddAuthor_Btn";
            this.AddAuthor_Btn.Size = new System.Drawing.Size(250, 25);
            this.AddAuthor_Btn.TabIndex = 34;
            this.AddAuthor_Btn.Text = "Add author";
            this.AddAuthor_Btn.UseVisualStyleBackColor = true;
            this.AddAuthor_Btn.Click += new System.EventHandler(this.AddAuthor_Btn_Click);
            // 
            // AddBook_Button
            // 
            this.AddBook_Button.Location = new System.Drawing.Point(24, 438);
            this.AddBook_Button.Name = "AddBook_Button";
            this.AddBook_Button.Size = new System.Drawing.Size(250, 25);
            this.AddBook_Button.TabIndex = 33;
            this.AddBook_Button.Text = "Add book";
            this.AddBook_Button.UseVisualStyleBackColor = true;
            this.AddBook_Button.Click += new System.EventHandler(this.AddBook_Button_Click);
            // 
            // ListAllBooks_Btn
            // 
            this.ListAllBooks_Btn.Location = new System.Drawing.Point(319, 168);
            this.ListAllBooks_Btn.Name = "ListAllBooks_Btn";
            this.ListAllBooks_Btn.Size = new System.Drawing.Size(281, 23);
            this.ListAllBooks_Btn.TabIndex = 32;
            this.ListAllBooks_Btn.Text = "List all books";
            this.ListAllBooks_Btn.UseVisualStyleBackColor = true;
            this.ListAllBooks_Btn.Click += new System.EventHandler(this.ListAllBooks_Btn_Click);
            // 
            // ListAllBooks_label
            // 
            this.ListAllBooks_label.AutoSize = true;
            this.ListAllBooks_label.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListAllBooks_label.Location = new System.Drawing.Point(333, 25);
            this.ListAllBooks_label.Name = "ListAllBooks_label";
            this.ListAllBooks_label.Size = new System.Drawing.Size(95, 24);
            this.ListAllBooks_label.TabIndex = 31;
            this.ListAllBooks_label.Text = "All books";
            // 
            // ListAllBooks_listBox
            // 
            this.ListAllBooks_listBox.FormattingEnabled = true;
            this.ListAllBooks_listBox.Location = new System.Drawing.Point(319, 80);
            this.ListAllBooks_listBox.Name = "ListAllBooks_listBox";
            this.ListAllBooks_listBox.Size = new System.Drawing.Size(531, 69);
            this.ListAllBooks_listBox.TabIndex = 30;
            this.ListAllBooks_listBox.SelectedIndexChanged += new System.EventHandler(this.ListAllBooks_listBox_SelectedIndexChanged);
            // 
            // AddBookISBN_label
            // 
            this.AddBookISBN_label.AutoSize = true;
            this.AddBookISBN_label.Location = new System.Drawing.Point(21, 64);
            this.AddBookISBN_label.Name = "AddBookISBN_label";
            this.AddBookISBN_label.Size = new System.Drawing.Size(32, 13);
            this.AddBookISBN_label.TabIndex = 29;
            this.AddBookISBN_label.Text = "ISBN";
            this.AddBookISBN_label.Click += new System.EventHandler(this.AddBookISBN_label_Click);
            // 
            // AddBookISBN_textbox
            // 
            this.AddBookISBN_textbox.Location = new System.Drawing.Point(21, 80);
            this.AddBookISBN_textbox.Name = "AddBookISBN_textbox";
            this.AddBookISBN_textbox.Size = new System.Drawing.Size(253, 20);
            this.AddBookISBN_textbox.TabIndex = 28;
            this.AddBookISBN_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddBookDescription_TextBox
            // 
            this.AddBookDescription_TextBox.Location = new System.Drawing.Point(21, 222);
            this.AddBookDescription_TextBox.Multiline = true;
            this.AddBookDescription_TextBox.Name = "AddBookDescription_TextBox";
            this.AddBookDescription_TextBox.Size = new System.Drawing.Size(253, 141);
            this.AddBookDescription_TextBox.TabIndex = 26;
            this.AddBookDescription_TextBox.TextChanged += new System.EventHandler(this.AddBookDescription_TextBox_TextChanged);
            // 
            // AddBookDescription_label
            // 
            this.AddBookDescription_label.AutoSize = true;
            this.AddBookDescription_label.Location = new System.Drawing.Point(21, 206);
            this.AddBookDescription_label.Name = "AddBookDescription_label";
            this.AddBookDescription_label.Size = new System.Drawing.Size(60, 13);
            this.AddBookDescription_label.TabIndex = 27;
            this.AddBookDescription_label.Text = "Description";
            this.AddBookDescription_label.Click += new System.EventHandler(this.AddBookDescription_label_Click);
            // 
            // AddBook_label
            // 
            this.AddBook_label.AutoSize = true;
            this.AddBook_label.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook_label.Location = new System.Drawing.Point(17, 25);
            this.AddBook_label.Name = "AddBook_label";
            this.AddBook_label.Size = new System.Drawing.Size(95, 24);
            this.AddBook_label.TabIndex = 25;
            this.AddBook_label.Text = "Add book";
            this.AddBook_label.Click += new System.EventHandler(this.AddBook_label_Click);
            // 
            // AddBookTitle_label
            // 
            this.AddBookTitle_label.AutoSize = true;
            this.AddBookTitle_label.Location = new System.Drawing.Point(21, 113);
            this.AddBookTitle_label.Name = "AddBookTitle_label";
            this.AddBookTitle_label.Size = new System.Drawing.Size(27, 13);
            this.AddBookTitle_label.TabIndex = 20;
            this.AddBookTitle_label.Text = "Title";
            this.AddBookTitle_label.Click += new System.EventHandler(this.AddBookTitle_label_Click);
            // 
            // AddBookTitle_TextBox
            // 
            this.AddBookTitle_TextBox.Location = new System.Drawing.Point(21, 129);
            this.AddBookTitle_TextBox.Name = "AddBookTitle_TextBox";
            this.AddBookTitle_TextBox.Size = new System.Drawing.Size(253, 20);
            this.AddBookTitle_TextBox.TabIndex = 19;
            this.AddBookTitle_TextBox.TextChanged += new System.EventHandler(this.AddBookTitle_TextBox_TextChanged);
            // 
            // AddBookAuthor_label
            // 
            this.AddBookAuthor_label.AutoSize = true;
            this.AddBookAuthor_label.Location = new System.Drawing.Point(21, 152);
            this.AddBookAuthor_label.Name = "AddBookAuthor_label";
            this.AddBookAuthor_label.Size = new System.Drawing.Size(38, 13);
            this.AddBookAuthor_label.TabIndex = 21;
            this.AddBookAuthor_label.Text = "Author";
            this.AddBookAuthor_label.Click += new System.EventHandler(this.AddBookAuthor_label_Click);
            // 
            // AddBookCopies_Label
            // 
            this.AddBookCopies_Label.AutoSize = true;
            this.AddBookCopies_Label.Location = new System.Drawing.Point(21, 376);
            this.AddBookCopies_Label.Name = "AddBookCopies_Label";
            this.AddBookCopies_Label.Size = new System.Drawing.Size(39, 13);
            this.AddBookCopies_Label.TabIndex = 24;
            this.AddBookCopies_Label.Text = "Copies";
            this.AddBookCopies_Label.Click += new System.EventHandler(this.AddBookCopies_Label_Click);
            // 
            // AddBookAuthor_ComboBox
            // 
            this.AddBookAuthor_ComboBox.FormattingEnabled = true;
            this.AddBookAuthor_ComboBox.Location = new System.Drawing.Point(21, 168);
            this.AddBookAuthor_ComboBox.Name = "AddBookAuthor_ComboBox";
            this.AddBookAuthor_ComboBox.Size = new System.Drawing.Size(253, 21);
            this.AddBookAuthor_ComboBox.TabIndex = 22;
            this.AddBookAuthor_ComboBox.SelectedIndexChanged += new System.EventHandler(this.AddBookAuthor_ComboBox_SelectedIndexChanged);
            // 
            // AddBookNumberOfCopies_drop
            // 
            this.AddBookNumberOfCopies_drop.Location = new System.Drawing.Point(21, 392);
            this.AddBookNumberOfCopies_drop.Name = "AddBookNumberOfCopies_drop";
            this.AddBookNumberOfCopies_drop.Size = new System.Drawing.Size(253, 20);
            this.AddBookNumberOfCopies_drop.TabIndex = 23;
            this.AddBookNumberOfCopies_drop.ValueChanged += new System.EventHandler(this.AddBookNumberOfCopies_drop_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1293, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1000, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Author";
            // 
            // AuthorToSearchByComboBox
            // 
            this.AuthorToSearchByComboBox.FormattingEnabled = true;
            this.AuthorToSearchByComboBox.Location = new System.Drawing.Point(1000, 408);
            this.AuthorToSearchByComboBox.Name = "AuthorToSearchByComboBox";
            this.AuthorToSearchByComboBox.Size = new System.Drawing.Size(253, 21);
            this.AuthorToSearchByComboBox.TabIndex = 45;
            // 
            // LibraryForm
            // 
            this.ClientSize = new System.Drawing.Size(1330, 639);
            this.Controls.Add(this.tabControl1);
            this.Name = "LibraryForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBookNumberOfCopies_drop)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label AddBookISBN_label;
        private System.Windows.Forms.TextBox AddBookISBN_textbox;
        private System.Windows.Forms.TextBox AddBookDescription_TextBox;
        private System.Windows.Forms.Label AddBookDescription_label;
        private System.Windows.Forms.Label AddBook_label;
        private System.Windows.Forms.Label AddBookTitle_label;
        private System.Windows.Forms.TextBox AddBookTitle_TextBox;
        private System.Windows.Forms.Label AddBookAuthor_label;
        private System.Windows.Forms.Label AddBookCopies_Label;
        private System.Windows.Forms.ComboBox AddBookAuthor_ComboBox;
        private System.Windows.Forms.NumericUpDown AddBookNumberOfCopies_drop;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ListAllBooks_Btn;
        private System.Windows.Forms.Label ListAllBooks_label;
        private System.Windows.Forms.ListBox ListAllBooks_listBox;
        private System.Windows.Forms.Button AddBook_Button;
        private System.Windows.Forms.Button AddAuthor_Btn;
        private System.Windows.Forms.Label AddAuthorName_label;
        private System.Windows.Forms.TextBox AddAuthorName_textbox;
        private System.Windows.Forms.Label AddAuthor_label;
        private System.Windows.Forms.Button ListAllAuthors_Btn;
        private System.Windows.Forms.Label ListAllAuthors_label;
        private System.Windows.Forms.ListBox ListAllAuthors_listbox;
        private System.Windows.Forms.Button SearchBooksByAuthor_Btn;
        private System.Windows.Forms.Label SearchBookByAuthor_label;
        private System.Windows.Forms.ListBox SearchBooksByAuthor_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AuthorToSearchByComboBox;
    }
}
    