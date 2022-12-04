using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day is it today?");
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine(), true);
                Console.WriteLine("Happy, " + day);

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter actual day of the week");
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
