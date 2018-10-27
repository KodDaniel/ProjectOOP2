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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.BookDetails_Description_TextBox = new System.Windows.Forms.TextBox();
            this.BookDetails_ISBN_TextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.MakeLoan_Button = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.BookDetails_Title_TextBox = new System.Windows.Forms.TextBox();
            this.BookDetails_AvailableCopies_TextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.BookDetails_Author_TextBox = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Title_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Author_ComboBox = new System.Windows.Forms.ComboBox();
            this.Description_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Copies_Numeric = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.EditISBN_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EditBook_Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.RemoveBook_Button = new System.Windows.Forms.Button();
            this.EditBookTitle_TextBox = new System.Windows.Forms.TextBox();
            this.EditBookCopies_Numeric = new System.Windows.Forms.NumericUpDown();
            this.EditBookAuthor_ComboBox = new System.Windows.Forms.ComboBox();
            this.EditBookDescription_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBookNumberOfCopies_drop)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Copies_Numeric)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditBookCopies_Numeric)).BeginInit();
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
            this.SearchBooksByAuthor_Btn.Location = new System.Drawing.Point(335, 494);
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
            this.SearchBookByAuthor_label.Location = new System.Drawing.Point(331, 384);
            this.SearchBookByAuthor_label.Name = "SearchBookByAuthor_label";
            this.SearchBookByAuthor_label.Size = new System.Drawing.Size(217, 24);
            this.SearchBookByAuthor_label.TabIndex = 42;
            this.SearchBookByAuthor_label.Text = "Search book by author";
            // 
            // SearchBooksByAuthor_listbox
            // 
            this.SearchBooksByAuthor_listbox.FormattingEnabled = true;
            this.SearchBooksByAuthor_listbox.Location = new System.Drawing.Point(335, 419);
            this.SearchBooksByAuthor_listbox.Name = "SearchBooksByAuthor_listbox";
            this.SearchBooksByAuthor_listbox.Size = new System.Drawing.Size(531, 69);
            this.SearchBooksByAuthor_listbox.TabIndex = 41;
            // 
            // ListAllAuthors_Btn
            // 
            this.ListAllAuthors_Btn.Location = new System.Drawing.Point(347, 301);
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
            this.ListAllAuthors_label.Location = new System.Drawing.Point(356, 199);
            this.ListAllAuthors_label.Name = "ListAllAuthors_label";
            this.ListAllAuthors_label.Size = new System.Drawing.Size(111, 24);
            this.ListAllAuthors_label.TabIndex = 39;
            this.ListAllAuthors_label.Text = "All authors";
            // 
            // ListAllAuthors_listbox
            // 
            this.ListAllAuthors_listbox.FormattingEnabled = true;
            this.ListAllAuthors_listbox.Location = new System.Drawing.Point(347, 226);
            this.ListAllAuthors_listbox.Name = "ListAllAuthors_listbox";
            this.ListAllAuthors_listbox.Size = new System.Drawing.Size(531, 69);
            this.ListAllAuthors_listbox.TabIndex = 38;
            // 
            // AddAuthor_label
            // 
            this.AddAuthor_label.AutoSize = true;
            this.AddAuthor_label.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAuthor_label.Location = new System.Drawing.Point(48, 486);
            this.AddAuthor_label.Name = "AddAuthor_label";
            this.AddAuthor_label.Size = new System.Drawing.Size(107, 24);
            this.AddAuthor_label.TabIndex = 37;
            this.AddAuthor_label.Text = "AddAuthor";
            // 
            // AddAuthorName_label
            // 
            this.AddAuthorName_label.AutoSize = true;
            this.AddAuthorName_label.Location = new System.Drawing.Point(49, 511);
            this.AddAuthorName_label.Name = "AddAuthorName_label";
            this.AddAuthorName_label.Size = new System.Drawing.Size(35, 13);
            this.AddAuthorName_label.TabIndex = 36;
            this.AddAuthorName_label.Text = "Name";
            // 
            // AddAuthorName_textbox
            // 
            this.AddAuthorName_textbox.Location = new System.Drawing.Point(52, 527);
            this.AddAuthorName_textbox.Name = "AddAuthorName_textbox";
            this.AddAuthorName_textbox.Size = new System.Drawing.Size(253, 20);
            this.AddAuthorName_textbox.TabIndex = 35;
            // 
            // AddAuthor_Btn
            // 
            this.AddAuthor_Btn.Location = new System.Drawing.Point(52, 553);
            this.AddAuthor_Btn.Name = "AddAuthor_Btn";
            this.AddAuthor_Btn.Size = new System.Drawing.Size(250, 25);
            this.AddAuthor_Btn.TabIndex = 34;
            this.AddAuthor_Btn.Text = "Add author";
            this.AddAuthor_Btn.UseVisualStyleBackColor = true;
            this.AddAuthor_Btn.Click += new System.EventHandler(this.AddAuthor_Btn_Click);
            // 
            // AddBook_Button
            // 
            this.AddBook_Button.Location = new System.Drawing.Point(24, 429);
            this.AddBook_Button.Name = "AddBook_Button";
            this.AddBook_Button.Size = new System.Drawing.Size(250, 25);
            this.AddBook_Button.TabIndex = 33;
            this.AddBook_Button.Text = "Add book";
            this.AddBook_Button.UseVisualStyleBackColor = true;
            this.AddBook_Button.Click += new System.EventHandler(this.AddBook_Button_Click);
            // 
            // ListAllBooks_Btn
            // 
            this.ListAllBooks_Btn.Location = new System.Drawing.Point(319, 155);
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
            this.ListAllBooks_label.Location = new System.Drawing.Point(315, 31);
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
            this.AddBook_label.Location = new System.Drawing.Point(17, 31);
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
            this.tabPage2.Controls.Add(this.tabControl2);
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
            this.label1.Location = new System.Drawing.Point(595, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Author";
            // 
            // AuthorToSearchByComboBox
            // 
            this.AuthorToSearchByComboBox.FormattingEnabled = true;
            this.AuthorToSearchByComboBox.Location = new System.Drawing.Point(595, 385);
            this.AuthorToSearchByComboBox.Name = "AuthorToSearchByComboBox";
            this.AuthorToSearchByComboBox.Size = new System.Drawing.Size(253, 21);
            this.AuthorToSearchByComboBox.TabIndex = 45;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1319, 600);
            this.tabControl2.TabIndex = 10;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.BookDetails_Description_TextBox);
            this.tabPage6.Controls.Add(this.BookDetails_ISBN_TextBox);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.MakeLoan_Button);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.BookDetails_Title_TextBox);
            this.tabPage6.Controls.Add(this.BookDetails_AvailableCopies_TextBox);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.BookDetails_Author_TextBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1311, 574);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Loan Book";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // BookDetails_Description_TextBox
            // 
            this.BookDetails_Description_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BookDetails_Description_TextBox.Location = new System.Drawing.Point(278, 18);
            this.BookDetails_Description_TextBox.Multiline = true;
            this.BookDetails_Description_TextBox.Name = "BookDetails_Description_TextBox";
            this.BookDetails_Description_TextBox.ReadOnly = true;
            this.BookDetails_Description_TextBox.Size = new System.Drawing.Size(641, 178);
            this.BookDetails_Description_TextBox.TabIndex = 19;
            // 
            // BookDetails_ISBN_TextBox
            // 
            this.BookDetails_ISBN_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BookDetails_ISBN_TextBox.Location = new System.Drawing.Point(6, 97);
            this.BookDetails_ISBN_TextBox.Name = "BookDetails_ISBN_TextBox";
            this.BookDetails_ISBN_TextBox.ReadOnly = true;
            this.BookDetails_ISBN_TextBox.Size = new System.Drawing.Size(253, 20);
            this.BookDetails_ISBN_TextBox.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Title";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "ISBN";
            // 
            // MakeLoan_Button
            // 
            this.MakeLoan_Button.Enabled = false;
            this.MakeLoan_Button.Location = new System.Drawing.Point(735, 202);
            this.MakeLoan_Button.Name = "MakeLoan_Button";
            this.MakeLoan_Button.Size = new System.Drawing.Size(184, 23);
            this.MakeLoan_Button.TabIndex = 8;
            this.MakeLoan_Button.Text = "Loan Book";
            this.MakeLoan_Button.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(275, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Description";
            // 
            // BookDetails_Title_TextBox
            // 
            this.BookDetails_Title_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BookDetails_Title_TextBox.Location = new System.Drawing.Point(6, 19);
            this.BookDetails_Title_TextBox.Name = "BookDetails_Title_TextBox";
            this.BookDetails_Title_TextBox.ReadOnly = true;
            this.BookDetails_Title_TextBox.Size = new System.Drawing.Size(253, 20);
            this.BookDetails_Title_TextBox.TabIndex = 10;
            // 
            // BookDetails_AvailableCopies_TextBox
            // 
            this.BookDetails_AvailableCopies_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BookDetails_AvailableCopies_TextBox.Location = new System.Drawing.Point(6, 136);
            this.BookDetails_AvailableCopies_TextBox.Name = "BookDetails_AvailableCopies_TextBox";
            this.BookDetails_AvailableCopies_TextBox.ReadOnly = true;
            this.BookDetails_AvailableCopies_TextBox.Size = new System.Drawing.Size(253, 20);
            this.BookDetails_AvailableCopies_TextBox.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Author";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Available copies";
            // 
            // BookDetails_Author_TextBox
            // 
            this.BookDetails_Author_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BookDetails_Author_TextBox.Location = new System.Drawing.Point(6, 58);
            this.BookDetails_Author_TextBox.Name = "BookDetails_Author_TextBox";
            this.BookDetails_Author_TextBox.ReadOnly = true;
            this.BookDetails_Author_TextBox.Size = new System.Drawing.Size(253, 20);
            this.BookDetails_Author_TextBox.TabIndex = 12;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label2);
            this.tabPage7.Controls.Add(this.button1);
            this.tabPage7.Controls.Add(this.Title_TextBox);
            this.tabPage7.Controls.Add(this.label3);
            this.tabPage7.Controls.Add(this.label4);
            this.tabPage7.Controls.Add(this.Author_ComboBox);
            this.tabPage7.Controls.Add(this.Description_TextBox);
            this.tabPage7.Controls.Add(this.label5);
            this.tabPage7.Controls.Add(this.Copies_Numeric);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1311, 574);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Add Book";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Title_TextBox
            // 
            this.Title_TextBox.Location = new System.Drawing.Point(6, 19);
            this.Title_TextBox.Name = "Title_TextBox";
            this.Title_TextBox.Size = new System.Drawing.Size(253, 20);
            this.Title_TextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Copies";
            // 
            // Author_ComboBox
            // 
            this.Author_ComboBox.FormattingEnabled = true;
            this.Author_ComboBox.Location = new System.Drawing.Point(6, 58);
            this.Author_ComboBox.Name = "Author_ComboBox";
            this.Author_ComboBox.Size = new System.Drawing.Size(253, 21);
            this.Author_ComboBox.TabIndex = 5;
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.Location = new System.Drawing.Point(278, 19);
            this.Description_TextBox.Multiline = true;
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.Size = new System.Drawing.Size(641, 177);
            this.Description_TextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description";
            // 
            // Copies_Numeric
            // 
            this.Copies_Numeric.Location = new System.Drawing.Point(6, 102);
            this.Copies_Numeric.Name = "Copies_Numeric";
            this.Copies_Numeric.Size = new System.Drawing.Size(253, 20);
            this.Copies_Numeric.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.EditISBN_TextBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.EditBook_Button);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.RemoveBook_Button);
            this.tabPage3.Controls.Add(this.EditBookTitle_TextBox);
            this.tabPage3.Controls.Add(this.EditBookCopies_Numeric);
            this.tabPage3.Controls.Add(this.EditBookAuthor_ComboBox);
            this.tabPage3.Controls.Add(this.EditBookDescription_TextBox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1311, 574);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit/Delete Book";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "ISBN";
            // 
            // EditISBN_TextBox
            // 
            this.EditISBN_TextBox.Location = new System.Drawing.Point(8, 97);
            this.EditISBN_TextBox.Name = "EditISBN_TextBox";
            this.EditISBN_TextBox.Size = new System.Drawing.Size(253, 20);
            this.EditISBN_TextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Title";
            // 
            // EditBook_Button
            // 
            this.EditBook_Button.Location = new System.Drawing.Point(773, 203);
            this.EditBook_Button.Name = "EditBook_Button";
            this.EditBook_Button.Size = new System.Drawing.Size(145, 23);
            this.EditBook_Button.TabIndex = 17;
            this.EditBook_Button.Text = "Update book";
            this.EditBook_Button.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Author";
            // 
            // RemoveBook_Button
            // 
            this.RemoveBook_Button.BackColor = System.Drawing.Color.Transparent;
            this.RemoveBook_Button.Location = new System.Drawing.Point(622, 203);
            this.RemoveBook_Button.Name = "RemoveBook_Button";
            this.RemoveBook_Button.Size = new System.Drawing.Size(145, 23);
            this.RemoveBook_Button.TabIndex = 16;
            this.RemoveBook_Button.Text = "Delete book";
            this.RemoveBook_Button.UseVisualStyleBackColor = false;
            // 
            // EditBookTitle_TextBox
            // 
            this.EditBookTitle_TextBox.Location = new System.Drawing.Point(8, 18);
            this.EditBookTitle_TextBox.Name = "EditBookTitle_TextBox";
            this.EditBookTitle_TextBox.Size = new System.Drawing.Size(253, 20);
            this.EditBookTitle_TextBox.TabIndex = 9;
            // 
            // EditBookCopies_Numeric
            // 
            this.EditBookCopies_Numeric.Location = new System.Drawing.Point(7, 136);
            this.EditBookCopies_Numeric.Name = "EditBookCopies_Numeric";
            this.EditBookCopies_Numeric.Size = new System.Drawing.Size(253, 20);
            this.EditBookCopies_Numeric.TabIndex = 15;
            // 
            // EditBookAuthor_ComboBox
            // 
            this.EditBookAuthor_ComboBox.FormattingEnabled = true;
            this.EditBookAuthor_ComboBox.Location = new System.Drawing.Point(8, 57);
            this.EditBookAuthor_ComboBox.Name = "EditBookAuthor_ComboBox";
            this.EditBookAuthor_ComboBox.Size = new System.Drawing.Size(252, 21);
            this.EditBookAuthor_ComboBox.TabIndex = 14;
            // 
            // EditBookDescription_TextBox
            // 
            this.EditBookDescription_TextBox.Location = new System.Drawing.Point(277, 16);
            this.EditBookDescription_TextBox.Multiline = true;
            this.EditBookDescription_TextBox.Name = "EditBookDescription_TextBox";
            this.EditBookDescription_TextBox.Size = new System.Drawing.Size(641, 181);
            this.EditBookDescription_TextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Copies";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Description";
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
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Copies_Numeric)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditBookCopies_Numeric)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox BookDetails_Description_TextBox;
        private System.Windows.Forms.TextBox BookDetails_ISBN_TextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button MakeLoan_Button;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox BookDetails_Title_TextBox;
        private System.Windows.Forms.TextBox BookDetails_AvailableCopies_TextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox BookDetails_Author_TextBox;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Title_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Author_ComboBox;
        private System.Windows.Forms.TextBox Description_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Copies_Numeric;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EditISBN_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditBook_Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RemoveBook_Button;
        private System.Windows.Forms.TextBox EditBookTitle_TextBox;
        private System.Windows.Forms.NumericUpDown EditBookCopies_Numeric;
        private System.Windows.Forms.ComboBox EditBookAuthor_ComboBox;
        private System.Windows.Forms.TextBox EditBookDescription_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}
    