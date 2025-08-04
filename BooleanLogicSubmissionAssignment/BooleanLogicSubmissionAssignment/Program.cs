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
            Console.WriteLine("What is your age?");
            string customerAge = Console.ReadLine();
            int custAge = Convert.ToInt32(customerAge);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? (true/false)");
            string customerDUI = Console.ReadLine();
            bool custDUI = Convert.ToBoolean(customerDUI);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string customerTickets = Console.ReadLine();
            int custTickets = Convert.ToInt32(customerTickets);
            Console.ReadLine();

            bool qualifiesForInsurance = (custAge > 15 && !custDUI && custTickets <= 3);
            Console.WriteLine("Customer qualifies for insurance: " + qualifiesForInsurance);
        }
    }
}
