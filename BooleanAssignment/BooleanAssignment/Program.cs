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



            Console.WriteLine("What is your age?");
            string answer = Console.ReadLine();
            int age = Convert.ToInt32(answer);

            

            
            Console.WriteLine("Have you ever had a DUI? \n Please answer True or False.");
            string duiAnswer = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiAnswer);
            

            Console.WriteLine("How many speeding tickets have you had?");
            string speeding = Console.ReadLine();
            int ticket = Convert.ToInt32(speeding);

            Console.WriteLine("Are you qualified?");

            bool qualified = (age > 15 && dui == false && ticket <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();

            
        }
    }
}
