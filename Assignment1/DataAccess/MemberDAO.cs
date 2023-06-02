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
            var listMember = from p in result where p.Status == true select p;
            return listMember;
        }
        return null;
    }
    public bool RemoveMember(Member member)
    {
        if(member != null)
        {
           _context.Members.Remove(member);
            var number = _context.SaveChanges();
            if (number > 0)
                return true;
        }
        return false;
    }
    public bool AddMemeber(Member member)
    {
        if(member != null)
        {
            var mem= new Member();
            mem.Email=member.Email;
            mem.CompanyName=member.CompanyName;
            mem.City=member.City;
            mem.Country=member.Country;
            mem.Password=member.Password;
            mem.Status=true;
            _context.Members.Add(mem);
            var number = _context.SaveChanges();
            if (number > 0)
                return true;
        }
        return false;
    }
    public bool UpdateMember(Member member, bool mask)
    {
        var id = member.MemberId;
        var checkMember=GetMemberById(id);
        if(checkMember!=null)
        {
            if (mask) { 
            checkMember.Email= member.Email;
            checkMember.CompanyName= member.CompanyName;
            checkMember.City= member.City;
            checkMember.Country= member.Country;
            checkMember.Password= member.Password;
            }
            else
            {
            checkMember.Status = false;
            }
            _context.Members.Update(checkMember);
            var number = _context.SaveChanges();
            if (number > 0)
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
    public IEnumerable<Member> SearchMember(string name)
    {
        var memberList = GetMembers();
        var list = from p in memberList where p.Email == name || p.Country==name || p.CompanyName==name
                   || p.City==name select p;
        return list;
    }

}
