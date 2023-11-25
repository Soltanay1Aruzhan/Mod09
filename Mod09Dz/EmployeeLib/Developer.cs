using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Developer : Employee
    {
        private int linesOfCodePerDay;

        public Developer(string name, int age, double salary, int linesOfCodePerDay)
            : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        public override double CalculateAnnualSalary()
        {
            return base.CalculateAnnualSalary() + (linesOfCodePerDay * 0.1 * 240); // 240 рабочих дней
        }
    }
}
