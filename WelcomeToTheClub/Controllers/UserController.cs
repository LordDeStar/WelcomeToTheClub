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
            using (DataBaseController db = new DataBaseController())
            {
                var users = db.SelectUsers();
                var roles = db.Roles();
                foreach(var i in users)
                {
                    if (i.login.Equals(login) && i.pass.Equals(password))
                    {
                        var currentRole = roles.First(r => r.role_id == i.role_id).role_name;
                        if (currentRole == "manager")
                        {
                            return new MainContent();
                        }
                        else
                        {
                            return new ErrorPage();
                        }
                    }
                }
                return new ErrorPage();
            }
        }

        public static bool RegestrationUser(string login, string pass, int company, int role)
        {
            using (DataBaseController db = new DataBaseController())
            {
                var users = db.SelectUsers();
                int id = users.Last().user_id + 1;
                var user = new UserModel { login = login, user_id = id, pass = pass, company_id = company, role_id = role };

                if (users.Any(u => u.login == user.login))
                {
                    return false;
                }
                else
                {
                    db.RegistrUser(user);
                    return true;
                }
                
            }
           
        }

    }
}
