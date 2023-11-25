using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Employee
    {
        public string name;
        public int age;
        public double salary;

        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Зарплата: {salary}");
        }

        public virtual double CalculateAnnualSalary()
        {
            return salary * 12;
        }
    }
}
