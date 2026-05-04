using System;
using System.IO;

namespace GymMaster.Models
{
    public class Member : Person
    {
      
        public SubscriptionPlan PlanType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public override string GetRecordString()
        {
           
            return $"{Name}|{Phone}|{PlanType.ToString()}|{StartDate.ToShortDateString()}|{EndDate.ToShortDateString()}|{Price}";
        }

        public void SaveToFile()
        {
            string record = GetRecordString();
            File.AppendAllText("Subscribers.txt", record + Environment.NewLine);
        }
    }
}