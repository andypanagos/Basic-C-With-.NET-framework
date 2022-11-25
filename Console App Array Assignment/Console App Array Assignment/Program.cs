using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>();
            strList.Add("Tatum");
            strList.Add("Brown");
            strList.Add("Smart");
            strList.Add("Horford");

            Console.WriteLine("Select celtics player 0, 1, 2, or 3");
            int playerindex = Convert.ToInt32(Console.ReadLine());
            string error = "Select correct option";
            if (playerindex >= 4 || playerindex < 0)
            {
                Console.WriteLine(error);
            }
            else
            {
                Console.WriteLine("You chose " + strList[playerindex]);
            }
            Console.ReadLine();

            int[] numArray = { 0, 1, 2, 3 };
            Console.WriteLine("Select index of 0, 1, 2, or 3");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 4 || choice < 0)
            {
                Console.WriteLine(error);
            }
            else
            {
                Console.WriteLine("You chose " + numArray[choice]);
            }

            string[] List = { "red", "yellow", "blue", "green" };
            Console.WriteLine("Please select index of 0, 1, 2, 3");
            int strChoice = Convert.ToInt32(Console.ReadLine());
            if (strChoice > 4 || strChoice < 0)
            {
                Console.WriteLine(error);
            }
            else
            {
                Console.WriteLine("you chose the color: " + List[strChoice]);
            }
            Console.ReadLine();
        }
    }
}
