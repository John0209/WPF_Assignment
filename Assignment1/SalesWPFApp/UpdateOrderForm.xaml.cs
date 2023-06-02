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
    /// Interaction logic for UpdateOrderForm.xaml
    /// </summary>
    public partial class UpdateOrderForm : Window
    {
        int m_orderID = 0;
        IOrderRepository m_order;
        Order oder_Update;
        public UpdateOrderForm(IOrderRepository orderRepository)
        {
            InitializeComponent();
            m_order = orderRepository;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            oder_Update = GetDataOrderUpdate();
            if (m_order.UpdateOrder(oder_Update, true))
            {
                var formNf = new NodifyForm();
                formNf.textNodify($"Update Order {oder_Update.OrderId} Success, Please Reload!");
                formNf.Show();
            }
        }

        public void GetOrderInforDisplay(Order od)
        {
            m_orderID = od.OrderId;
            txtMemberId.Text = od.MemberId.ToString();
            txtOrderDate.Text= od.OrderDate.ToString();
            txtRequiredDate.Text= od.RequiredDate.ToString();
            txtShippedDate.Text= od.ShippedDate.ToString();
            txtFreight.Text= od.Freight.ToString();
        }
        private Order GetDataOrderUpdate()
        {
            Order od = null;
            try
            {
                od = new Order
                {
                    OrderId = m_orderID,
                    MemberId=int.Parse(txtMemberId.Text),
                    OrderDate=DateTime.Parse(txtOrderDate.Text),
                    RequiredDate=DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate=DateTime.Parse(txtShippedDate.Text),
                    Freight=decimal.Parse(txtFreight.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return od;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
