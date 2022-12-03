using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Sub_Assignment
{
    class Class1
    {
        //void method that divides by 2
        public void Math1(int num = 0)
        {
            int num1 = (num / 2);
            Console.WriteLine(num1);
        }
        
        

        //method with output parameters
        public void Math2(out int numOut)
        {
            numOut = 50;
        }

        //Overload double method
        public void Math1(double num)
        {
            double numdub = (num / 4);
            Console.WriteLine(numdub);
        }
    }
}
