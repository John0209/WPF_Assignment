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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IMemberRepository _member;
        IProductRepository _product;
        public MainWindow(IMemberRepository memberRepository,IProductRepository product)
        {
            InitializeComponent();
            _member = memberRepository;
            _product = product;
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPass.Text;
            if (_member.CheckLogin(account, password))
            {
                var pr= new Product(_product);
                pr.Show();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
