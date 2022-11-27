using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Sub_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate
            Math newMath = new Math();

            //Ask for numbers
            Console.WriteLine("Enter a number... ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number. Optional.");
            string opAnswer = null;
            int tempNum = 0;
            //try loop using the integer provided, turning it into a temporary variable
            try
            {
                opAnswer = Console.ReadLine();
                tempNum = Convert.ToInt32(opAnswer);
            }
            catch(Exception)
            {
            }
            int num2 = tempNum;
            int total;

            if(opAnswer == null)
            {
                total = newMath.MathMethod(num1);
                Console.WriteLine("Your total is: {0}", total);
            }
            else
            {
                total = newMath.MathMethod(num1, num2);
                Console.WriteLine("total is: {0}. and second number is: {1}", total, num2);
            }
            Console.ReadLine();
        }
    }
}
