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
                var companies = db.companies.ToList();
                if (name.Equals(string.Empty) || companies.Any(c => c.company_name.Equals(name)))
                {
                    return false;
                }
                else
                {
                    int id = companies.Last().company_id + 1;
                    var company = new CompanyModel { company_id = id, company_name = name };
                    db.companies.Add(company);
                    db.SaveChanges();
                    return true;
                }
            }
        }

    }
}
