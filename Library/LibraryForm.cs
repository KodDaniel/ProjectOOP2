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
            RepositoryFactory repoFactory = new RepositoryFactory(ContextSingelton.GetContext());          

            _bookService = new BookService(repoFactory);
            _authorService = new AuthorService(repoFactory);
            _bookCopyService = new BookCopyService(repoFactory);
            _memberService = new MemberService(repoFactory);
            _loanService = new LoanService(repoFactory);

            // Event subsciptions
            _bookService.Updated += OnUpdateListAllBooks;
            _authorService.Updated += OnUpdateFillComboBoxes;

            // Fyller Combos
            FillComboBoxes();

           


       
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

        private void ListAllBooks_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void FillComboBoxes()
        {
            AddBookAuthor_ComboBox.Items.Clear();

            foreach (Author author in _authorService.AllAuthors())
            {
               AddBookAuthor_ComboBox.Items.Add(author);         
            }
        }

        // Buttons
        private void AddBook_Button_Click(object sender, EventArgs e)
        {
            // Skapar lista för smidig validering
            List<string> validationList = new List<string>
            {
                AddBookISBN_textbox.Text,
                AddBookTitle_TextBox.Text,
                AddBookDescription_TextBox.Text,
            };

            if (CheckInput(validationList) && AddBookAuthor_ComboBox.SelectedItem != null)
            {
                Book book = new Book()
                {
                    Isbn = AddBookISBN_textbox.Text,
                    Title = AddBookTitle_TextBox.Text,
                    Description = AddBookDescription_TextBox.Text,
                    // Casting
                    Author = (Author)AddBookAuthor_ComboBox.SelectedItem,
                    BookCopies = (int)AddBookNumberOfCopies_drop.Value
                };

                _bookService.AddBook(book);

                for (int i = 0; i < book.BookCopies; i++)
                {
                    BookCopy bookCopy = new BookCopy()
                    {
                        Book = book
                    };

                    _bookCopyService.AddBookCopy(bookCopy);
                }

                AddBookISBN_textbox.Clear();
                AddBookTitle_TextBox.Clear();
                AddBookDescription_TextBox.Clear();
                AddBookAuthor_ComboBox.Text = "";
            }
   
        }

        private void AddAuthor_Btn_Click(object sender, EventArgs e)
        {
            var name = AddAuthorName_textbox.Text;

            if (CheckInput(name))
            {
                Author author = new Author();
                _authorService.AddAuthor(author);
                AddAuthorName_textbox.Clear();
            }
            
        }

        private void ListAllBooks_Btn_Click(object sender, EventArgs e)
        {
             ListAllBooks_listBox.Items.Clear();

            var allBooks = _bookService.All();

            foreach (var book in allBooks)
            {
                ListAllBooks_listBox.Items.Add("Titel: " + book.Title + ". Kopior: " +book.BookCopies +".");          
            }
        }
   
        // Event Recivers
        void OnUpdateListAllBooks(object source, EventArgs args)
        {
            ListAllBooks_Btn_Click(source, args);
        }
        void OnUpdateFillComboBoxes(object source, EventArgs args)
        {
            FillComboBoxes();
        }

        // Validering
        bool CheckInput(List<string> input)
        {
            foreach (string text in input)
            {
                if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show(@"Du måste fylla i alla fält.", @"Ogitlig input.");
                    return false;
                }
            }
            return true;
        }

       // Overlodar CheckInput
        bool CheckInput(string input)
        {
            List<string> list = new List<string>()
            {
                input
            };
            return CheckInput(list);
        }


    }
}
