using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    class MemberRepository: IRepository<Member, int>
    {
        LibraryContext context;

        public MemberRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<Member> All()
        {
            return context.Members;
        }

        public void Add(Member item)
        {
            context.Members.Add(item);
        }

        public void Remove(Member item)
        {
            context.Members.Add(item);
        }

        public Member Find(int id)
        {
            return context.Members.Find(id); 
        }

        public void Edit(Member m)
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
