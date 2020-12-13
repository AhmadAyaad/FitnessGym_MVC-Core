using FitnessGym.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessGym.Web.ViewModel
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public int Age { get; set; }
        public DateTime MemeberShipStartDate { get; set; }
        public DateTime MemeberShipEndDate { get; set; }
        public string CustomerName { get; set; }
        public int Phone { get; set; }
        public string HealthStatus { get; set; }
        public MemberShipType MemberShipType { get; set; }
        public List<Coach> Coaches { get; set; }
        public int CoachId { get; set; }

    }
        
}
