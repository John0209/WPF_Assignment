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
    /// Interaction logic for AddMemberForm.xaml
    /// </summary>
    public partial class AddMemberForm : Window
    {
        IMemberRepository _member;

        public AddMemberForm(IMemberRepository member)
        {
            _member = member;
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Member mem = GetMember();

            if (_member.AddMember(mem))
            {
                var formNf = new NodifyForm();
                formNf.textNodify($"Add {mem.Email} Success, Please Reload!");
                formNf.Show();
            }

        }
        private Member GetMember()
        {
            Member pr = null;
            try
            {
                pr = new Member
                {
                    MemberId = 1,
                    Email = txtEmail.Text,
                    CompanyName= txtCompany.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password =txtPassword.Text
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
