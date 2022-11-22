using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate");
            int personRate1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Weekly Hours:");
            int personWeek1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate");
            int personRate2 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Weekly Hours");
            int personWeek2 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Annual salary of Person 1:");
            int annual1 = personRate1 * personWeek1 * 52;
            Console.WriteLine(annual1);

            Console.WriteLine("Annual salary of Person 2:");
            int annual2 = personRate2 * personWeek2 * 52;
            Console.WriteLine(annual2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salary = annual1 > annual2;
            Console.WriteLine(salary);

            Console.ReadLine();


        }
    }
}
