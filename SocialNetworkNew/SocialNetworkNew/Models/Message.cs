using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetworkNew.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
    }
}