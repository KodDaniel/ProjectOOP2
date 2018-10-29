using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Models {
    /// <summary>
    /// Derived context.
    /// </summary>
    public class LibraryContext : DbContext {
        // Your context has been configured to use a 'LibraryContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Library.Models.LibraryContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LibraryContext' 
        // connection string in the application configuration file.
        public LibraryContext(){
            // Database strategy
            Database.SetInitializer<LibraryContext>(new LibraryDbInit());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Column restrictions
            modelBuilder.Entity<Member>().Property(t => t.Id).HasColumnName("MemberId");
            modelBuilder.Entity<Member>().Property(t => t.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Member>().Property(t => t.Pnr).IsRequired();


            modelBuilder.Entity<Loan>().Property(t => t.Id).HasColumnName("LoanId");
            modelBuilder.Entity<Loan>().Property(t => t.DueDate).IsRequired();
            modelBuilder.Entity<Loan>().Property(t => t.TimeOfLoan).IsRequired();
            modelBuilder.Entity<Loan>().Property(t => t.TimeOfReturn).IsOptional();

            modelBuilder.Entity<Author>().Property(t => t.Id).HasColumnName("AuthorId");
            modelBuilder.Entity<Author>().Property(t => t.Name).HasMaxLength(100).IsRequired();

            modelBuilder.Entity<BookCopy>().Property(t => t.Id).HasColumnName("BookCopyId");

            modelBuilder.Entity<Book>().Property(t => t.Id).HasColumnName("BookId");
            modelBuilder.Entity<Book>().Property(t => t.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Book>().Property(t => t.Description).IsMaxLength().IsOptional();
            modelBuilder.Entity<Book>().Property(t => t.Isbn).IsRequired();

            //// Relations
            modelBuilder.Entity<BookCopy>().HasRequired(a => a.Book);
            modelBuilder.Entity<Book>().HasRequired(a => a.Author);
            modelBuilder.Entity<Loan>().HasRequired(a => a.Member);
            modelBuilder.Entity<Loan>().HasRequired(a => a.BookCopy);

            //modelBuilder.Entity<BookCopy>()
            //    .HasRequired(c => c.Book)
            //    .WithMany(d => d.BookCopy)
            //    .HasForeignKey(c => c.Book_Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}