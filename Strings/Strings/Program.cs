using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //List<string> intList = new List<string>();
        //intList.Add("hello");
        //intList.Add("andy");
        //intList.Remove("andy");

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //byte[] byteArray = new byte[5000]





        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2500 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        List<string> strList = new List<string>();
        strList.Add("Tatum");
        strList.Add("Brown");
        strList.Add("Smart");
        strList.Add("Horford");

        Console.WriteLine("Select celtics player 0, 1, 2, or 3");
        int playerindex = Convert.ToInt32(Console.ReadLine());
        string error = "Select correct option";
        if(playerindex >= 4 || playerindex < 0)
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
        if (strChoice > 4 || strChoice <0)
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

