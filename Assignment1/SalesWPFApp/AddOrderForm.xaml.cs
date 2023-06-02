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
    /// Interaction logic for AddOrderForm.xaml
    /// </summary>
    public partial class AddOrderForm : Window
    {

        IOrderRepository _order;
        public AddOrderForm(IOrderRepository oder)
        {
            InitializeComponent();
            _order=oder;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Order od=GetOrder();
            if (_order.AddOrder(od))
            {
                var formNf = new NodifyForm();
                formNf.textNodify($"Add Order {od.OrderId} Success, Please Reload!");
                formNf.Show();
            }

        }
        private Order GetOrder()
        {
            Order pr = null;
            try
            {
                pr = new Order
                {
                    OrderId=1,
                    MemberId=1,
                    OrderDate=DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight=decimal.Parse(txtFreight.Text)
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
            // Application.Current.Shutdown();
            Close();
        }
    }
}
