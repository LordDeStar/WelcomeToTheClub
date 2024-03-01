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

namespace WelcomeToTheClub.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainContent.xaml
    /// </summary>
    public partial class MainContent : Page
    {
        private static MainContent _instance = null!;
        public static MainContent Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new MainContent();
                }
                return _instance;
            }
        }

        private MainContent()
        {
            InitializeComponent();
        }
    }
}
