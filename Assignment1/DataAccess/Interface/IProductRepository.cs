using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProduct();
        public Product? GetProductById(int id);
        public bool AddProduct(Product product);
        public bool DeleteProduct(Product product);
        public bool UpdateProduct(Product product,bool mask);
        public IEnumerable<Product> SearchProduct(string name);

    }
}
