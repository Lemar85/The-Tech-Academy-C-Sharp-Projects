using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmissionAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Do you qualify for car insurance?");
            Console.ReadLine();
            Console.WriteLine("What is your age?");
            int customerAge = 21;
            Console.WriteLine(customerAge);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            bool hasDUI = false;
            Console.WriteLine(hasDUI);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = 0;
            Console.WriteLine(speedingTickets);
            Console.ReadLine();

            bool qualifiesForInsurance = (customerAge > 15 && !hasDUI && speedingTickets <= 3);
            Console.WriteLine("Customer qualifies for insurance: " + qualifiesForInsurance);
        }
    }
}
