using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryForm : Form
    {
        BookService _bookService;
        AuthorService _authorService;
        BookCopyService _bookCopyService;
        MemberService _memberService;
        LoanService _loanService;


        public LibraryForm()
        {
            InitializeComponent();

            LibraryContext context = new LibraryContext();

            RepositoryFactory repoFactory = new RepositoryFactory(context);

            _bookService = new BookService(repoFactory);
            _authorService = new AuthorService(repoFactory);
            _bookCopyService = new BookCopyService(repoFactory);
            _memberService = new MemberService(repoFactory);
            _loanService = new LoanService(repoFactory);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AddBookDescription_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBookISBN_label_Click(object sender, EventArgs e)
        {

        }

        private void AddBookDescription_label_Click(object sender, EventArgs e)
        {

        }

        private void AddBook_label_Click(object sender, EventArgs e)
        {

        }

        private void AddBookTitle_label_Click(object sender, EventArgs e)
        {

        }

        private void AddBookTitle_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBookAuthor_label_Click(object sender, EventArgs e)
        {

        }

        private void AddBookCopies_Label_Click(object sender, EventArgs e)
        {

        }

        private void AddBookAuthor_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBookNumberOfCopies_drop_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
