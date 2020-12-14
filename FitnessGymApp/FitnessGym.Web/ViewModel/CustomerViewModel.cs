using FitnessGym.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessGym.Web.ViewModel
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Membership Start date")]
        public DateTime MemeberShipStartDate { get; set; }
        [Display(Name = "Membership End date")]
        public DateTime MemeberShipEndDate { get; set; }
        [Display(Name = "Customer Name")]
        [Required]
        public string CustomerName { get; set; }
        [RegularExpression(@"^01[0-2][0-9]{8}$|^01[5][0-9]{8}$", ErrorMessage = "Please enter a valid phone number")]
        public int Phone { get; set; }
        [Display(Name = "Health Status")]
        public string HealthStatus { get; set; }
        [Display(Name = "Memebership type")]
        public MemberShipType MemberShipType { get; set; }
        public List<Coach> Coaches { get; set; } = new List<Coach>();
        public int CoachId { get; set; }

    }

}
