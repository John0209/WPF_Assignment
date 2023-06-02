using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IMemberRepository
    {
        public IEnumerable<Member> GetAllMembers();
        public Member? GetMember(int id);
        public bool AddMember(Member member);
        public bool DeleteMember(Member member);
        public bool UpdateMember(Member member,bool mask);
        public bool CheckLogin(string email, string password);
        public IEnumerable<Member> SearchMember(string name);
    }
}
