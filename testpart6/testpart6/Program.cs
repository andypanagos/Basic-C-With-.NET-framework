using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testpart6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> iceCream = new List<string>() { "vanilla", "chocolate", "cookiedough", "coffee", "vanilla" };

            // Decalre a new list
            List<string> icecream2 = new List<string>();

            string message = " is the duplicate flavor ";

            foreach (string flavor in iceCream)
            {
                Console.WriteLine(flavor);

                if (icecream2.Contains(flavor))
                {
                    // Add a message to the flavor that's been displayed before
                    icecream2.Add(flavor + message);
                    Console.WriteLine(flavor + message);
                    Console.ReadLine();
                }
                else
                {
                    // Add flavor to list
                    icecream2.Add(flavor);
                    
                    
                }
               
            }
            
            

        }
    }
}
