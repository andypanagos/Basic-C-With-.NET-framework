using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for number to operate math equation
            Console.WriteLine("What number do you want to add 5 to?");
            //convert string variabe input to integer
            int answer = Convert.ToInt32(Console.ReadLine());
            //create new variable that calls method of math operation with the inputted integer
            int doMath = Math.Math1(answer);
            Console.WriteLine("Your number plus 5 is: " + doMath);
            Console.ReadLine();

            //All repeated steps here 
            Console.WriteLine("select number to multiply by 5 ");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            int doMath2 = Math.Math2(answer2);
            Console.WriteLine("Your number muliplied by 5 is: " + doMath2);
            Console.ReadLine();

            Console.WriteLine("What number would you like to divide by 2?");
            int answer3 = Convert.ToInt32(Console.ReadLine());
            int doMath3 = Math.Math3(answer3);
            Console.WriteLine("Your number divided by 2 is: " + doMath3);
            Console.ReadLine();
        }
    }
}
