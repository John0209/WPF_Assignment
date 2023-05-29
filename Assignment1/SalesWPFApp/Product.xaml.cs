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
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        IProductRepository _product;
        
        public Product(IProductRepository product)
        {
            InitializeComponent();
            _product = product;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        public void LoadListProduct()
        {

            lvProduct.ItemsSource = _product.GetAllProduct();
        }

        private void btnLoadProduct_Click(object sender, RoutedEventArgs e)
        {
            LoadListProduct();
        }
    }
}
