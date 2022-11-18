using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            string name, course, tf, positive, feedback;
            int page, hours;
            
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your Name?");
            name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            course = Console.ReadLine();

            Console.WriteLine("What page number?");
            page = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            tf = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            positive = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank You for your answers. An instructor will respond to this shortly, Have a nice day!");
            Console.Read();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
