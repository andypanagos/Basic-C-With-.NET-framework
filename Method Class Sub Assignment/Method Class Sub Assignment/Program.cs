using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Sub_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Math newMath = new Math();

            newMath.Mathop(4, 9);

            newMath.Mathop(numOne, numTwo);
            Console.ReadLine();
        }
       
    }
    
}
