﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BiSanat.DAL.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string DeviceToken { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Gender { get; set; }
    }
}
