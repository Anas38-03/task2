using _02task;
namespace _02task
{
    public class PartTimeEmployee : Employee , IWorkable
    {
        public double Hoursalary {  get; set; }
        public double Rate {  get; set; }
        public PartTimeEmployee(int id, string name,double hoursalary,double rate) : base(id, name)
        {
            Rate = rate;
            Hoursalary = hoursalary;
        }

 

        public override double CalculateSalary()
        {
            _salary= Rate * Hoursalary;
            return _salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Employee ID:{Id},Employee Name:{Name},Employee salary:{CalculateSalary()},type:{Work()}");
        }
        public string Work()
        {
            
            return "Part Timer";
        }
    }
}
