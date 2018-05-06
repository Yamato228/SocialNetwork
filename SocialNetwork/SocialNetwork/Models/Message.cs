﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
    }
}