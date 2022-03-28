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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
          
        }

        string errorMessage;

        private void registerClick(object sender, RoutedEventArgs e)
        {
            bool errorFlag = false;
            //validate form
            if(textBoxName.Text.Length == 0)
            {
                errorMessage += "Please enter a Username. ";
                errorFlag = true;
                lblUserError.Content = errorMessage;
            }
            else if(textBoxPassword.Text.Length == 0)
            {
                errorMessage += "Please enter a Password. ";
                errorFlag = true;
                lblUserError.Content = errorMessage;
            }
            else if (textBoxConfirmPassword.Text.Length == 0)
            {
                errorMessage += "Please confirm your password. ";
                errorFlag = true;
                lblUserError.Content = errorMessage;
            }

            //ensure that the passwords match
            if (errorFlag == false)
            {
                if(textBoxPassword.Text != textBoxConfirmPassword.Text)
                {
                    errorMessage += "Please match your passwords. ";
                    errorFlag = true;
                    lblUserError.Content = errorMessage;
                }
               
            }
            //form is good and the passwords match
            if (errorFlag == false)
            {
                //instantiate a new user and add them to a list of users (for now).
                User auser = new User(textBoxName.Text, textBoxPassword.Text);
                //inform the user of success
                MessageBox.Show("User Registered");
               // User.users.Add(auser); commented out since this will be scrapped when database is added.
               //load game page after creating the user.
                MainMenu mainMenu = new MainMenu();
                MainWindow.SetPage(mainMenu);
            }
           
        }
      
      
    }
}
