using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Para.Pages
{
    /// <summary>
    /// Логика взаимодействия для ConfirmPage.xaml
    /// </summary>
    public partial class ConfirmPage : Page
    {
        public ConfirmPage()
        {
            InitializeComponent();
            PizzaItog.Text += Pizza.pizza;
            SizeItog.Text += Pizza.razmer;
            DopItog.Text += Pizza.dobavki;
            Itog.Text += Pizza.sum;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NameUser.Text.Length < 0)
            {
                MessageBox.Show("Имя забыл");
            }
            else { MessageBox.Show("точк."); }
        }
    }
}
