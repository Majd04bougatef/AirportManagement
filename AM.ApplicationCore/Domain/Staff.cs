using System;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public string Function { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                   $" | Function: {Function}, Salary: {Salary}, EmploymentDate: {EmploymentDate}";
        }
    }
}
