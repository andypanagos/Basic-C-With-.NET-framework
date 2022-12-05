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
            int num1 = 50;

            Math mathOperations = new Math();
            

            int answer1 = mathOperations.Math1(num1);
            Console.WriteLine("50 plus 50 equals: " + answer1);
            Console.ReadLine();

            //Math mathOperations2 = new Math();
            //Console.WriteLine("50 divided by 5 equals: " + mathOperations2.Math2(50.5));
            

            decimal num2 = 50;
            int answer2 = mathOperations.Math2(num2);
            Console.WriteLine("50 divided by 5 equals: " + answer2);
            Console.ReadLine();


            int answer3 = mathOperations.Math3("50");
            Console.WriteLine("50 plus 100 equals: " + answer3);
            Console.ReadLine();

  
        }
    }
}
