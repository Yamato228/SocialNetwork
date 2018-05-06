using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.Models
{
    public class AuthLogic
    {
        public static bool CanAuthenticate(string userName, string password)
        {
            return userName == password;
        }
    }
}