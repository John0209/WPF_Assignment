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
        private OrderDAO() { }
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
        public OrderDAO(FstoreContext context)
        {
            _context = context;
        }
        //code logic
        public IEnumerable<Order> GetOrderAsync()
        {
            var result =  _context.Orders.ToList();
            if (result.Count > 0)
            {
                return result;
            }
            return null;
        }
        public bool RemoveOrder(Order oder)
        {
            if (oder != null)
            {
                _context.Orders.Remove(oder);
                return true;
            }
            return false;
        }
        public bool AddOrder(Order oder)
        {
            if (oder != null)
            {
                _context.Orders.Add(oder);
                return true;
            }
            return false;
        }
        public bool UpdateOrder(Order oder)
        {
            var id = oder.OrderId;
            var check = GetOrderById(id);
            if (check != null)
            {
                check.OrderDate=oder.OrderDate;
                check.RequiredDate=oder.RequiredDate;
                check.ShippedDate=oder.ShippedDate;
                check.Freight=oder.Freight;
                _context.Orders.Update(check);
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
    }
}
