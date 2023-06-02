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
    /// Interaction logic for UpdateMemberForm.xaml
    /// </summary>
    public partial class UpdateMemberForm : Window
    {
        int m_memId = 0;
        IMemberRepository m_memberRepository;
        Member mem_Update;
        public UpdateMemberForm(IMemberRepository memberRepository)
        {
            InitializeComponent();
            m_memberRepository = memberRepository;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
           mem_Update = GetDataMemberUpdate();
            if (m_memberRepository.UpdateMember(mem_Update, true))
            {
                var formNf = new NodifyForm();
                formNf.textNodify($"Update {mem_Update.Email} Success, Please Reload!");
                formNf.Show();
            }
        }

        public void GetMemberInforDisplay(Member mem)
        {
            m_memId = mem.MemberId;
            txtEmail.Text = mem.Email;
            txtCity.Text = mem.City;
            txtCompany.Text = mem.CompanyName;
            txtCountry.Text = mem.Country;
            txtPassword.Text = mem.Password;
        }
        private Member GetDataMemberUpdate()
        {
            Member pr = null;
            try
            {
                pr = new Member
                {
                    MemberId=m_memId,
                    City=txtCity.Text,
                    Country=txtCountry.Text,
                    CompanyName=txtCompany.Text,
                    Email=txtEmail.Text,
                    Password=txtPassword.Text
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
