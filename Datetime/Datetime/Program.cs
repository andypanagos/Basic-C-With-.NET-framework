using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);

            Console.WriteLine("please enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("in " + userInput + " hours it will be " + DateTime.Now.AddHours(userInput));
            Console.ReadLine();

        }
    }
}
