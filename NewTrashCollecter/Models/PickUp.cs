using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewTrashCollecter.Models
{
    public class PickUp
    {
        [Key]
        public string Id { get; set; }
        public DayOfWeek PickupDay { get; set; }
        [Display(Name = "Special Pickup")]

        public DateTime? SpecialPickup { get; set; }

        public DateTime? StartPickupDay { get; set; }

        public DateTime? EndPickupDay { get; set; }

        [Display(Name = "Pickup Date")]
        public DateTime? PickupDate { get; set; }

        [Display(Name = "Day of Week Pickup")]
        public DayOfWeek WeeklyPickUp { get; set; }
        [Display(Name = "Begining of Suspended Day")]
        public DateTime? StartSuspendDate { get; set; }
        [Display(Name = "End of Suspended Day")]
        public DateTime? EndSuspendDate { get; set; }
        [Display(Name = "Pickup Status")]
        public bool CompfirmPickup { get; set; }
        
        [Display(Name = "Pickup Charge")]
        public double PickupCharge { get; set; }

        [Display(Name = "Zipcode")]
        public string Zipcode { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        

    }
}