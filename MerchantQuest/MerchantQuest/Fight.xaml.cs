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

namespace MerchantQuest
{
    /// <summary>
    /// Interaction logic for Fight.xaml
    /// </summary>
    /// 
    public partial class Fight : Page
    {
        public Fight()
        {
            InitializeComponent();
        }
  
        private void Attack1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new fight_lose());
        }
        private void Attack2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new fight_lose());
        }
        private void Attack3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new fight_win());
        }
        private void Attack4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new fight_lose());
        }

    }
}
