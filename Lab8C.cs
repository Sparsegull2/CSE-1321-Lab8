/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab8C
*/

using System;

class Lab8C{

    public static void Main(string[] args)
    {
        int rows, cols, count = 0;
        Console.Write("Please enter the number of rows: ");
        rows = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of columns: ");
        cols = int.Parse(Console.ReadLine());
        Console.WriteLine("\nI have " + rows + " rows and " + cols + " columns. I need to fill-up " + (rows * cols) + " spaces.");
        Console.WriteLine("\nThe " + rows + "x" + cols + " array:");
        int[,] grid = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                count++;
                grid[i, j] = count;
                Console.Write(grid[i, j] + "|");
            }
            Console.WriteLine();
        }
       
        Console.WriteLine("\nThe "+rows+"x"+cols+" 2-D array flattened into a " + (rows * cols) + " cell 1-D array:");
        int[] flat = new int[(rows * cols)];
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                flat[index] = grid[i,j];
                index++;
            }
        }
        foreach(int term in flat)
        {
            Console.Write(term+"|");
        }
    }
}
