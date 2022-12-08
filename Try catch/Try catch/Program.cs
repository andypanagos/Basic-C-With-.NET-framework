using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {

            

            try
            {
                //Ask for age, create age int
                Console.WriteLine("What is your age? ");
                int age = Convert.ToInt32(Console.ReadLine());

                //if the age entered is less than one, we throw an exception
                if (age < 1)
                {
                    throw new InvalidOperationException();
                }
                Console.WriteLine("you were born in " + DateTime.Now.AddYears(-age).Year);
                Console.ReadLine();
            }
            catch (InvalidOperationException) //exception for input that is less than one
            {
                Console.Write("Please enter a value greater than one.");
                Console.ReadLine();
                return;
            }
            catch (Exception)  //exception for anything thats not an integer.
            {
                Console.Write("Please only enter numbers.");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
