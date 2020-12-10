using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessGym.Models
{
    public class Coach
    {
        public int CoachId { get; set; }
        [Required]
        public string CoachName { get; set; }
        public DateTime StartWorkingDate { get; set; }

        public IEnumerable<Customer> Customers { get; set; }

        public override string ToString()
        {
            return $"{CoachName }";
        }

    }
}

