using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");


            Console.WriteLine("What is your package weight?");
            int packweight = Convert.ToInt32(Console.ReadLine());

            if (packweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("What is your package height?");
            int packheight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your package length?");
            int packlength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your package width?");
            int packwidth = Convert.ToInt32(Console.ReadLine());

            if (packlength + packheight + packwidth > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            decimal quote = Convert.ToDecimal((packheight * packlength * packwidth) / 100);
            Console.WriteLine("Your estimated total for shipping this package is:" + quote);

        }
    }
}
