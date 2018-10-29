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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.Member_ComboBox = new System.Windows.Forms.ComboBox();
            this.ListAllBooks_btn = new System.Windows.Forms.Button();
            this.SaveBook_Btn = new System.Windows.Forms.Button();
            this.DeleteBook_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBookByAuthor_Btn = new System.Windows.Forms.Button();
            this.SearchBookByAuthor_combobox = new System.Windows.Forms.ComboBox();
            this.LoanBook_Btn = new System.Windows.Forms.Button();
            this.BookGrid = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddAuthor_label = new System.Windows.Forms.Label();
            this.AddAuthorName_label = new System.Windows.Forms.Label();
            this.AddAuthorName_textbox = new System.Windows.Forms.TextBox();
            this.AddBookISBN_textbox = new System.Windows.Forms.TextBox();
            this.AddBookDescription_TextBox = new System.Windows.Forms.TextBox();
            this.AddBookTitle_TextBox = new System.Windows.Forms.TextBox();
            this.AddAuthor_Btn = new System.Windows.Forms.Button();
            this.AddBook_Button = new System.Windows.Forms.Button();
            this.AddBookISBN_label = new System.Windows.Forms.Label();
            this.AddBookDescription_label = new System.Windows.Forms.Label();
            this.AddBook_label = new System.Windows.Forms.Label();
            this.AddBookTitle_label = new System.Windows.Forms.Label();
            this.AddBookAuthor_label = new System.Windows.Forms.Label();
            this.AddBookCopies_Label = new System.Windows.Forms.Label();
            this.AddBookAuthor_ComboBox = new System.Windows.Forms.ComboBox();
            this.AddBookNumberOfCopies_drop = new System.Windows.Forms.NumericUpDown();
            this.MemberAndLoanTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ReturnBook_Btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LoanGrid = new System.Windows.Forms.DataGridView();
            this.IDLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FineLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllMembers_listbox = new System.Windows.Forms.ListBox();
            this.DeleteMember_Btn = new System.Windows.Forms.Button();
            this.AddMember_Btn = new System.Windows.Forms.Button();
            this.Member_Name_textbox = new System.Windows.Forms.TextBox();
            this.Member_Id_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOfLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBookNumberOfCopies_drop)).BeginInit();
            this.MemberAndLoanTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.Member_ComboBox);
            this.tabPage1.Controls.Add(this.ListAllBooks_btn);
            this.tabPage1.Controls.Add(this.SaveBook_Btn);
            this.tabPage1.Controls.Add(this.DeleteBook_btn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SearchBookByAuthor_Btn);
            this.tabPage1.Controls.Add(this.SearchBookByAuthor_combobox);
            this.tabPage1.Controls.Add(this.LoanBook_Btn);
            this.tabPage1.Controls.Add(this.BookGrid);
            this.tabPage1.Controls.Add(this.AddAuthor_label);
            this.tabPage1.Controls.Add(this.AddAuthorName_label);
            this.tabPage1.Controls.Add(this.AddAuthorName_textbox);
            this.tabPage1.Controls.Add(this.AddBookISBN_textbox);
            this.tabPage1.Controls.Add(this.AddBookDescription_TextBox);
            this.tabPage1.Controls.Add(this.AddBookTitle_TextBox);
            this.tabPage1.Controls.Add(this.AddAuthor_Btn);
            this.tabPage1.Controls.Add(this.AddBook_Button);
            this.tabPage1.Controls.Add(this.AddBookISBN_label);
            this.tabPage1.Controls.Add(this.AddBookDescription_label);
            this.tabPage1.Controls.Add(this.AddBook_label);
            this.tabPage1.Controls.Add(this.AddBookTitle_label);
            this.tabPage1.Controls.Add(this.AddBookAuthor_label);
            this.tabPage1.Controls.Add(this.AddBookCopies_Label);
            this.tabPage1.Controls.Add(this.AddBookAuthor_ComboBox);
            this.tabPage1.Controls.Add(this.AddBookNumberOfCopies_drop);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1326, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1028, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 419;
            this.label12.Text = "Select Member";
            // 
            // Member_ComboBox
            // 
            this.Member_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Member_ComboBox.Location = new System.Drawing.Point(1031, 37);
            this.Member_ComboBox.Name = "Member_ComboBox";
            this.Member_ComboBox.Size = new System.Drawing.Size(164, 21);
            this.Member_ComboBox.TabIndex = 418;
            this.Member_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Member_ComboBox_SelectedIndexChanged);
            // 
            // ListAllBooks_btn
            // 
            this.ListAllBooks_btn.Location = new System.Drawing.Point(874, 529);
            this.ListAllBooks_btn.Name = "ListAllBooks_btn";
            this.ListAllBooks_btn.Size = new System.Drawing.Size(250, 25);
            this.ListAllBooks_btn.TabIndex = 46;
            this.ListAllBooks_btn.Text = "List all books";
            this.ListAllBooks_btn.UseVisualStyleBackColor = true;
            this.ListAllBooks_btn.Click += new System.EventHandler(this.ListAllBooks_btn_Click);
            // 
            // SaveBook_Btn
            // 
            this.SaveBook_Btn.Location = new System.Drawing.Point(24, 464);
            this.SaveBook_Btn.Name = "SaveBook_Btn";
            this.SaveBook_Btn.Size = new System.Drawing.Size(250, 25);
            this.SaveBook_Btn.TabIndex = 45;
            this.SaveBook_Btn.Text = "Save book";
            this.SaveBook_Btn.UseVisualStyleBackColor = true;
            this.SaveBook_Btn.Click += new System.EventHandler(this.SaveBook_Btn_Click);
            // 
            // DeleteBook_btn
            // 
            this.DeleteBook_btn.Location = new System.Drawing.Point(598, 529);
            this.DeleteBook_btn.Name = "DeleteBook_btn";
            this.DeleteBook_btn.Size = new System.Drawing.Size(250, 25);
            this.DeleteBook_btn.TabIndex = 44;
            this.DeleteBook_btn.Text = "Delete book";
            this.DeleteBook_btn.UseVisualStyleBackColor = true;
            this.DeleteBook_btn.Click += new System.EventHandler(this.DeleteBook_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Search book by author";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchBookByAuthor_Btn
            // 
            this.SearchBookByAuthor_Btn.Location = new System.Drawing.Point(598, 129);
            this.SearchBookByAuthor_Btn.Name = "SearchBookByAuthor_Btn";
            this.SearchBookByAuthor_Btn.Size = new System.Drawing.Size(250, 25);
            this.SearchBookByAuthor_Btn.TabIndex = 41;
            this.SearchBookByAuthor_Btn.Text = "Search";
            this.SearchBookByAuthor_Btn.UseVisualStyleBackColor = true;
            this.SearchBookByAuthor_Btn.Click += new System.EventHandler(this.SearchBookByAuthor_Btn_Click);
            // 
            // SearchBookByAuthor_combobox
            // 
            this.SearchBookByAuthor_combobox.FormattingEnabled = true;
            this.SearchBookByAuthor_combobox.Location = new System.Drawing.Point(598, 89);
            this.SearchBookByAuthor_combobox.Name = "SearchBookByAuthor_combobox";
            this.SearchBookByAuthor_combobox.Size = new System.Drawing.Size(253, 21);
            this.SearchBookByAuthor_combobox.TabIndex = 40;
            // 
            // LoanBook_Btn
            // 
            this.LoanBook_Btn.Location = new System.Drawing.Point(323, 529);
            this.LoanBook_Btn.Name = "LoanBook_Btn";
            this.LoanBook_Btn.Size = new System.Drawing.Size(250, 25);
            this.LoanBook_Btn.TabIndex = 39;
            this.LoanBook_Btn.Text = "Loan Book";
            this.LoanBook_Btn.UseVisualStyleBackColor = true;
            this.LoanBook_Btn.Click += new System.EventHandler(this.LoanBook_Btn_Click);
            // 
            // BookGrid
            // 
            this.BookGrid.AllowUserToAddRows = false;
            this.BookGrid.AllowUserToDeleteRows = false;
            this.BookGrid.AllowUserToResizeRows = false;
            this.BookGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Description,
            this.Author,
            this.Copies,
            this.AvailableCopies,
            this.ISBN,
            this.ID});
            this.BookGrid.Location = new System.Drawing.Point(323, 192);
            this.BookGrid.MultiSelect = false;
            this.BookGrid.Name = "BookGrid";
            this.BookGrid.ReadOnly = true;
            this.BookGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookGrid.Size = new System.Drawing.Size(881, 297);
            this.BookGrid.TabIndex = 38;
            this.BookGrid.TabStop = false;
            this.BookGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewAll_CellClick);
            this.BookGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookGrid_CellContentClick);
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Copies
            // 
            this.Copies.HeaderText = "Copies";
            this.Copies.Name = "Copies";
            this.Copies.ReadOnly = true;
            // 
            // AvailableCopies
            // 
            this.AvailableCopies.HeaderText = "Available Copies";
            this.AvailableCopies.Name = "AvailableCopies";
            this.AvailableCopies.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // AddAuthor_label
            // 
            this.AddAuthor_label.AutoSize = true;
            this.AddAuthor_label.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAuthor_label.Location = new System.Drawing.Point(360, 53);
            this.AddAuthor_label.Name = "AddAuthor_label";
            this.AddAuthor_label.Size = new System.Drawing.Size(111, 24);
            this.AddAuthor_label.TabIndex = 37;
            this.AddAuthor_label.Text = "Add author";
            // 
            // AddAuthorName_label
            // 
            this.AddAuthorName_label.AutoSize = true;
            this.AddAuthorName_label.Location = new System.Drawing.Point(310, 73);
            this.AddAuthorName_label.Name = "AddAuthorName_label";
            this.AddAuthorName_label.Size = new System.Drawing.Size(35, 13);
            this.AddAuthorName_label.TabIndex = 36;
            this.AddAuthorName_label.Text = "Name";
            // 
            // AddAuthorName_textbox
            // 
            this.AddAuthorName_textbox.Location = new System.Drawing.Point(313, 89);
            this.AddAuthorName_textbox.Name = "AddAuthorName_textbox";
            this.AddAuthorName_textbox.Size = new System.Drawing.Size(253, 20);
            this.AddAuthorName_textbox.TabIndex = 35;
            // 
            // AddBookISBN_textbox
            // 
            this.AddBookISBN_textbox.Location = new System.Drawing.Point(21, 84);
            this.AddBookISBN_textbox.Name = "AddBookISBN_textbox";
            this.AddBookISBN_textbox.Size = new System.Drawing.Size(253, 20);
            this.AddBookISBN_textbox.TabIndex = 28;
            this.AddBookISBN_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddBookDescription_TextBox
            // 
            this.AddBookDescription_TextBox.Location = new System.Drawing.Point(21, 226);
            this.AddBookDescription_TextBox.Multiline = true;
            this.AddBookDescription_TextBox.Name = "AddBookDescription_TextBox";
            this.AddBookDescription_TextBox.Size = new System.Drawing.Size(253, 141);
            this.AddBookDescription_TextBox.TabIndex = 26;
            this.AddBookDescription_TextBox.TextChanged += new System.EventHandler(this.AddBookDescription_TextBox_TextChanged);
            // 
            // AddBookTitle_TextBox
            // 
            this.AddBookTitle_TextBox.Location = new System.Drawing.Point(21, 133);
            this.AddBookTitle_TextBox.Name = "AddBookTitle_TextBox";
            this.AddBookTitle_TextBox.Size = new System.Drawing.Size(253, 20);
            this.AddBookTitle_TextBox.TabIndex = 19;
            this.AddBookTitle_TextBox.TextChanged += new System.EventHandler(this.AddBookTitle_TextBox_TextChanged);
            // 
            // AddAuthor_Btn
            // 
            this.AddAuthor_Btn.Location = new System.Drawing.Point(313, 126);
            this.AddAuthor_Btn.Name = "AddAuthor_Btn";
            this.AddAuthor_Btn.Size = new System.Drawing.Size(250, 25);
            this.AddAuthor_Btn.TabIndex = 34;
            this.AddAuthor_Btn.Text = "Add author";
            this.AddAuthor_Btn.UseVisualStyleBackColor = true;
            this.AddAuthor_Btn.Click += new System.EventHandler(this.AddAuthor_Btn_Click);
            // 
            // AddBook_Button
            // 
            this.AddBook_Button.Location = new System.Drawing.Point(24, 433);
            this.AddBook_Button.Name = "AddBook_Button";
            this.AddBook_Button.Size = new System.Drawing.Size(250, 25);
            this.AddBook_Button.TabIndex = 33;
            this.AddBook_Button.Text = "Add book";
            this.AddBook_Button.UseVisualStyleBackColor = true;
            this.AddBook_Button.Click += new System.EventHandler(this.AddBook_Button_Click);
            // 
            // AddBookISBN_label
            // 
            this.AddBookISBN_label.AutoSize = true;
            this.AddBookISBN_label.Location = new System.Drawing.Point(21, 68);
            this.AddBookISBN_label.Name = "AddBookISBN_label";
            this.AddBookISBN_label.Size = new System.Drawing.Size(32, 13);
            this.AddBookISBN_label.TabIndex = 29;
            this.AddBookISBN_label.Text = "ISBN";
            this.AddBookISBN_label.Click += new System.EventHandler(this.AddBookISBN_label_Click);
            // 
            // AddBookDescription_label
            // 
            this.AddBookDescription_label.AutoSize = true;
            this.AddBookDescription_label.Location = new System.Drawing.Point(21, 210);
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
            this.AddBook_label.Size = new System.Drawing.Size(199, 24);
            this.AddBook_label.TabIndex = 25;
            this.AddBook_label.Text = "Book Administration";
            this.AddBook_label.Click += new System.EventHandler(this.AddBook_label_Click);
            // 
            // AddBookTitle_label
            // 
            this.AddBookTitle_label.AutoSize = true;
            this.AddBookTitle_label.Location = new System.Drawing.Point(21, 117);
            this.AddBookTitle_label.Name = "AddBookTitle_label";
            this.AddBookTitle_label.Size = new System.Drawing.Size(27, 13);
            this.AddBookTitle_label.TabIndex = 20;
            this.AddBookTitle_label.Text = "Title";
            this.AddBookTitle_label.Click += new System.EventHandler(this.AddBookTitle_label_Click);
            // 
            // AddBookAuthor_label
            // 
            this.AddBookAuthor_label.AutoSize = true;
            this.AddBookAuthor_label.Location = new System.Drawing.Point(21, 156);
            this.AddBookAuthor_label.Name = "AddBookAuthor_label";
            this.AddBookAuthor_label.Size = new System.Drawing.Size(38, 13);
            this.AddBookAuthor_label.TabIndex = 21;
            this.AddBookAuthor_label.Text = "Author";
            this.AddBookAuthor_label.Click += new System.EventHandler(this.AddBookAuthor_label_Click);
            // 
            // AddBookCopies_Label
            // 
            this.AddBookCopies_Label.AutoSize = true;
            this.AddBookCopies_Label.Location = new System.Drawing.Point(21, 380);
            this.AddBookCopies_Label.Name = "AddBookCopies_Label";
            this.AddBookCopies_Label.Size = new System.Drawing.Size(39, 13);
            this.AddBookCopies_Label.TabIndex = 24;
            this.AddBookCopies_Label.Text = "Copies";
            this.AddBookCopies_Label.Click += new System.EventHandler(this.AddBookCopies_Label_Click);
            // 
            // AddBookAuthor_ComboBox
            // 
            this.AddBookAuthor_ComboBox.FormattingEnabled = true;
            this.AddBookAuthor_ComboBox.Location = new System.Drawing.Point(21, 172);
            this.AddBookAuthor_ComboBox.Name = "AddBookAuthor_ComboBox";
            this.AddBookAuthor_ComboBox.Size = new System.Drawing.Size(253, 21);
            this.AddBookAuthor_ComboBox.TabIndex = 22;
            this.AddBookAuthor_ComboBox.SelectedIndexChanged += new System.EventHandler(this.AddBookAuthor_ComboBox_SelectedIndexChanged);
            // 
            // AddBookNumberOfCopies_drop
            // 
            this.AddBookNumberOfCopies_drop.Location = new System.Drawing.Point(21, 396);
            this.AddBookNumberOfCopies_drop.Name = "AddBookNumberOfCopies_drop";
            this.AddBookNumberOfCopies_drop.Size = new System.Drawing.Size(253, 20);
            this.AddBookNumberOfCopies_drop.TabIndex = 23;
            this.AddBookNumberOfCopies_drop.ValueChanged += new System.EventHandler(this.AddBookNumberOfCopies_drop_ValueChanged);
            // 
            // MemberAndLoanTab
            // 
            this.MemberAndLoanTab.Controls.Add(this.tabPage1);
            this.MemberAndLoanTab.Controls.Add(this.tabPage2);
            this.MemberAndLoanTab.Location = new System.Drawing.Point(0, 11);
            this.MemberAndLoanTab.Name = "MemberAndLoanTab";
            this.MemberAndLoanTab.SelectedIndex = 0;
            this.MemberAndLoanTab.Size = new System.Drawing.Size(1334, 625);
            this.MemberAndLoanTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.ReturnBook_Btn);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.LoanGrid);
            this.tabPage2.Controls.Add(this.AllMembers_listbox);
            this.tabPage2.Controls.Add(this.DeleteMember_Btn);
            this.tabPage2.Controls.Add(this.AddMember_Btn);
            this.tabPage2.Controls.Add(this.Member_Name_textbox);
            this.tabPage2.Controls.Add(this.Member_Id_textbox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1326, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Member and Loans";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click_1);
            // 
            // ReturnBook_Btn
            // 
            this.ReturnBook_Btn.Location = new System.Drawing.Point(674, 550);
            this.ReturnBook_Btn.Name = "ReturnBook_Btn";
            this.ReturnBook_Btn.Size = new System.Drawing.Size(250, 25);
            this.ReturnBook_Btn.TabIndex = 442;
            this.ReturnBook_Btn.Text = "Return Book";
            this.ReturnBook_Btn.UseVisualStyleBackColor = true;
            this.ReturnBook_Btn.Click += new System.EventHandler(this.ReturnBook_Btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(989, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 24);
            this.label10.TabIndex = 441;
            this.label10.Text = "All Members";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(990, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 440;
            this.label9.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(993, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 439;
            this.label8.Text = "Personal ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(999, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 24);
            this.label7.TabIndex = 438;
            this.label7.Text = "Member Administration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 24);
            this.label6.TabIndex = 437;
            this.label6.Text = "Loan Administration";
            // 
            // LoanGrid
            // 
            this.LoanGrid.AllowUserToAddRows = false;
            this.LoanGrid.AllowUserToDeleteRows = false;
            this.LoanGrid.AllowUserToResizeRows = false;
            this.LoanGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LoanGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LoanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLoan,
            this.TitleLoan,
            this.AuthorLoan,
            this.LoanTime,
            this.DateDue,
            this.DateReturn,
            this.FineLoan});
            this.LoanGrid.Location = new System.Drawing.Point(20, 84);
            this.LoanGrid.MultiSelect = false;
            this.LoanGrid.Name = "LoanGrid";
            this.LoanGrid.ReadOnly = true;
            this.LoanGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LoanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LoanGrid.Size = new System.Drawing.Size(904, 451);
            this.LoanGrid.TabIndex = 436;
            this.LoanGrid.TabStop = false;
            // 
            // IDLoan
            // 
            this.IDLoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDLoan.HeaderText = "ID";
            this.IDLoan.Name = "IDLoan";
            this.IDLoan.ReadOnly = true;
            // 
            // TitleLoan
            // 
            this.TitleLoan.HeaderText = "Title";
            this.TitleLoan.Name = "TitleLoan";
            this.TitleLoan.ReadOnly = true;
            // 
            // AuthorLoan
            // 
            this.AuthorLoan.HeaderText = "Author";
            this.AuthorLoan.Name = "AuthorLoan";
            this.AuthorLoan.ReadOnly = true;
            // 
            // LoanTime
            // 
            this.LoanTime.HeaderText = "TimeOfLoan";
            this.LoanTime.Name = "LoanTime";
            this.LoanTime.ReadOnly = true;
            // 
            // DateDue
            // 
            this.DateDue.HeaderText = "Due Date";
            this.DateDue.Name = "DateDue";
            this.DateDue.ReadOnly = true;
            // 
            // DateReturn
            // 
            this.DateReturn.HeaderText = "Return Date";
            this.DateReturn.Name = "DateReturn";
            this.DateReturn.ReadOnly = true;
            // 
            // FineLoan
            // 
            this.FineLoan.HeaderText = "Fine";
            this.FineLoan.Name = "FineLoan";
            this.FineLoan.ReadOnly = true;
            // 
            // AllMembers_listbox
            // 
            this.AllMembers_listbox.FormattingEnabled = true;
            this.AllMembers_listbox.Location = new System.Drawing.Point(990, 240);
            this.AllMembers_listbox.Name = "AllMembers_listbox";
            this.AllMembers_listbox.Size = new System.Drawing.Size(253, 277);
            this.AllMembers_listbox.TabIndex = 434;
            // 
            // DeleteMember_Btn
            // 
            this.DeleteMember_Btn.Location = new System.Drawing.Point(990, 539);
            this.DeleteMember_Btn.Name = "DeleteMember_Btn";
            this.DeleteMember_Btn.Size = new System.Drawing.Size(250, 25);
            this.DeleteMember_Btn.TabIndex = 433;
            this.DeleteMember_Btn.Text = "Delete Member";
            this.DeleteMember_Btn.UseVisualStyleBackColor = true;
            this.DeleteMember_Btn.Click += new System.EventHandler(this.DeleteMember_Btn_Click);
            // 
            // AddMember_Btn
            // 
            this.AddMember_Btn.Location = new System.Drawing.Point(993, 179);
            this.AddMember_Btn.Name = "AddMember_Btn";
            this.AddMember_Btn.Size = new System.Drawing.Size(250, 25);
            this.AddMember_Btn.TabIndex = 432;
            this.AddMember_Btn.Text = "Add member";
            this.AddMember_Btn.UseVisualStyleBackColor = true;
            this.AddMember_Btn.Click += new System.EventHandler(this.AddMember_Btn_Click);
            // 
            // Member_Name_textbox
            // 
            this.Member_Name_textbox.Location = new System.Drawing.Point(993, 110);
            this.Member_Name_textbox.Name = "Member_Name_textbox";
            this.Member_Name_textbox.Size = new System.Drawing.Size(253, 20);
            this.Member_Name_textbox.TabIndex = 430;
            // 
            // Member_Id_textbox
            // 
            this.Member_Id_textbox.Location = new System.Drawing.Point(993, 153);
            this.Member_Id_textbox.Name = "Member_Id_textbox";
            this.Member_Id_textbox.Size = new System.Drawing.Size(253, 20);
            this.Member_Id_textbox.TabIndex = 427;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(993, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 431;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(989, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 429;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(993, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 428;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 40;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // TimeOfLoan
            // 
            this.TimeOfLoan.HeaderText = "Time of loan";
            this.TimeOfLoan.Name = "TimeOfLoan";
            this.TimeOfLoan.ReadOnly = true;
            // 
            // LoanAuthor
            // 
            this.LoanAuthor.HeaderText = "Author";
            this.LoanAuthor.Name = "LoanAuthor";
            this.LoanAuthor.ReadOnly = true;
            // 
            // LoanTitle
            // 
            this.LoanTitle.HeaderText = "Title";
            this.LoanTitle.Name = "LoanTitle";
            this.LoanTitle.ReadOnly = true;
            // 
            // LoanId
            // 
            this.LoanId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoanId.HeaderText = "ID";
            this.LoanId.Name = "LoanId";
            this.LoanId.ReadOnly = true;
            // 
            // LibraryForm
            // 
            this.ClientSize = new System.Drawing.Size(1330, 639);
            this.Controls.Add(this.MemberAndLoanTab);
            this.Name = "LibraryForm";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBookNumberOfCopies_drop)).EndInit();
            this.MemberAndLoanTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanGrid)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView BookGrid;
        private System.Windows.Forms.Label AddAuthor_label;
        private System.Windows.Forms.Label AddAuthorName_label;
        private System.Windows.Forms.TextBox AddAuthorName_textbox;
        private System.Windows.Forms.TextBox AddBookISBN_textbox;
        private System.Windows.Forms.TextBox AddBookDescription_TextBox;
        private System.Windows.Forms.TextBox AddBookTitle_TextBox;
        private System.Windows.Forms.Button AddAuthor_Btn;
        private System.Windows.Forms.Button AddBook_Button;
        private System.Windows.Forms.Label AddBookISBN_label;
        private System.Windows.Forms.Label AddBookDescription_label;
        private System.Windows.Forms.Label AddBook_label;
        private System.Windows.Forms.Label AddBookTitle_label;
        private System.Windows.Forms.Label AddBookAuthor_label;
        private System.Windows.Forms.Label AddBookCopies_Label;
        private System.Windows.Forms.ComboBox AddBookAuthor_ComboBox;
        private System.Windows.Forms.NumericUpDown AddBookNumberOfCopies_drop;
        private System.Windows.Forms.TabControl MemberAndLoanTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBookByAuthor_Btn;
        private System.Windows.Forms.ComboBox SearchBookByAuthor_combobox;
        private System.Windows.Forms.Button LoanBook_Btn;
        private System.Windows.Forms.Button DeleteBook_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copies;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button SaveBook_Btn;
        private System.Windows.Forms.Button ListAllBooks_btn;
        private System.Windows.Forms.ComboBox Member_ComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox AllMembers_listbox;
        private System.Windows.Forms.Button DeleteMember_Btn;
        private System.Windows.Forms.Button AddMember_Btn;
        private System.Windows.Forms.TextBox Member_Name_textbox;
        private System.Windows.Forms.TextBox Member_Id_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOfLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView LoanGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ReturnBook_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineLoan;
    }
}
    