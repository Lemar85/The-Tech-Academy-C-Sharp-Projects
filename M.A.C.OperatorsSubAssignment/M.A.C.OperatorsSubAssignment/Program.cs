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
            int person1HourlyRate = 19;
            int person1HoursPerWeek = 40;
            Console.WriteLine("Hourly Rate: " + person1HourlyRate);
            Console.ReadLine();
            Console.WriteLine("Hours worked per week: " + person1HoursPerWeek);
            Console.ReadLine();

            Console.WriteLine("Person_2");
            Console.ReadLine();
            int person2HourlyRate = 20;
            int person2HoursPerWeek = 40;
            Console.WriteLine("Hourly Rate: " + person2HourlyRate);
            Console.ReadLine();
            Console.WriteLine("Hours worked per week: " + person2HoursPerWeek);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person_1:");
            Console.ReadLine();
            int product = person1HourlyRate * person1HoursPerWeek * 52;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person_2:");
            Console.ReadLine();
            int product2 = person2HourlyRate * person2HoursPerWeek * 52;
            Console.WriteLine(product2);
            Console.ReadLine();

            Console.WriteLine("Does Person_1 make more money than Person_2?");
            Console.ReadLine();
            bool TrueOrFalse = product > product2;
            Console.WriteLine(TrueOrFalse);
            Console.Read();
        }
    }
}
