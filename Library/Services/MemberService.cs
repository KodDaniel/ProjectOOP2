using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class MemberService:IService
    {
        public event EventHandler Updated;

        MemberRepository memberRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository= rFactory.CreateMemberRepository();
        }

        public IEnumerable<Member> AllMembers()
        {
            return memberRepository.All();
        }

        public void AddMember(Member member)
        {
            memberRepository.Add(member);
        }

        public void RemoveMember(Member member)
        {
            memberRepository.Remove(member);
        }

        public Member FindMember(int key)
        {
            return memberRepository.Find(key);
        }
    }
}
