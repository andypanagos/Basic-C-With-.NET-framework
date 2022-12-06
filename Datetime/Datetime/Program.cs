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
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("in " + x + " hours it will be " + DateTime.Now.AddHours(x));
            Console.ReadLine();

        }
    }
}
