using DataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class OrderDAO
    {
        FstoreContext _context;
        // singleton
        private static OrderDAO instance = null;
        private OrderDAO() 
        {
            _context = new FstoreContext();
        }
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }
        
        //code logic
        public IEnumerable<Order> GetOrderAsync()
        {
            var result =  _context.Orders.ToList();
            if (result.Count > 0)
            {
                var listOrder = from p in result where p.Status == true select p;
                return listOrder;
            }
            return null;
        }
        public bool RemoveOrder(Order oder)
        {
            if (oder != null)
            {
                _context.Orders.Remove(oder);
                var number = _context.SaveChanges();
                if (number > 0)
                    return true;
            }
            return false;
        }
        public bool AddOrder(Order oder)
        {
            if (oder != null)
            {
                var or= new Order();
                or.MemberId=oder.MemberId;
                or.OrderDate=oder.OrderDate;
                or.RequiredDate=oder.RequiredDate;
                or.ShippedDate=oder.ShippedDate;
                or.Freight=oder.Freight;
                or.Status = true;
                _context.Orders.Add(or);
                var number = _context.SaveChanges();
                if (number > 0)
                    return true;
            }
            return false;
        }
        public bool UpdateOrder(Order oder,bool mask)
        {
            var id = oder.OrderId;
            var check = GetOrderById(id);
            if (check != null)
            {
                if (mask) { 
                check.MemberId=oder.MemberId;
                check.OrderDate=oder.OrderDate;
                check.RequiredDate=oder.RequiredDate;
                check.ShippedDate=oder.ShippedDate;
                check.Freight=oder.Freight;
                }
                else
                {
                check.Status = false;
                }
                _context.Orders.Update(check);
                var number = _context.SaveChanges();
                if (number > 0)
                    return true;
            }
            return false;
        }
        public Order? GetOrderById(int id)
        {
            var result = _context.Orders.Find(id);
            if (result != null)
            {
                return result;
            }
            return null;
        }
        public IEnumerable<Order> SearchOrder(int orId)
        {
            var memberList = GetOrderAsync();
            var list = from p in memberList
                       where p.OrderId == orId
                       select p;
            return list;
        }
    }
}
