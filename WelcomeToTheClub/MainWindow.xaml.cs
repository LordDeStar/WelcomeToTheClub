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
using WelcomeToTheClub.Controllers;
using WelcomeToTheClub.Views.Pages;
namespace WelcomeToTheClub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame MainWin = null!;
        public MainWindow()
        {
            InitializeComponent();
            MainWin = MainFrame;
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

            MainWin.Navigate(AuthorizationPage.Instance);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWin.Navigate(AuthorizationPage.Instance);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWin.Navigate(RegistrationPage.Instance);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWin.Navigate(RegistartionCompanyPage.Instance);
        }
    }
}
