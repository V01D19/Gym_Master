using System;
using System.Collections.Generic;
using System.Text;

namespace GymMaster.Models
{
    public class Member : Person
    {
        public string? PlanType { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
