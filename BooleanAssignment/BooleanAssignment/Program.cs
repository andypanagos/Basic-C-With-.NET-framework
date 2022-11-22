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
            int x;

            x = Convert.ToInt32(Console.ReadLine());
            bool TrueOrFalse = x > 15;

            string dui = null;
            Console.WriteLine("Have you ever had a DUI?");
            dui = Console.ReadLine();
            if (dui == "no")
            {
                Console.WriteLine("False");
            }
            else if (dui == "yes")
            {
                Console.WriteLine("");
            }


            Console.WriteLine("How many speeding tickets have you had?");
            int ticket;

            ticket = Convert.ToInt32(Console.ReadLine());
            bool YesOrNo = ticket <= 3;

            Console.ReadLine();

            if (x > 15)
                if(dui == "no")
                    if(ticket <= 3)
                    {
                        Console.WriteLine("Qualified.");
                    }

                    else if (ticket <= 3)
                    {
                        Console.WriteLine("Not Qualified");

                    }
                    
                    else if (dui == "yes")
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
