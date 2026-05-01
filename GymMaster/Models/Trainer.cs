using System;
using System.Collections.Generic;
using System.Text;

namespace GymMaster.Models
{
    public class Trainer : Person
    {
        public string Specialization { get; set; }
        public decimal Salary { get; set; }
    }
}
