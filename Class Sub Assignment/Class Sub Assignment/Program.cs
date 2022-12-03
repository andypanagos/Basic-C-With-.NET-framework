using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Sub_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 firstclass = new Class1();

            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number divided by 2 is: ");
            firstclass.Math1(x);
            Console.ReadLine();

            int num = 0;

            firstclass.Math2(out num);
            Console.WriteLine(num);

            Class1 secondClass = new Class1();
            Console.WriteLine("Enter decimal number: ");
            
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("your decimal number divided by 4 is: ");
            secondClass.Math1(y);


            Console.ReadLine();
            
        }
    }
}
