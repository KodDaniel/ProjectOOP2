using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class AuthorService : IService
    {
        public event EventHandler Updated;

        AuthorRepository authorRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }

        public IEnumerable<Author> AllAuthors()
        {
            return authorRepository.All();
        }

        public void AddAuthor(Author author)
        {
            authorRepository.Add(author);

            if (Updated != null)
            {
                Updated(this, EventArgs.Empty);

            }
        }

        public void RemoveAuthor(Author author)
        {
            authorRepository.Remove(author);
        }

        public Author FindAuthor(int key)
        {
            return authorRepository.Find(key);
        }
    }
}
