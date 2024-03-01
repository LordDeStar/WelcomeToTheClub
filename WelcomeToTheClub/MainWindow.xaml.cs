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
        
        private static Button _registrUserBut = null!;
        private static Button _registrComapnyBut = null!;
        private static Frame _mainWin = null!;

        public static Button RegistrComapnyBut
        {
            get
            {
                return _registrComapnyBut;
            }
        }
        public static Button RegistrUserBut
        {
            get
            {
                return _registrUserBut;
            }
        }

        public static Frame MainWin
        {
            get
            {
                return _mainWin;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            _registrComapnyBut = regCompanyBut;
            _registrUserBut = regUserBut;
            _registrComapnyBut.Visibility = Visibility.Hidden;
            _registrUserBut.Visibility = Visibility.Hidden;
            _mainWin = MainFrame;
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
