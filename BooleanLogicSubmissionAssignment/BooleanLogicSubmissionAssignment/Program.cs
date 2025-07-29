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
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("How many speeding tickets do you have?");
            Console.ReadLine();

            //Boolean variables
            int customerAge = 21;
            bool hasDUI = false;
            int speedingTickets = 0;

            //Boolean logic
            bool qualifiesForInsurance = (customerAge > 15 && !hasDUI && speedingTickets <= 3);
            Console.WriteLine("Customer qualifies for insurance: " + qualifiesForInsurance);
        }
    }
}
