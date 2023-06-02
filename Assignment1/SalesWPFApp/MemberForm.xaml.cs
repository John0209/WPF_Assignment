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
    /// Interaction logic for MemberForm.xaml
    /// </summary>
    public partial class MemberForm : Window
    {
        IMemberRepository _member;
        IProductRepository _product;
        IOrderRepository _order;
        Member mem;
        public MemberForm(IMemberRepository? member,IProductRepository? product,IOrderRepository? order)
        {
            InitializeComponent();
            _member = member;
            _product = product;
            _order = order;
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
            var member =new AddMemberForm(_member);
            member.Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateMemberForm m_update = new UpdateMemberForm(_member);
            GetDataMember();
            //excute
            m_update.GetMemberInforDisplay(mem);
            m_update.Show();
        }
        private void GetDataMember()
        {
            mem = new Member();
            //get data
            mem.MemberId=int.Parse(txt_MemberId.Text);
            mem.Email=txt_Email.Text;
            mem.City=txt_City.Text;
            mem.Country=txt_Country.Text;
            mem.CompanyName=txt_CompanyName.Text;
            mem.Password=txt_Password.Text;
            mem.Status= Boolean.Parse(txt_StatusMember.Text);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            GetDataMember();
            if (_member.UpdateMember(mem, false))
            {
                var formNf = new NodifyForm();
                formNf.textNodify($"Delete {mem.Email} Success, Please Reload!");
                formNf.Show();
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadListMember();
        }


        private void btnProduct_Checked(object sender, RoutedEventArgs e)
        {
            var pr = new ProductForm(_product,_member,_order);
            pr.Show();
            pr.LoadListProduct();
        }

        private void btnOrder_Checked(object sender, RoutedEventArgs e)
        {
            var pr = new OrderForm (_member,_product, _order);
            pr.Show();
            pr.LoadListOrder();
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
            var pr = _member.SearchMember(txtSearchMem.Text);
            if (pr.IsNullOrEmpty())
            {
                var formNf = new NodifyForm();
                formNf.textNodify($"{txtSearchMem.Text} does not exist!");
                formNf.Show();
            }
            else
            {
                lvMember.ItemsSource = pr;
            }
        }
    }
}
