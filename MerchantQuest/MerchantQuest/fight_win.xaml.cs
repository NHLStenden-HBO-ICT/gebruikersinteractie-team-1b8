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
    /// Interaction logic for fight_win.xaml
    /// </summary>
    public partial class fight_win : Page
    {
        public fight_win()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartScreen());
        }
    }
}
