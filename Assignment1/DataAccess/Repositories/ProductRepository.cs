using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public bool AddProduct(Product product)=> ProductDAO.Instance.AddProduct(product);
       
        public bool DeleteProduct(Product product) => ProductDAO.Instance.RemoveProduct(product);

        public IEnumerable<Product> GetAllProduct() => ProductDAO.Instance.GetProductAsync();

        public Product? GetProductById(int id) => ProductDAO.Instance.GetProductById(id);

        public IEnumerable<Product> SearchProduct(string name) => ProductDAO.Instance.SearchProduct(name);

        public bool UpdateProduct(Product product,bool mask)=> ProductDAO.Instance.UpdateProduct(product,mask);

        
    }
}
