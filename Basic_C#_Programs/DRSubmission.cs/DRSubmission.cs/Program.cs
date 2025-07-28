using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRSubmission.cs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Thank you!: " + yourName);
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("I hope you are learning a lot in: " + yourCourse);
            Console.ReadLine();
            Console.WriteLine("What page number?");
            string yourPageNumber = Console.ReadLine();
            Console.WriteLine("Nice job making it to: " + yourPageNumber);
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string yourHelp = Console.ReadLine();
            bool helpNeeded;
            if (bool.TryParse(yourHelp, out helpNeeded))
            {if (helpNeeded)
                {
                    Console.WriteLine("We will have and instructor reach out to you shortly.");
                }
                else
                { Console.WriteLine("keep up the good work!"); }
            }
            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();
            Console.WriteLine("Thank your for sharing: " + yourExperience);
            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback");
            Console.WriteLine("How many hours did you study today?");
            string yourHours = Console.ReadLine();
            Console.Write("Great job studying for: " + yourHours + "today!");
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

        }
    }
}
