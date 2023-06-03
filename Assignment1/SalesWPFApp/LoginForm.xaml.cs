using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Principal;
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
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        IMemberRepository _member;
        IProductRepository _product;
        IOrderRepository _order;
        public LoginForm(IMemberRepository memberRepository, IProductRepository product, IOrderRepository? order)
        {
            InitializeComponent();
            _member = memberRepository;
            _product = product;
            _order = order;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState= WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string account = txtUser.Text;
            string password = txtPass.Password;
            if (_member.CheckLogin(account, password))
            {
                var pr = new DashboardForm(_product,_member,_order);
                pr.Show();
            }
            else
            {
                var formNf = new NodifyForm();
                formNf.textNodify($"Account Or Password Wrong, Please Login Again!");
                formNf.Show();
            }
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
