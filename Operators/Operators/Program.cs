using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empOne = new Employee();
            empOne.FirstName = "Andy";
            empOne.LastName = "Panagos";
            empOne.ID = 11;

            Employee empTwo = new Employee();
            empTwo.FirstName = "Griffin";
            empTwo.LastName = "Ancevic";
            empTwo.ID = 13;

            Console.WriteLine("Is griffin's ID the same as Andy's");
            Console.WriteLine(empTwo.ID == empOne.ID);
            Console.ReadLine();

        }
    }
}
