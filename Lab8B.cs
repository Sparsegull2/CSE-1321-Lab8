/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab8B
*/

using System;

class Lab8B
{

    public static void Main(string[] args)
    {
        int rows, cols,count=0;
        Console.Write("Please enter the number of rows: ");
        rows= int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of columns: ");
        cols= int.Parse(Console.ReadLine());
        Console.WriteLine("\nI have "+rows+" rows and "+cols+" columns. I need to fill-up "+(rows*cols)+" spaces.");
        Console.WriteLine("\nThe "+rows+"x"+cols+" array:");
        int[,] grid=new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                count++;
                grid[i, j] = count;
                Console.Write(grid[i, j] + "|");
            }
            Console.WriteLine();
        }
        
    }
}
