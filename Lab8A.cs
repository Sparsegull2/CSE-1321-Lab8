/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab8A
*/

using System;

class Lab8A
{

    public static void Main(string[] args)
    {
        int[] array1 = new int[5];
        int[] array2 = new int[5];
        Console.WriteLine("Please enter 5 integers for the first array: ");
        for (int i = 0; i< array1.Length;i++ )
        {
            Console.Write("Integer "+(i+1)+": ");
            array1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nPlease enter 5 integers for the second array: ");
        for (int j = 0; j< array2.Length;j++ )
        {
            Console.Write("Integer " + (j + 1) + ": ");
            array2[j] = int.Parse(Console.ReadLine());
        }
        int[] array_sum = { array1[0] + array2[0], array1[1] + array2[1], array1[2] + array2[2], array1[3] + array2[3], array1[4] + array2[4], };
        Console.Write("\nThe resulting sums are ");
        foreach (int term in array_sum ) 
        {
            Console.Write(term+"|");
        }
    }
}
