using System;

namespace GymMaster.Models
{
    
    public abstract class Person
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }

    
        public abstract string GetRecordString();

    
        public virtual string GetDisplayInfo()
        {
            return $"Name: {Name} | Phone: {Phone}";
        }
    }
}