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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
           
           
        }
        //variables
        public static string currentUserName;
        private string errorMessage;
        private bool errorFlag = false;
        public static void SetPage(Page page)
        {
            MainWindow aWindow = Application.Current.MainWindow as MainWindow;
            aWindow.Content = page;
        }

        private void loginClick(object sender, RoutedEventArgs e)
        {
            //clear errors to avoid concatenating current error message
            lblUserError.Content = "";
            errorFlag = false;
            //check credentials of user and if valid load the lobbies page.

            if (Textboxusername.Text.Length == 0)
            {
                errorMessage += "Please enter a Username. ";
                errorFlag = true;
                lblUserError.Content = errorMessage;
            }
            else if (Textboxpassword.Text.Length == 0)
            {
                errorMessage += "Please enter a Password. ";
                errorFlag = true;
                lblUserError.Content = errorMessage;
            }

            //there is entry in both textboxes. Check if valid
            if(errorFlag == false)
            {
                //clear error box
                lblUserError.Content = "";
                //temporarily create a user while the database is not available.
                User auser = new User(Textboxusername.Text, Textboxpassword.Text);
                //use prepared statement / query database with entered values.
                currentUserName = Textboxusername.Text;
                LobbiesPage lobbies = new LobbiesPage();
                MainWindow.SetPage(lobbies);
                

            }


        }

        private void registerClick(object sender, RoutedEventArgs e)
        {
            RegisterPage register = new RegisterPage();
            MainWindow.SetPage(register);
        }
    }
}
