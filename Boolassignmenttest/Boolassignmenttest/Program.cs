using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolassignmenttest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32

            
            Console.WriteLine("Have you ever had a DUI? \n Please enter true or false.");
            string 
            bool dui = Convert.ToBoolean(Console.ReadLine());

            if (dui)
            {
                Console.WriteLine("False");
            }
            else if (!dui)
            {
                Console.WriteLine("");
            }


            Console.WriteLine("How many speeding tickets have you had?");
            int ticket;

            ticket = Convert.ToInt32(Console.ReadLine());
            bool YesOrNo = ticket <= 3;

            Console.ReadLine();

            if (x > 15)
                if (dui == "false")
                    if (ticket <= 3)
                    {
                        Console.WriteLine("Qualified.");
                    }

                    else if (ticket <= 3)
                    {
                        Console.WriteLine("Not Qualified");

                    }

                    else if (dui == "true")
                    {
                        Console.WriteLine("Not Qualified");
                    }
            if (x < 15)
            {
                Console.WriteLine("Not Qualified");
            }

            Console.ReadLine();
        }
    }
}
