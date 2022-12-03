using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part One
            //one dimensional array of strings
            //asks user to input text

            List<string> stringArray = new List<string>();
            stringArray.Add("coke");
            stringArray.Add("pepsi");
            stringArray.Add("fanta");
            stringArray.Add("sprite");
            stringArray.Add("ginger ale");

            //do
            //{
                Console.WriteLine("What is your name?: ");
                string name = Console.ReadLine();

                Console.WriteLine("Pick a number between 0-4");
                int number = Convert.ToInt32(Console.ReadLine());
                //loop that iterates through string array and checks if soda name given is in array
                //else, displays user name with favorite soda
                for (int i = 0; i < stringArray.Count; i++)
                {
                    stringArray[i] += " is your favorite soda, " + name;
                break;
                }
                for (int x = 0; x < stringArray.Count; x++)
                {
                    Console.WriteLine(stringArray[x]);
                }
            Console.ReadLine();

            //part 2: Infitinte loop and Fix

            //for (int loop= 0; loop++)
            //{
            //     Console.WriteLine(loop);
            //}

            //Fix
            for (int loop = 0; loop < stringArray.Count; loop++)
            {
                Console.WriteLine(loop);
                break;
            }

            //part 3: using <=
            int[] orderAmount = { 4, 9, 5, 8, 7, 12, 3, 11, 10 };

            for (int i = 0; i < orderAmount.Length; i++)
            {
                if (orderAmount[i] < 10)
                {
                    Console.WriteLine("Orders with less than 10 items: " + orderAmount[i]);
                }
                
            }
            Console.ReadLine();



            int[] arrayTwo = { 4, 6, 3, 77, 5 };

            for ( int y = 0; y <= 5; y++)
            {
                Console.WriteLine("using less than or equal to sign to determine whether to continure iterating loop");
                break;

            }

            //Part 4: A list of strings where each item in the list is unique.

            List<string> nbaPlayers = new List<string>
            {
                "lebron james",
                "stephen curry",
                "jayson tatum",
                "nikola jokic",
                "luka doncic"
            };

            //Ask the user to input text to search for in the list.

            bool playerSearch = false;

            int result = 0;
            //while loop running off of boolean variable
            //when correct player is guessed, the index will be written
            while (!playerSearch)
            {
                Console.WriteLine("Enter the name of your favorite NBA player");

                string playerAnswer = Console.ReadLine().ToLower();

                for (int i = 0; i < nbaPlayers.Count; i++)
                {
                    if (nbaPlayers[i] == playerAnswer)
                    {
                        result = i;
                        playerSearch = true;
                        break;
                    }
                }
                //Printing to the console the index of the player provided by the user
                //Else statement to display when a player not in list is chosen
                if (playerSearch)
                {
                    Console.WriteLine("The index of your player is " + result + " in the list.");

                }
                else
                {
                    Console.Write("Player is not in the list");
                }
                result = 0;
                Console.ReadLine();
            }
            //Part 5
            //Create list of friends names
            
            List<string> names = new List<string>
            {
                "griff",
                "andy",
                "jack",
                "alden",
                "ryan",
                "tucker",
                "griff"
            };



            for (int i = 0; i < names.Count; i++)
            {
                string name2 = names[i];
                Console.WriteLine(name2);
               
            }

            // Flag
            bool isFound = false;

            // While loop
            while (!isFound)
            {
                Console.WriteLine("\nPlease enter a word from the above list to determine the index from it.");
                string name1 = Console.ReadLine();

                for (int i = 0; i < names.Count; i++)
                {
                    // If word found, display the index/indices of entered word and set flag to true
                    if (names[i] == name1)
                    {
                        Console.WriteLine("Chosen name: " + i);
                        isFound = true;
                    }
                    // Display message if entered word is not in the list
                    else if (!names.Contains(name1))
                    {
                        Console.WriteLine("Try again.");
                        break;
                    }
                }
                Console.ReadLine();


                //Part 6

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
}
