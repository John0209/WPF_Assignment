using DataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        FstoreContext _context;
        // singleton
        private static ProductDAO instance = null;
        private ProductDAO() 
        {
            _context = new FstoreContext();
        }
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }
        //code logic
        public IEnumerable<Product> GetProductAsync()
        {
            var result = _context.Products.ToList();
            if (result.Count > 0)
            {
                return result;
            }
            return null;
        }
        public bool RemoveProduct(Product product)
        {
            if (product != null)
            {
                _context.Products.Remove(product);
                return true;
            }
            return false;
        }
        public bool AddProduct(Product product)
        {
            if (product != null)
            {
                _context.Products.Add(product);
                return true;
            }
            return false;
        }
        public bool UpdateProduct(Product product)
        {
            var id = product.ProductId;
            var check = GetProductById(id);
            if (check != null)
            {
                check.ProductName = product.ProductName;
                check.Weight = product.Weight;
                check.UnitPrice = product.UnitPrice;
                check.UnitslnStock= product.UnitslnStock;
                _context.Products.Update(check);
                return true;
            }
            return false;
        }
        public Product? GetProductById(int id)
        {
            var result = _context.Products.Find(id);
            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}
