using System;
using System.Collections.Generic;
using System.Text;

namespace DOND
{
    public class Case
    {
        public double DollarAmount { get; set; }
        public int Name { get; set; }
        public bool IsOpen { get; set; }

        public Case(double amount, int name)
        {
            this.Name = name; 
            this.DollarAmount = amount;
            this.IsOpen = false; 
        }

        
    }
}
