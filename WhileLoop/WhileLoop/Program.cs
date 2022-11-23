using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the current temperature?");
            int temp = Convert.ToInt32(Console.ReadLine());
            bool isMatch = temp == 80;

            while (isMatch = true ^ false)
            {
                switch (temp)
                {

                    case 80:
                        Console.WriteLine("It's the perfect temperature");
                        isMatch = true;
                        break;

                    case int n when n >= 81:
                        Console.WriteLine("its hot");
                        isMatch = false;
                        break;

                    case int n when n <= 79:
                        Console.WriteLine("its cold");
                        isMatch = false;
                        break;
                }
                break;
            }


            Console.ReadLine();
        }
    }
}
