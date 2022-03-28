using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlackJackApp2._0
{
    /// <summary>
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        public GamePage()
        {
            InitializeComponent();
            // Just for now we will set the logged in user as user 1 as only 1 player can play atm.
            User1.Content = MainMenu.currentUserName;
        }

        private void Split_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Hit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stand_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
