using MERCHANT_QUESTS01;
using MerchantQuest;
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

namespace Merchant_Quest
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

    

   

        private void fightbutton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Fight());
        }
        //navigates to Startscreen
        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartScreen());
        }

        //navigates to Settings
        private void settingsbutton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }
        //navigates to Shop
        private void shopbutton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new shop());
        }
    }



}


