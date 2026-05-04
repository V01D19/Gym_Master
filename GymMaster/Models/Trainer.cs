using System;

namespace GymMaster.Models
{
   
    public class Trainer : Person
    {
        public string? Specialization { get; set; }
        public decimal Salary { get; set; }

   
        public override string GetRecordString()
        {
            return $"{Name}|{Specialization}|{Salary}|{Phone}";
        }

        public override string GetDisplayInfo()
        {
            return $"{base.GetDisplayInfo()} | Specialization: {Specialization} | Salary: {Salary} EGP";
        }
    }
}
