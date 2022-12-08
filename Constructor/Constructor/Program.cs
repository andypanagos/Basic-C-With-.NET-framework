using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //const variable
            const string conString = "Hello";
            Console.WriteLine(conString);
            //variable keyword
            var mySelf = "Andy";


            user sayUser = new user();
            sayUser.SayName();
            Console.ReadLine();
            
        }
    }
}
