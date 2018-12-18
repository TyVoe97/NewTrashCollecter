﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewTrashCollecter.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Zipcode { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationEmployeeId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}