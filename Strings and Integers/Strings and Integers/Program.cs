using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list

            List<int> intList = new List<int>() { 124, 98, 66, 78, 54, 24 };
            
            //ask for number to divide list numbers by

            

            //try catch: divides each number in the list by the user input number
            
            try
            {
                Console.WriteLine("Please enter an even number less than 10.");
                int evenNum = Convert.ToInt32(Console.ReadLine());

                foreach (int num in intList)
                {
                    Console.WriteLine(num + " divided by " + evenNum + " equals: " + num / evenNum);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("0 cannot be divided.");
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("The program has emerged from the try/catch block... continuing on with program execution.");
            Console.ReadLine();
            //catch statements
        }
    }
}
