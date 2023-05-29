using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public bool AddOrderDetail(OrderDetail detail) => OrderDetailDAO.Instance.AddOrderDetail(detail);
       
        public bool DeleteOrderDetail(OrderDetail detail) => OrderDetailDAO.Instance.RemoveOrderDetail(detail);

        public IEnumerable<OrderDetail> GetAllOrderDetail() => OrderDetailDAO.Instance.GetOrderDetail();

        public OrderDetail? GetOrderDetail(int idOrder, int idProduct) => OrderDetailDAO.Instance.GetOrderDetailById(idOrder,idProduct);

        public bool UpdateOrderDetail(OrderDetail detail) => OrderDetailDAO.Instance.UpdateOrderDetail(detail);

    }
}
