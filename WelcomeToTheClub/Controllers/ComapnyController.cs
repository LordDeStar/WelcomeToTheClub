using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeToTheClub.Models;

namespace WelcomeToTheClub.Controllers
{
    class ComapnyController
    {
        public static bool RegistrCompany(string name)
        {
            using (DataBaseController db = new DataBaseController())
            {
                var companies = db.SelectCompanies();
                if (companies.Any(c => c.company_name == name))
                {
                    return false;
                }
                else
                {
                    int id = db.SelectCompanies().Last().company_id + 1;
                    var company = new CompanyModel { company_id = id, company_name = name };
                    db.RegistrCompany(company);
                    return true;
                }
            }
        }

    }
}
