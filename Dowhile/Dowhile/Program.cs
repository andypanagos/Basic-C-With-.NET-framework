using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current temperature?");
            int temp = Convert.ToInt32(Console.ReadLine());
            bool isMatch = temp == 80;

            do
            {
                switch (temp)
                {

                    case 80:
                        Console.WriteLine("It's the perfect temperature!");
                        isMatch = true;
                        break;

                    case int n when n >= 81:
                        Console.WriteLine("It's too warm!");
                        isMatch = false;
                        break;

                    case int n when n <= 79:
                        Console.WriteLine("It's too cold!");
                        isMatch = false;
                        break;
                }
            }
            while (!isMatch && isMatch);
            Console.ReadLine();
        }
    }
}
