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
    /// Interaction logic for UpdateProduct.xaml
    /// </summary>
    public partial class UpdateProduct : Window
    {
        int m_productId=0;
        IProductRepository m_product;
        Product product_Update;
        public UpdateProduct(IProductRepository product)
        {
            InitializeComponent();
            m_product = product;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            product_Update = GetDataProductUpdate();
           if(m_product.UpdateProduct(product_Update,true))
            {
                var formNf = new NodifyForm();
                formNf.textNodify($"Update {product_Update.ProductName} Success, Please Reload!");
                formNf.Show();
            }
        }

        public void GetProductInforDisplay(Product product)
        {
            m_productId = product.ProductId;
            txtCateId.Text = product.CategoryId.ToString();
            txtProductName.Text = product.ProductName;
            txtUnitPrice.Text =product.UnitPrice.ToString();
            txtUnitslnStock.Text = product.UnitslnStock.ToString();
            txtWeight.Text = product.Weight;
        }
        private Product GetDataProductUpdate()
        {
            Product pr = null;
            try
            {
                pr = new Product
                {
                    ProductId = m_productId,
                    CategoryId = int.Parse(txtCateId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitslnStock = int.Parse(txtUnitslnStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return pr;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }

}
