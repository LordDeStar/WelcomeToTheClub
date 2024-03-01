using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeToTheClub.Models;

namespace WelcomeToTheClub.Controllers
{
    class RoleController
    {
        public static bool RegistrRole(string name)
        {
            using (DataBaseController db = new DataBaseController())
            {
                var roles = db.roles.ToList();

                if (name.Equals(string.Empty) || roles.Any(r => r.role_name.Equals(name)))
                {
                    return false;
                }
                int id = roles.Last().role_id + 1;
                var role = new RoleModel { role_id = id, role_name = name };

                db.roles.Add(role);
                db.SaveChanges();
                return true;
            }
        }

    }
}
