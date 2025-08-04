using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.");
            Console.ReadLine();

            Console.WriteLine("What is the weight of your package?");
            string packageWeight = Console.ReadLine();
            int packWeight = Convert.ToInt32(packageWeight);
            Console.ReadLine();

            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the width of your package?");
                string packageWidth = Console.ReadLine();
                int packWidth = Convert.ToInt32(packageWidth);
                Console.ReadLine();
                Console.WriteLine("What is the height of your package?");
                string packageHeight = Console.ReadLine();
                int packHeight = Convert.ToInt32(packageHeight);
                Console.ReadLine();
                Console.WriteLine("What is the length of your package?");
                string packageLength = Console.ReadLine();
                int packLength = Convert.ToInt32(packageLength);
                Console.ReadLine();
                if (packWidth + packHeight + packLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int totalCost = (packWidth * packHeight * packLength * packWeight) / 100;
                    Console.WriteLine($"Your estimated total for shipping this package is: ${totalCost}");
                    Console.ReadLine();
                }
            }
        }
    }
}
