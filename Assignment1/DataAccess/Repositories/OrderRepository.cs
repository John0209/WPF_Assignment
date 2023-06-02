using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public bool AddOrder(Order order)=> OrderDAO.Instance.AddOrder(order);
       
        public bool DeleteOrder(Order order) => OrderDAO.Instance.RemoveOrder(order);

        public IEnumerable<Order> GetAllOrder() => OrderDAO.Instance.GetOrderAsync();

        public Order? GetOrder(int id) => OrderDAO.Instance.GetOrderById(id);

        public IEnumerable<Order> SearchOrder(int orId) => OrderDAO.Instance.SearchOrder(orId);
        public bool UpdateOrder(Order order,bool mask) => OrderDAO.Instance.UpdateOrder(order,mask);

    }
}
