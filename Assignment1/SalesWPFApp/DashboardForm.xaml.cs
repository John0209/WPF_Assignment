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
    /// Interaction logic for DashboardForm.xaml
    /// </summary>
    public partial class DashboardForm : Window
    {
        IProductRepository _product;
        IMemberRepository _member;
        IOrderRepository _order;
        public DashboardForm(IProductRepository? product, IMemberRepository? member, IOrderRepository? order)
        {
            InitializeComponent();
            _product = product;
            _member = member;
            _order = order;
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
            var pr = new ProductForm(_product, _member, _order);
            pr.Show();
            pr.LoadListProduct();
        }

        private void btnOrder_Checked(object sender, RoutedEventArgs e)
        {
            var pr = new OrderForm(_member, _product, _order);
            pr.Show();
            pr.LoadListOrder();
        }

        private void btnMember_Checked(object sender, RoutedEventArgs e)
        {
            var member = new MemberForm(_member, _product, _order);
            member.Show();
            member.LoadListMember();
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

    }
}
