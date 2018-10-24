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
        

        private  IEnumerable<Book> ListAllBooks()
        {
            return _bookService.All();
        }

        private void ListAllBooks_Btn_Click(object sender, EventArgs e)
        {
            var allBooks = ListAllBooks();
            ListAllBooks_listbox.Items.Clear();

            foreach (var book in allBooks)
            {
                ListAllBooks_listbox.Items.Add(book); 
            }
        }

        private void BTNChangeBook_Click(object sender, EventArgs e)
        {
            Book b = lbBooks.SelectedItem as Book;
            if (b != null)
            {
                b.Title = "Yoyoma";
                _bookService.Edit(b);
            }
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SearchBookByAuthor_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListAllBooks_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
