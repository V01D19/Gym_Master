using System;

namespace GymMaster.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PlanType { get; set; } // شهر، 3 شهور، سنة
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}