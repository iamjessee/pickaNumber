//pickanumber

using System;

class DivisibleNumbers
{   //calls upon both functions to display
    static void Main()
    {
        //Console.WriteLine("Welcome! Click up or Down arrow to continue.");

        // TwoNumberMultiple();
        ManyNmberMultiple();

    }

    static void TwoNumberMultiple()
    {   //allows user to type two numbers to fine if multuple
        Console.WriteLine("Type some numbers:");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        for (int i = 0; i <= 100; i++)
        {
            if (i % x == 0)
            {

                Console.Write(i + ",");
            }
            else if (i % y == 0)
            {
                Console.Write(i + ",");
            }
        }
        Console.WriteLine();
    }
    /*Create program that lets user define how many numebrs to find multiples of 
     said numbers 1 - 100*/

    static void ManyNmberMultiple()
    {

        Console.WriteLine("Type some more numbers:");
        int[] newArray = new int[10];
        for (int p = 0; p < newArray.Length; p++)
        {
            newArray[p] = Convert.ToInt32(Console.ReadLine());
            int s = newArray[p];

            for (int i = 1; i <= 100; i++)
            {
                if (i % s == 0)
                {

                    Console.Write(i + ",");
                }
            }
        }
    }
}


