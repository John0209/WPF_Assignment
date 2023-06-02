using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class MemberRepository : IMemberRepository
    {

        public bool AddMember(Member member) => MemberDAO.Instance.AddMemeber(member);

        public bool CheckLogin(string email, string password) => MemberDAO.Instance.CheckLogin(email, password);

        public bool DeleteMember(Member member) => MemberDAO.Instance.RemoveMember(member);
        
        public IEnumerable<Member> GetAllMembers() => MemberDAO.Instance.GetMembers();

        public Member? GetMember(int id) => MemberDAO.Instance.GetMemberById(id);

        public IEnumerable<Member> SearchMember(string name) => MemberDAO.Instance.SearchMember(name);
        public bool UpdateMember(Member member, bool mask) => MemberDAO.Instance.UpdateMember(member,mask);


    }
}
