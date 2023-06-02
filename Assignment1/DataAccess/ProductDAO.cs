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
                var number = _context.SaveChanges();
                if (number > 0)
                    return true;
            }
            return false;
        }
        public bool AddProduct(Product product)
        {
            if (product != null)
            {
                var pr=new Product();
                pr.CategoryId = product.CategoryId;
                pr.ProductName= product.ProductName;
                pr.Weight = product.Weight;
                pr.UnitPrice = product.UnitPrice;
                pr.UnitslnStock= product.UnitslnStock;
                _context.Products.Add(pr);
                var number= _context.SaveChanges();
                if(number>0)
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
                check.CategoryId=product.CategoryId;
                check.ProductName = product.ProductName;
                check.Weight = product.Weight;
                check.UnitPrice = product.UnitPrice;
                check.UnitslnStock= product.UnitslnStock;
                _context.Products.Update(check);
                var number = _context.SaveChanges();
                if (number > 0)
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
