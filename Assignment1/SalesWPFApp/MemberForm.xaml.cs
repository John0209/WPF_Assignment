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
    /// Interaction logic for MemberForm.xaml
    /// </summary>
    public partial class MemberForm : Window
    {
        IMemberRepository _member;
        IProductRepository _product;
        public MemberForm(IMemberRepository? member,IProductRepository? product)
        {
            InitializeComponent();
            _member = member;
            _product = product;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
        public void LoadListMember()
        {
            lvMember.ItemsSource = _member.GetAllMembers();
        }
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadListMember();
        }


        private void btnProduct_Checked(object sender, RoutedEventArgs e)
        {
            var pr = new ProductForm(_product,_member);
            pr.Show();
            pr.LoadListProduct();
        }

        private void btnOrder_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnMember_Checked(object sender, RoutedEventArgs e)
        {
            LoadListMember();
        }

        private void btnDashboard_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //var pr = _product.SearchProduct(txtSearch.Text);
            //if (pr.IsNullOrEmpty())
            //{
            //    var formNf = new NodifyForm();
            //    formNf.textNodify($"{txtSearch.Text} does not exist!");
            //    formNf.Show();
            //}
            //else
            //{
            //    lvProduct.ItemsSource = pr;
            //}
        }
    }
}
