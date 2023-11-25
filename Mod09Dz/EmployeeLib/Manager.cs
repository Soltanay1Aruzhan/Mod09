using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Manager : Employee
    {
        public double bonus;

        public Manager(string name, int age, double salary, double bonus)
            : base(name, age, salary)
        {
            this.bonus = bonus;
        }

        public override double CalculateAnnualSalary()
        {
            return salary * 12 + bonus;
        }

    }
}
