using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WelcomeToTheClub.Views.Pages;

namespace WelcomeToTheClub.Controllers
{
    public class ManagerController
    {
        public static Page Main()
        {
            return MainContent.Instance;
        }
    }
}
