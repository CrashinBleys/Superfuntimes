using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"hello, {name}");

            Console.WriteLine("Are you male or female?");

            var sex = Console.ReadLine();

            if (sex == "male")
            {
                Console.WriteLine("Welcome to the kingdom my lord.");
            }
            else if(sex == "female")
            {
                Console.WriteLine("How fairs thee my lady?");
            }
            else
            {
                Console.WriteLine("what are you, a coconut?");
            }

            // the end...
            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }
    }
}
