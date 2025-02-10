//QUESTION Write a program to understand the use of  control. statement c#
using System;

class Program
{
    static void Main()
    {
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        Console.WriteLine("\nEnter a day number (1 to 7):");
        int day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }

        Console.WriteLine("\nFor Loop Example:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }

        Console.WriteLine("\nWhile Loop Example:");
        int count = 1;
        while (count <= 3)
        {
            Console.WriteLine("Count is: " + count);
            count++;
        }

        Console.WriteLine("\nDo-While Loop Example:");
        int num = 1;
        do
        {
            Console.WriteLine("Num is: " + num);
            num++;
        } while (num <= 2);
    }
}
