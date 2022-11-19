using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int age, ticket;

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());


            Console.WriteLine("Have you ever had a DUI?");
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets have you had?");
            ticket = int.Parse(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.ReadLine();

            bool dui = false;
            bool T = ticket <= 1;
            bool qualified = (age >= 15 || dui || T);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
