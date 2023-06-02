using DataAccess;
using DataAccess.DataAccess;
using DataAccess.Repositories;
using Microsoft.IdentityModel.Tokens;
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
    /// Interaction logic for OrderForm.xaml
    /// </summary>
    public partial class OrderForm : Window
    {
        IMemberRepository _member;
        IProductRepository _product;
        IOrderRepository _order;
        Order order;
        public OrderForm(IMemberRepository? member, IProductRepository? product, IOrderRepository? order)
        {
            InitializeComponent();
            _member = member;
            _product = product;
            _order = order;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
        public void LoadListOrder()
        {
            lvOrder.ItemsSource = _order.GetAllOrder();
        }
        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            var oder = new AddOrderForm(_order);
            oder.Show();
        }


        private void btnUpdate_Click_1(object sender, RoutedEventArgs e)
        {
            UpdateOrderForm m_update = new UpdateOrderForm(_order);
            GetDataOrder();
            //excute
            m_update.GetOrderInforDisplay(order);
            m_update.Show();
        }

      
        private void btnDelete_Click_1(object sender, RoutedEventArgs e)
        {
            GetDataOrder();
            if (_order.UpdateOrder(order, false))
            {
                var formNf = new NodifyForm();
                formNf.textNodify($"Delete Order {order.OrderId} Success, Please Reload!");
                formNf.Show();
            }
        }

      

        private void btnLoad_Click_1(object sender, RoutedEventArgs e)
        {
            LoadListOrder();
        }

        private void GetDataOrder()
        {
            order = new Order();
            //get data
            order.OrderId = int.Parse(txt_OrderId.Text);
            order.MemberId = int.Parse(txt_MemberId.Text);
            order.OrderDate = DateTime.Parse(txt_OrderDate.Text);
            order.RequiredDate = DateTime.Parse(txt_RequiredDate.Text);
            order.ShippedDate = DateTime.Parse(txt_ShippedDate.Text);
            order.Status = Boolean.Parse(txt_StatusOrder.Text);
            order.Freight = decimal.Parse(txt_Freight.Text);
        }

        private void btnSearch_Click_1(object sender, RoutedEventArgs e)
        {
            var pr = _order.SearchOrder(int.Parse(txtSearchMem.Text));
            if (pr.IsNullOrEmpty())
            {
                var formNf = new NodifyForm();
                formNf.textNodify($"Order {txtSearchMem.Text} does not exist!");
                formNf.Show();
            }
            else
            {
                lvOrder.ItemsSource = pr;
            }
        }

        private void btnMember_Checked(object sender, RoutedEventArgs e)
        {
            var member = new MemberForm(_member, _product, _order);
            member.Show();
            member.LoadListMember();
        }

        private void btnOrder_Checked(object sender, RoutedEventArgs e)
        {
            LoadListOrder();
        }

        private void btnProduct_Checked(object sender, RoutedEventArgs e)
        {
            var pr = new ProductForm(_product, _member, _order);
            pr.Show();
            pr.LoadListProduct();
        }

        private void btnDashboard_Checked(object sender, RoutedEventArgs e)
        {

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
    }
}
