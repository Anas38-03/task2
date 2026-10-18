using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _02task
{
    public abstract class Employee:IWorkable
    {
        private double salary {  get; set; }
        public double _salary
        {
            get {
                return salary;
            }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            } 
            
        }
        public int Id {  get; set; }
        public string Name { get; set; }
        public Employee(int id,string name)
        {
            Name = name;
            Id = id;
        }
        public abstract void DisplayInfo();
         public abstract double CalculateSalary();

        public string Work()
        {
            throw new NotImplementedException();
        }
    }
}
