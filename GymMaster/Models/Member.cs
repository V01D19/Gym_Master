using System;

namespace GymMaster.Models
{
   
    public class Member : Person
    {
        public string? PlanType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }


        public override string GetRecordString()
        {
            return $"{Name}|{Phone}|{PlanType}|{StartDate.ToShortDateString()}|{EndDate.ToShortDateString()}|{Price}";
        }

        public override string GetDisplayInfo()
        {
            return $"{base.GetDisplayInfo()} | Plan: {PlanType} | Expires: {EndDate.ToShortDateString()}";
        }
    }
}