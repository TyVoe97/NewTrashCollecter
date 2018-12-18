using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewTrashCollecter.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
    
        public string Name { get; set; }
      public string Address { get; set; }
        public string Zipcode { get; set; }
        
       
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
         public string Balance { get; set; }
        
        

        [ForeignKey("ApplicationUser")]
        public string ApplicationCustomerId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}