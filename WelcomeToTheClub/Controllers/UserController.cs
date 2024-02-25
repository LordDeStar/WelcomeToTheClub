using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WelcomeToTheClub.Models;
using WelcomeToTheClub.Views;
using WelcomeToTheClub.Views.Pages;
namespace WelcomeToTheClub.Controllers
{
    // В этом классе находится вся логика работы с пользователями.
    public class UserController
    {
        public static Page Authorization(string login, string password)
        {
            List<UserModel> users = DataBaseController.SelectUsers();
            foreach(var i in users)
            {
                if (i.Login.Equals(login) && i.Password.Equals(password))
                {
                    return new MainContent();
                }
            }
            return new ErrorPage();
        }
    }
}
