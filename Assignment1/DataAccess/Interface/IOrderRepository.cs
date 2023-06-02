using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetAllOrder();
        public Order? GetOrder(int id);
        public bool AddOrder(Order order);
        public bool DeleteOrder(Order order);
        public bool UpdateOrder(Order order,bool mask);
        public IEnumerable<Order> SearchOrder(int orId);
    }
}
