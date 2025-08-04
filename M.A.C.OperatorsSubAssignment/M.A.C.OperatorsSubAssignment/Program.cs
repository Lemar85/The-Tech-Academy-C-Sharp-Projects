using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.A.C.OperatorsSubAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person_1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate:");
            string person1HourlyRate = Console.ReadLine();
            int person1HourlyRateInt = Convert.ToInt32(person1HourlyRate);
            Console.WriteLine("Hours worked per week:");
            string person1HoursWorked = Console.ReadLine();
            int person1HoursWorkedInt = Convert.ToInt32(person1HoursWorked);
            Console.ReadLine();

            Console.WriteLine("Person_2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate:");
            string person2HourlyRate = Console.ReadLine();
            int person2HourlyRateInt = Convert.ToInt32(person2HourlyRate);
            Console.WriteLine("Hours worked per week:");
            string person2HoursWorked = Console.ReadLine();
            int person2HoursWorkedInt = Convert.ToInt32(person2HoursWorked);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person_1:");
            Console.ReadLine();
            int product1 = person1HourlyRateInt * person1HoursWorkedInt * 52;
            Console.WriteLine(product1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person_2:");
            Console.ReadLine();
            int product2 = person2HourlyRateInt * person2HoursWorkedInt * 52;
            Console.WriteLine(product2);
            Console.ReadLine();

            Console.WriteLine("Does Person_1 make more money than Person_2?");
            Console.ReadLine();
            bool TrueOrFalse = product1 > product2;
            Console.WriteLine(TrueOrFalse);
            Console.ReadLine();
        }
    }
}
