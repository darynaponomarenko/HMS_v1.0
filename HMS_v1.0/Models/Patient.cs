﻿using System;
using System.ComponentModel;
using System.Numerics;

namespace HMS_v1._0.Models
{
    public class Patient 
    {
        public string? Name { get; set; }
        public string? MiddleName { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Pesel { get; set; }

        public DateTime DateOfBirth { get; set; }

        
    }
}
