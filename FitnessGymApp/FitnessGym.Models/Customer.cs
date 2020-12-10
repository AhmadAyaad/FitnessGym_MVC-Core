using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessGym.Models
{
   public class Customer
    {
        public int CustomerId { get; set; }
        public int Age { get; set; }
        public DateTime MemeberShipStartDate { get; set; }
        public DateTime MemeberShipEndDate { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public int Phone { get; set; }
        [Required]
        public string HealthStatus { get; set; }
        public MemberShipType MemberShipType { get; set; }
        public int? CoachId { get; set; }
        public Coach Coach { get; set; }


    }
}
