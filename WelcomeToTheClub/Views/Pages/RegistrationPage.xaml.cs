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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        private static RegistrationPage _instance = null!;
        public static RegistrationPage Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new RegistrationPage();
                }
                _instance.Init();
                return _instance;
            }
        }
        private RegistrationPage()
        {
            InitializeComponent();
                
        }

        private void Init()
        {
            using (DataBaseController db = new DataBaseController())
            {
                company.ItemsSource = db.SelectCompanies().Select(u => u.company_name);
                role.ItemsSource = db.Roles().Select(u => u.role_name);
            }
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            var log = login.Text;
            var password = pass.Text;
            var selectedRole = role.SelectedIndex + 1;
            var selectedCompany = company.SelectedIndex + 1;

            if (UserController.RegestrationUser(log, password, selectedCompany, selectedRole))
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
