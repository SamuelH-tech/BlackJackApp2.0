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
    /// Interaction logic for LobbiesPage.xaml
    /// </summary>
    public partial class LobbiesPage : Page
    {
        public LobbiesPage()
        {
            InitializeComponent();
            lblUserName.Content = MainMenu.currentUserName;
        }

        private void Create_Game(object sender, RoutedEventArgs e)
        {
            GamePage game = new GamePage();
            MainWindow.SetPage(game);
        }

      
    }
}
