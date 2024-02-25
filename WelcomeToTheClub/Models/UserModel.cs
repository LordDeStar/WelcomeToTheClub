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
        public string Login { get; set; }
        public int ID { get; set; }
        public string Company { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        
    }
}
