﻿using System;
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
using WelcomeToTheClub.Controllers;

namespace WelcomeToTheClub.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {

        private static AuthorizationPage _instance = null!;
        public static AuthorizationPage Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new AuthorizationPage();
                }
                return _instance;
            }
        } 
        private AuthorizationPage()
        {
            InitializeComponent();
        }

        private void auth_Click(object sender, RoutedEventArgs e)
        {
            var page = UserController.Authorization(LoginBox.Text, PasswordBox.Text);
            MainWindow.MainWin.Navigate(page);
        }
    }
}
