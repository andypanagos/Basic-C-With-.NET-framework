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
            

            Console.WriteLine("Anonymous income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1: \nHourly Rate: 20 dollars \nHours Worked per Week: 25 Hours");
            Console.ReadLine();

            Console.WriteLine("Person 2: \nHourly Rate: 17 dollars \nHours Worked per Week: 20 Hours");
            Console.ReadLine();

            Console.WriteLine("Annual Salary Person 1: \n26,000");
            Console.ReadLine();

            Console.WriteLine("Annual Salary Person 2: \n17,000");
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();

            int person1 = 26000;
            int person2 = 17000;

            bool moreMoney = person1 > person2;
            Console.WriteLine(moreMoney);
            Console.ReadLine();


        }
    }
}
