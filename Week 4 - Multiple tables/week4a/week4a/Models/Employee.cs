﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace week4a.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
    }
}