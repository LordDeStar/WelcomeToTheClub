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
    /// <summary>
    /// Логика взаимодействия для RegistartionRolePage.xaml
    /// </summary>
    public partial class RegistartionRolePage : Page
    {
        private static RegistartionRolePage _instance = null!;
        public static RegistartionRolePage Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new RegistartionRolePage();
                }
                return _instance;
            }
        }

        public RegistartionRolePage()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            var name = role.Text;
            if (RoleController.RegistrRole(name))
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
