using DataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        FstoreContext _context;
        // singleton
        private static OrderDetailDAO instance = null;
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailDAO();
                }
                return instance;
            }
        }
        public OrderDetailDAO(FstoreContext context)
        {
            _context = context;
        }
        //code logic
        public IEnumerable<OrderDetail> GetOrderDetail()
        {
            var result = _context.OrderDetails.ToList();
            if (result.Count > 0)
            {
                return result;
            }
            return null;
        }
        public bool RemoveOrderDetail(OrderDetail oder)
        {
            if (oder != null)
            {
                _context.OrderDetails.Remove(oder);
                return true;
            }
            return false;
        }
        public bool AddOrderDetail(OrderDetail oder)
        {
            if (oder != null)
            {
                _context.OrderDetails.Add(oder);
                return true;
            }
            return false;
        }
        public bool UpdateOrderDetail(OrderDetail oder)
        {
            var idOrder = oder.OrderId;
            var idProduct = oder.ProductId;
            var check = GetOrderDetailById(idOrder, idProduct);
            if (check != null)
            {
                check.UnitPrice = oder.UnitPrice;
                check.Quantity = oder.Quantity;
                check.Discount = oder.Discount;
                _context.OrderDetails.Update(check);
                return true;
            }
            return false;
        }
        public OrderDetail? GetOrderDetailById(int idOrder, int idProduct)
        {
            var orderDetailList= GetOrderDetail();
            var result=from c in orderDetailList where c.OrderId==idOrder 
                       && c.ProductId==idProduct select c;
            var orderDetail=result.FirstOrDefault();
            if (orderDetail != null)
            {
                return orderDetail;
            }
            return null;
        }
    }
}
