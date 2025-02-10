//QUESTION 6 Write a program to store 10 elements in an array and display the array elements in increasing order.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(numbers);
        Console.WriteLine("\nArray elements in increasing order:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
