﻿using System;
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
        public static void SetPage(Page page)
        {
            MainWindow aWindow = Application.Current.MainWindow as MainWindow;
            aWindow.Content = page;
        }

        private void loginClick(object sender, RoutedEventArgs e)
        {
            //check credentials of user and if valid load the lobbies page.
            LobbiesPage lobbies = new LobbiesPage();
            MainWindow.SetPage(lobbies);
        }

        private void registerClick(object sender, RoutedEventArgs e)
        {
            RegisterPage register = new RegisterPage();
            MainWindow.SetPage(register);
        }
    }
}
