﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTR.Models
{
   public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
    }
}
