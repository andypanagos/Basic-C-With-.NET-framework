using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mathOperations = new Math();

            Console.WriteLine("50 plus 50 is: " + mathOperations.Math1(50));

            Math mathOperations2 = new Math();

            Console.WriteLine("53.6 divided by 5 is: " + mathOperations2.Math1(53.6));

            Math mathOperations3 = new Math();

            Console.WriteLine("String value of twenty plus 100 is: " + mathOperations3.Math1("20"));

            Console.ReadLine();
        }
        
    }
}
