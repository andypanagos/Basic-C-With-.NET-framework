using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int fifty, num1, num2, num3, num4, num5 ;

            Console.WriteLine("Enter a Number");
            num1 = int.Parse(Console.ReadLine());

            fifty = num1 * 50;
            Console.WriteLine("your number times 50 is " + fifty);
            Console.ReadLine();

            Console.WriteLine("Enter a Number");
            num2 = int.Parse(Console.ReadLine());

            int total = num2 + 25;
            Console.WriteLine("your number plus 25 is " + total);


            Console.WriteLine("Enter a Number");
            num3 = int.Parse(Console.ReadLine());

            double v = num3 / 12.5;
            Console.WriteLine("your number divided by 12.5 is " + v);

            Console.WriteLine("Check if your number is greater than 50");
            num4 = int.Parse(Console.ReadLine());

            bool trueOrFalse = num4 > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a Number");
            num5 = int.Parse(Console.ReadLine());

            int remainder = num5 % 7;
            Console.WriteLine("your number divided by seven has the remainder of " + remainder);
            Console.ReadLine();
        }
    }
}
