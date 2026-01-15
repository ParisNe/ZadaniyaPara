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

namespace Para.Pages
{
    /// <summary>
    /// Логика взаимодействия для OptionsPage.xaml
    /// </summary>
    public partial class OptionsPage : Page
    {
        double NewSum, DopOpt;
        public OptionsPage()
        {
            InitializeComponent();
        }
        TextBlock choice;
        
        private void DopCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            choice = DopCB.SelectedItem as TextBlock;
        }
        string dop;
        private void ButtonChoice_Click(object sender, RoutedEventArgs e)
        {
            dop += choice.Text.ToString() + ",";
            cb.Content = "Вы выбрали: " + dop;
            if (choice == DopCB1) DopOpt += 50;
            else if (choice == DopCB2) DopOpt += 80;
            else if (choice == DopCB3) DopOpt += 40;
            itog2.Text = $"Итог{DopOpt + NewSum}";
            Pizza.dobavki=cb.Content.ToString();
        }

        private void SmallSize_Checked(object sender, RoutedEventArgs e)
        {
            NewSum=Pizza.sum;
            Pizza.razmer=SmallSize.Content.ToString();
            itog2.Text = $"Итог{DopOpt + NewSum}";

        }

        private void AverageSize_Checked(object sender, RoutedEventArgs e)
        {
            NewSum = Pizza.sum*1.2;
            Pizza.razmer = AverageSize.Content.ToString();
            itog2.Text = $"Итог{DopOpt + NewSum}";

        }

        private void BigSize_Checked(object sender, RoutedEventArgs e)
        {
            NewSum = Pizza.sum * 1.4;
            Pizza.razmer = BigSize.Content.ToString();
            itog2.Text = $"Итог{DopOpt + NewSum}";
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            Pizza.sum= NewSum + DopOpt;
            NavigationService.Navigate(new ConfirmPage());

        }

    }
}
