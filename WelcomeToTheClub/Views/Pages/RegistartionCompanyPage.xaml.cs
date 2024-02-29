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
namespace WelcomeToTheClub.Views.Pages
{
    public partial class RegistartionCompanyPage : Page
    {
        private static RegistartionCompanyPage _instance = null!;
        public static RegistartionCompanyPage Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new RegistartionCompanyPage();
                }
                return _instance;
            }
        }

        private RegistartionCompanyPage()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            var name = company.Text;
            if (ComapnyController.RegistrCompany(name))
            {
                MessageBox.Show("Successfull");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
