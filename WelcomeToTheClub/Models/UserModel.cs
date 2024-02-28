using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace WelcomeToTheClub.Models
{
    public class UserModel
    {
        public string login { get; set; }
        public int user_id { get; set; }
        public int company_id { get; set; }
        public string pass { get; set; }
        public int role_id { get; set; }
        
    }
}
