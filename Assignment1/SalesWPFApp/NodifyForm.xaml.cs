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
    /// Interaction logic for NodifyForm.xaml
    /// </summary>
    public partial class NodifyForm : Window
    {
        public NodifyForm()
        {
            InitializeComponent();
        }

       
        public void textNodify(string text)
        {
            txtNodify.Text = text;
        }


        private void btnShut_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
