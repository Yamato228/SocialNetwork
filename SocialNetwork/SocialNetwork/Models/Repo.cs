using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.Models
{
    public class Repo
    {
        public static ICollection<Message> Messages { get; } = new HashSet<Message>();

        static Repo()
        {
            Messages.Add(new Message()
            {
                Id = Guid.NewGuid(),
                Text = "Test note",
                Author = "SYSTEM"
            });
        }
    }
}