using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WelcomeToTheClub.Views.Pages;
using System.Windows;
namespace WelcomeToTheClub.Controllers
{
    public class ManagerController
    {
        public static Page MainPage()
        {
            MainWindow.RegistrUserBut.Visibility = Visibility.Visible;
            MainWindow.RegistrComapnyBut.Visibility = Visibility.Visible;
            return MainContent.Instance;
        }
    }
}
