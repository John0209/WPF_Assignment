using DataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public class MemberDAO
{
    FstoreContext _context;
    // singleton
    private static MemberDAO instance;
    private MemberDAO() 
    {
        _context = new FstoreContext();
    }
    public static MemberDAO Instance
    {
      get { 
        if(instance == null)
        {
            instance = new MemberDAO();
        }
        return instance;
          }
    }
    //code logic
    public IEnumerable<Member> GetMembers()
    {
        var result= _context.Members.ToList();
        if(result.Count>0 )
        {
            return result;
        }
        return null;
    }
    public bool RemoveMember(Member member)
    {
        if(member != null)
        {
           _context.Members.Remove(member);
            return true;
        }
        return false;
    }
    public bool AddMemeber(Member member)
    {
        if(member != null)
        {
            _context.Members.Add(member);
            return true;
        }
        return false;
    }
    public bool UpdateMember(Member member)
    {
        var id = member.MemberId;
        var checkMember=GetMemberById(id);
        if(checkMember!=null)
        {
            checkMember.Email= member.Email;
            checkMember.CompanyName= member.CompanyName;
            checkMember.City= member.City;
            checkMember.Country= member.Country;
            checkMember.Password= member.Password;
            _context.Members.Update(checkMember);
            return true;
        }
        return false;
    }
    public Member? GetMemberById(int id)
    {
        var result = _context.Members.Find(id);
        if (result != null)
        {
            return result;
        }
        return null;
    }
    public bool CheckLogin(string email, string password)
    {
        var memberList= GetMembers();
        var member=from m in memberList where m.Email == email && m.Password==password select m;
        var login=member.FirstOrDefault();
        if(login!=null)
        {
            return true;
        }
        return false;
    }
}
