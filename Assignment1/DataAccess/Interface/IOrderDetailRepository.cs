using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public interface IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetAllOrderDetail();
        public OrderDetail? GetOrderDetail(int idOrder, int idProduct);
        public bool AddOrderDetail(OrderDetail detail);
        public bool DeleteOrderDetail(OrderDetail detail);
        public bool UpdateOrderDetail(OrderDetail detail);
    }
}
