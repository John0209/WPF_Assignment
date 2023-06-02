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
using System.Runtime.InteropServices;
using System.Runtime;
using DataAccess.DataAccess;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for ProductForm.xaml
    /// </summary>
    public partial class ProductForm : Window
    {
        IProductRepository _product;
        
        //Product m_product;
        public ProductForm(IProductRepository product)
        {
            InitializeComponent();
            _product = product;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
      
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnDashboard_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnProduct_Checked(object sender, RoutedEventArgs e)
        {
            LoadListProduct();

        }
        public void LoadListProduct()
        {

           lvProduct.ItemsSource = _product.GetAllProduct();
        }
        private void btnOrder_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnMember_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal) 
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState=WindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState=WindowState.Minimized;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var m_add = new AddProduct(_product);
            m_add.Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateProduct m_updatePr= new UpdateProduct(_product);
            Product pr= new Product();
            //get data
            pr.ProductId=int.Parse(txt_ProductId.Text);
            pr.ProductName=txt_ProductName.Text;
            pr.CategoryId= int.Parse(txt_Category.Text);
            pr.Weight=txt_Weight.Text;
            pr.UnitPrice=decimal.Parse(txt_UnitPrice.Text); 
            pr.UnitslnStock= int.Parse(txt_UnitStock.Text);
            //excute
            m_updatePr.GetProductInfor(pr);
            m_updatePr.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
