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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddBookISBN_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddBookDescription_TextBox = new System.Windows.Forms.TextBox();
            this.AddBookDescription_label = new System.Windows.Forms.Label();
            this.AddBook_label = new System.Windows.Forms.Label();
            this.AddBookTitle_label = new System.Windows.Forms.Label();
            this.AddBookTitle_TextBox = new System.Windows.Forms.TextBox();
            this.AddBookAuthor_label = new System.Windows.Forms.Label();
            this.AddBookCopies_Label = new System.Windows.Forms.Label();
            this.AddBookAuthor_ComboBox = new System.Windows.Forms.ComboBox();
            this.AddBookNumberOfCopies_drop = new System.Windows.Forms.NumericUpDown();
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
            this.tabControl1.Size = new System.Drawing.Size(985, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.AddBookISBN_label);
            this.tabPage1.Controls.Add(this.textBox1);
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
            this.tabPage1.Size = new System.Drawing.Size(977, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // LibraryForm
            // 
            this.ClientSize = new System.Drawing.Size(1010, 585);
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
        private System.Windows.Forms.TextBox textBox1;
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
    }
}
    