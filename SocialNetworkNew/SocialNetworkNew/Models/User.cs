using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetworkNew.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}