﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    class AuthorRepository:IRepository<Author,int>
    {
        LibraryContext context;

        public AuthorRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<Author> All()
        {
            return context.Authors;
        }

        public void Add(Author item)
        {
            context.Authors.Add(item);
            context.SaveChanges();
        }

        public void Remove(Author item)
        {
            context.Authors.Remove(item);
            context.SaveChanges();


        }

        public Author Find(int id)
        {
            return context.Authors.Find(id);
        }

        public void Edit(Author a)
        {
            // Because the object b was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Book object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }
    }
}
