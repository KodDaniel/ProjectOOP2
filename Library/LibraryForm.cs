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
            _bookService.Updated += OnUpdateFillComboBoxes;
            _authorService.Updated += OnUpdateFillComboBoxes;

            // Fyller Combos
            FillComboBoxes();          
        }
    

        //Returns the book currently selected in the gridview
        private Book GetSelectedBook()
        {
            if (GridViewAll.SelectedRows[0].Cells["Id"] != null)
            {
                int id = (int)GridViewAll.SelectedRows[0].Cells["Id"].Value;
                return _bookService.FindBook(id);
            }

            return null;

        }

        void DisplayBooks(IEnumerable<Book> books)
        {
            GridViewAll.Rows.Clear();

            int index = 0;

            foreach (Book book in books)
            {
                GridViewAll.Rows.Add();
                GridViewAll["Title", index].Value = book.Title;
                GridViewAll["Description", index].Value = book.Description;
                GridViewAll["Author", index].Value = book.Author.Name;
                GridViewAll["Copies", index].Value = _bookCopyService.GetNumberOfCopiesByBookId(book.Id);
                //GridViewAll["AvailableCopies", index].Value = Copies- _loanService.GetNumberOfCurrentLoansByBook(book);
                GridViewAll["ISBN", index].Value = book.Isbn;
                GridViewAll["ID", index].Value = book.Id;

                index++;
            }
        }

        private void GridViewAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var book = GetSelectedBook();
            
            AddBookISBN_textbox.Text = book.Isbn;
            AddBookTitle_TextBox.Text = book.Title;
            AddBookAuthor_ComboBox.SelectedItem = book.Author;
            AddBookDescription_TextBox.Text = book.Description;
            AddBookNumberOfCopies_drop.Value = book.BookCopies;
        }

        void FillComboBoxes()
        {
            DisplayBooks(_bookService.All());
        
            AddBookAuthor_ComboBox.Items.Clear();

            foreach (Author author in _authorService.AllAuthors())
            {
               AddBookAuthor_ComboBox.Items.Add(author);         
            }

           SearchBookByAuthor_combobox.Items.Clear();

            foreach (Author author in _authorService.AllAuthors())
            {
                SearchBookByAuthor_combobox.Items.Add(author);
            }
           
        }



        // Buttons
        #region Buttons

        private void SearchBookByAuthor_Btn_Click(object sender, EventArgs e)
        {
            if (SearchBookByAuthor_combobox.SelectedItem != null)
            {
                var booksByThisAuthor = _bookService.AllBooksByAuthor((Author)SearchBookByAuthor_combobox.SelectedItem);
                DisplayBooks(booksByThisAuthor);
            }
        }
        private void ListAllBooks_btn_Click(object sender, EventArgs e)
        {
            FillComboBoxes();
        }
        private void SaveBook_Btn_Click(object sender, EventArgs e)
        {
             List<string> validationList = new List<string>
            {
                AddBookISBN_textbox.Text,
                AddBookTitle_TextBox.Text,
                AddBookDescription_TextBox.Text,
            };

            var newIsbn = AddBookISBN_textbox.Text;
            var newTitle = AddBookTitle_TextBox.Text;
            var newAuthor = AddBookAuthor_ComboBox.SelectedItem;
            var newDescription = AddBookDescription_TextBox.Text;
            var newNumberOfCopies = AddBookNumberOfCopies_drop.Value;
            int id = (int)GridViewAll.SelectedRows[0].Cells["Id"].Value;

            if (CheckInput(validationList) && AddBookAuthor_ComboBox.SelectedItem != null)
            {
                Book book = new Book()
                {
                    Id = id,
                    Isbn = newIsbn,
                    Title = newTitle,
                    Description = newDescription,
                    // Casting
                    Author = (Author)newAuthor,
                    BookCopies = (int)AddBookNumberOfCopies_drop.Value
                };

                _bookService.Edit(book);

                ClearBookAdministration();
            }         
        }

       
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

                ClearBookAdministration();
            }

        }

        private void AddAuthor_Btn_Click(object sender, EventArgs e)
        {
            var name = AddAuthorName_textbox.Text;

            if (CheckInput(name))
            {
                Author author = new Author { Name = name };
                _authorService.AddAuthor(author);
                AddAuthorName_textbox.Clear();
            }

        }

        private void DeleteBook_btn_Click(object sender, EventArgs e)
        {
            int id = (int)GridViewAll.SelectedRows[0].Cells["Id"].Value;
            var book = _bookService.FindBook(id);
            _bookService.RemoveBook(book);
        }

        private void MakeLoan_Button_Click(object sender, EventArgs e)
        {

        }

        private void EditBook_Button_Click(object sender, EventArgs e)
        {

        }

       

        private void SearchBooksByAuthor_Btn_Click(object sender, EventArgs e)
        {

           
        }
        #endregion



        #region EventRecivers
        void OnUpdateFillComboBoxes(object source, EventArgs args)
        {
            FillComboBoxes();
        }
        #endregion


        #region Validation
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
        #endregion


        #region ClearInput

        private void ClearBookAdministration()
        {
            AddBookISBN_textbox.Clear();
            AddBookTitle_TextBox.Clear();
            AddBookDescription_TextBox.Clear();
            AddBookAuthor_ComboBox.Text = "";
            AddBookNumberOfCopies_drop.Text = "";
        }
        #endregion












        //--------------------------------------------------------------------------------------------------

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



        private void Author_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void EditBookCopies_Numeric_ValueChanged(object sender, EventArgs e)
        {

        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
