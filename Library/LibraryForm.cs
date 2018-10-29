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

            // Fills Combos from start
            FillComboBoxes();

            // Event subsciptions
            _bookService.Updated += OnUpdateFillComboBoxes;
            _authorService.Updated += OnUpdateFillComboBoxes;
            _loanService.Updated += OnUpdateFillComboBoxes;
            _memberService.Updated += OnUpdateFillComboBoxes;
            _bookCopyService.Updated += OnUpdateFillComboBoxes;
            
            // You need to choose a member to make a loan
            LoanBook_Btn.Enabled = false;
        }

        /// <summary>
        /// Returns a specific book
        /// </summary>
        /// <returns></returns> 
        private Book GetThisBook()
        {
            if (BookGrid.SelectedRows[0].Cells["Id"] != null)
            {
                var id = (int)BookGrid.SelectedRows[0].Cells["Id"].Value;
                return _bookService.FindBook(id);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Returns a specific loan
        /// </summary>
        /// <returns></returns>
        Loan GetThisLoan()
        {
            if (LoanGrid.SelectedRows[0].Cells["IDLoan"] != null)
            {
                var id = (int)LoanGrid.SelectedRows[0].Cells["IDLoan"].Value;
                return _loanService.FindLoan(id);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Print out all books from IEnumerable to the main data view
        /// </summary>
        /// <param name="books"></param>
        void ShowAllBooks(IEnumerable<Book> books)
        {
            BookGrid.Rows.Clear();

            var index = 0;

            foreach (var book in books)
            {
                var updatedNumberOfBookCopies = book.BookCopies;

                BookGrid.Rows.Add();
                BookGrid["Title", index].Value = book.Title;
                BookGrid["Description", index].Value = book.Description;
                BookGrid["Author", index].Value = book.Author.Name;
                BookGrid["Copies", index].Value = updatedNumberOfBookCopies;
                BookGrid["AvailableCopies", index].Value = updatedNumberOfBookCopies - _loanService.GetNumberOfCurrentLoansByBook(book);
                BookGrid["ISBN", index].Value = book.Isbn;
                BookGrid["ID", index].Value = book.Id;

                index++;
            }
        }
        /// <summary>
        /// Print out all loans from IEnumerable to the loans data view
        /// </summary>
        /// <param name="loans"></param>
        void ShowAllLoans(IEnumerable<Loan> loans)
        {
            LoanGrid.Rows.Clear();

            var index = 0;

            foreach (var loan in loans)
            {
               LoanGrid.Rows.Add();
               LoanGrid["IDLoan", index].Value = loan.Id;
               LoanGrid["TitleLoan", index].Value = loan.BookCopy.Book.Title;
               LoanGrid["AuthorLoan", index].Value = loan.BookCopy.Book.Author.Name;
               LoanGrid["LoanTime", index].Value = loan.TimeOfLoan;
               LoanGrid["DateDue", index].Value = loan.DueDate;
               LoanGrid["DateReturn", index].Value = loan.TimeOfReturn;

                // Fine if it exists from LoanSerivce
                if (!string.IsNullOrWhiteSpace(loan.Fine))
                {
                    LoanGrid["FineLoan", index].Value = loan.Fine;
                }

                index++;
            }
        }

        //From Grid to relevant input boxes
        private void GridViewAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var book = GetThisBook();
            
            AddBookISBN_textbox.Text = book.Isbn;
            AddBookTitle_TextBox.Text = book.Title;
            AddBookAuthor_ComboBox.SelectedItem = book.Author;
            AddBookDescription_TextBox.Text = book.Description;
            AddBookNumberOfCopies_drop.Value =  book.BookCopies;
        }

        /// <summary>
        /// Filling Como Boxes (on change)
        /// </summary>
        private void FillComboBoxes()
        {
            ShowAllBooks(_bookService.All());
            ShowAllLoans(_loanService.AllLoans());
        
            AddBookAuthor_ComboBox.Items.Clear();
            Member_ComboBox.Items.Clear();
            AllMembers_listbox.Items.Clear();

            foreach (var author in _authorService.AllAuthors())
            {
               AddBookAuthor_ComboBox.Items.Add(author);         
            }

           SearchBookByAuthor_combobox.Items.Clear();

            foreach (var author in _authorService.AllAuthors())
            {
                SearchBookByAuthor_combobox.Items.Add(author);
            }
            
            // Notera: Går bra att ej köra Member.Name här eftersom jag overridar ToString i modellen istället.
            // Därför blir det smidigare att casta när jag ska låna. 
            foreach (var member in _memberService.AllMembers())
            {
                Member_ComboBox.Items.Add(member);
                AllMembers_listbox.Items.Add(member);
            }

        }

        // Buttons
        #region Buttons
        private void LoanBook_Btn_Click(object sender, EventArgs e)
        {
            // Hämtar Id för aktuell bok
             var iD = (int)BookGrid.CurrentRow.Cells["Id"].Value;
            // Hämtar bok utifrån det
            var book = _bookService.FindBook(iD);
            // Hämtar bookcopy utifrån det
            var bookCopy = _bookCopyService.GetBookCopyByBookId(iD);
            // Hämtar aktuell member 
            var currentMember  = (Member)Member_ComboBox.SelectedItem;

            if (_loanService.AvailableCopies(book) && currentMember != null)
            {
                _loanService.LoanBook(bookCopy, currentMember);
            }

        }
        private void ReturnBook_Btn_Click(object sender, EventArgs e)
        {
            var loan = GetThisLoan();

            var timeOfReturn = DateTime.Now;

            _loanService.ReturnLoan(loan, timeOfReturn);

        }

        private void SearchBookByAuthor_Btn_Click(object sender, EventArgs e)
        {
            if (SearchBookByAuthor_combobox.SelectedItem != null)
            {
                var booksByThisAuthor = _bookService.AllBooksByAuthor((Author)SearchBookByAuthor_combobox.SelectedItem);
                ShowAllBooks(booksByThisAuthor);
            }
        }
        private void ListAllBooks_btn_Click(object sender, EventArgs e)
        {
            FillComboBoxes();
        }


        private void SaveBook_Btn_Click(object sender, EventArgs e)
        {
            // validerar
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
            var id = (int)BookGrid.SelectedRows[0].Cells["Id"].Value;

            if (CheckInput(validationList) && AddBookAuthor_ComboBox.SelectedItem != null)
            {
                var book = new Book()
                {
                    Id = id,
                    Isbn = newIsbn,
                    Title = newTitle,
                    Description = newDescription,
                    Author = (Author)newAuthor,
                    BookCopies = (int)newNumberOfCopies
                };

                _bookService.Edit(book);

                ClearBookAdministration();
            }         
        }
       
        private void AddBook_Button_Click(object sender, EventArgs e)
        {
            // Skapar lista för smidig validering
            var validationList = new List<string>
            {
                AddBookISBN_textbox.Text,
                AddBookTitle_TextBox.Text,
                AddBookDescription_TextBox.Text,
            };

            if (CheckInput(validationList) && AddBookAuthor_ComboBox.SelectedItem != null)
            {
                var book = new Book()
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
                    var bookCopy = new BookCopy()
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
                var author = new Author { Name = name };
                _authorService.AddAuthor(author);
                AddAuthorName_textbox.Clear();
            }
        }

        private void DeleteBook_btn_Click(object sender, EventArgs e)
        {

            var id = (int)BookGrid.SelectedRows[0].Cells["Id"].Value;
            var book = _bookService.FindBook(id);
            _bookService.RemoveBook(book);
            ClearBookAdministration();
        }


        private void AddMember_Btn_Click(object sender, EventArgs e)
        {

            var validationList = new List<string>
            {
                Member_Name_textbox.Text,
                Member_Id_textbox.Text
            };

            if (CheckInput(validationList))
            {
                var member = new Member
                {
                    Name = Member_Name_textbox.Text,
                    Pnr = Member_Id_textbox.Text
                };
                _memberService.AddMember(member);
                ClearMemberInput();
            }
        }

        private void DeleteMember_Btn_Click(object sender, EventArgs e)
        {
            var selectedMember = AllMembers_listbox.SelectedItem;
            if (selectedMember != null)
            {
                _memberService.RemoveMember((Member)selectedMember);
            }

        }
        #endregion

        void OnUpdateFillComboBoxes(object source, EventArgs args)
        {
            FillComboBoxes();
        }

        #region Validation
        /// <summary>
        /// Checks that the provided string-LIST is not null or empty
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Checks that the provided string is not null or empty
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool CheckInput(string input)
        {
            var list = new List<string>()
            {
                input
            };
            return CheckInput(list);
        }
        #endregion


        #region ClearInput

        /// <summary>
        /// Clears input for Book Adminstration
        /// </summary>
        /// <returns></returns>
        private void ClearBookAdministration()
        {
            AddBookISBN_textbox.Clear();
            AddBookTitle_TextBox.Clear();
            AddBookDescription_TextBox.Clear();
            AddBookAuthor_ComboBox.Text = "";
            AddBookNumberOfCopies_drop.Text = "";
        }

        /// <summary>
        /// Clear input for member administration
        /// </summary>
        /// <returns></returns>
        private void ClearMemberInput()
        {
            Member_Id_textbox.Text = "";
            Member_Name_textbox.Text = "";
        }
        #endregion

        private void Member_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Det går ej att trycka på lånknappen om ingen medlem är vald.
            if (Member_ComboBox.SelectedItem != null && BookGrid.SelectedRows != null)
            {
                LoanBook_Btn.Enabled = true;
            }
            else
            {
                LoanBook_Btn.Enabled = false;
            }
        }
      
        //Nedan: Metoder utan kod
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

    

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void BookGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
