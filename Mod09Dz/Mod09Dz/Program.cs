using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace Mod09Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Kolya Manager", 23, 50000, 5000);
            Developer developer = new Developer("Alisher Developer", 21, 60000, 100);

            Console.WriteLine("Manager");
            manager.GetInfo();
            Console.WriteLine($"Жылдық жалақы бонусты қосқанда: {manager.CalculateAnnualSalary()}");

            Console.WriteLine("\nDeveloper");
            developer.GetInfo();
            Console.WriteLine($"Жазылған код жолдарының санына негізделген жылдық жалақы: {developer.CalculateAnnualSalary()}");

            Console.ReadLine();
        }
    }
}
