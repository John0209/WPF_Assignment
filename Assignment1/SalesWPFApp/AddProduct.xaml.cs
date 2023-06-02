using DataAccess.DataAccess;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        IProductRepository _product;
        ProductForm formPr;
        public AddProduct(IProductRepository product)
        {
            InitializeComponent();
            _product = product;
            formPr = new ProductForm(_product);
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Product product=GetProduct();
            if (_product.AddProduct(product))
            {
                formPr.LoadListProduct();
                var formNf = new NodifyForm();
                formNf.textNodify($"Add {product.ProductName} Successfully!");
                formNf.Show();
            }
           
        }
        private Product GetProduct()
        {
            Product pr=null;
            try
            {
                pr = new Product
                {
                    ProductId = 1,
                    CategoryId = int.Parse(txtCateId.Text),
                    ProductName=txtProductName.Text,
                    Weight= txtWeight.Text,
                    UnitPrice=decimal.Parse(txtUnitPrice.Text),
                    UnitslnStock= int.Parse(txtUnitslnStock.Text)
                };
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return pr;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
           // Application.Current.Shutdown();
            Close();
        }

       
    }
}
