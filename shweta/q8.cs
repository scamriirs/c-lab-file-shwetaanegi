//write a program for one dimensional and 2 dimensional array 

using System;

class Program
{
    static void OneDimensionalArray()
    {
        int[] oneDArray = new int[] { 10, 20, 30, 40, 50 };

        Console.WriteLine("One-dimensional array:");
        for (int i = 0; i < oneDArray.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + oneDArray[i]);
        }
    }

    static void TwoDimensionalArray()
    {
        int[,] twoDArray = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        Console.WriteLine("\nTwo-dimensional array:");
        for (int i = 0; i < twoDArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDArray.GetLength(1); j++)  
            {
                Console.Write(twoDArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        OneDimensionalArray();
        TwoDimensionalArray();
    }
}
output
One-dimensional array:
Element at index 0: 10
Element at index 1: 20
Element at index 2: 30
Element at index 3: 40
Element at index 4: 50

Two-dimensional array:
1	2	3	
4	5	6	
