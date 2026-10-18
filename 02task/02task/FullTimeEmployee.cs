using System;
using System.Collections.Generic;
using System.Text;

namespace _02task
{
    public class FullTimeEmployee : Employee ,IWorkable
    {
        public double MonSalary {  get; set; }
        public FullTimeEmployee(int id, string name,double monSalary) : base(id, name)
        {
            MonSalary = monSalary;
        }

        public override double CalculateSalary()
        {
            return MonSalary;
        }


        public override void DisplayInfo()
        {
            Console.WriteLine($"Employee ID:{Id},Employee Name:{Name},Employee salary:{CalculateSalary()},type:{Work()}");
        }
        public string Work()
        {

            return "Full Timer";
        }
    }
}
