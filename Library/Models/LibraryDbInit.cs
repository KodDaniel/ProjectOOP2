using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method you can create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
    {
        //        protected override void Seed(LibraryContext context)
        //{

        //    base.Seed(context);

        //    //Add author
        //    Author håkanNesser = new Author()
        //    {
        //        Name = "Håkan Nesser",

        //    };
        //    context.Authors.Add(håkanNesser);
        //    context.SaveChanges();

        //    Book människaUtanHund = new Book()
        //    {
        //        Title = "Människa utan hund",
        //        Author = håkanNesser,
        //        BookCopies = 2,
        //        Isbn = "9789170014598",
        //        Description = "Första delen av fyra med kriminalinspektören Gunnar Barbarotti.Familjen Hermansson samlas för att fira pappa Karl - Eriks och äldsta dottern Ebbas födelsedagar.Natten före bemärkelsedagen går sonen Robert ut och kommer aldrig tillbaka. Sedan försvinner Ebbas son Henrik.Barbarotti tvingas se familjens mörka hemligheter."
        //    };
        //    Book deVänsterhäntasFörening = new Book()
        //    {
        //        Title = "De vänsterhäntas förening",
        //        Author = håkanNesser,
        //        BookCopies = 1,
        //        Isbn = "9789176472064",
        //        Description = "Medan Marten Winckelstroop och Rejmus Fiste ännu går i Oosterby småskola bildar de De vänsterhäntas förening. Flera årtionden senare brinner ett gammalt pensionat ner till grunden och ett antal människor omkommer. Det ena hänger ihop med det andra, men det finns ingen kvar i livet som kan förklara hur. Nästan ingen. Det har gått femton år sedan den sista boken om kommissarie Van Veeteren kom ut.Det har gått sex år sedan man senast kunde läsa om inspektör Gunnar Barbarotti.I De vänsterhäntas förening möts de för första(och enda ?) gången."
        //    };

        //    context.Books.Add(människaUtanHund);
        //    context.Books.Add(deVänsterhäntasFörening);
        //    context.SaveChanges();

        //    foreach (Book book in context.Books.ToList())
        //    {
        //        for (int i = 0; i < book.BookCopies; i++)
        //        {
        //            BookCopy bc = new BookCopy()
        //            {
        //                Book = book
        //            };
        //            context.BookCopies.Add(bc);
        //        }
        //    }
        //    //Add member
        //    Member stefanLöfven = new Member()
        //    {
        //        Name = "Stefan Löfven",
        //        Pnr = "550205-5953"
        //    };
        //    context.Members.Add(stefanLöfven);

        //    context.SaveChanges();

        //}
    }
}
