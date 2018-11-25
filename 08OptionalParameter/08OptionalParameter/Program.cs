//Optional Parameter
//Author : Nate Christensen
//Date : 10/17/2018
//Program.cs

using System;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] colors = { "black", "brown", "red", "violet",
                "green", "orange", "yellow", "blue", "gray", "white" };
            string[] alsoColors = { "black", "brown", "red", "violet",
                "green", "orange", "yellow", "blue", "gray", "white" };
            SortWords(colors);
            SortWords(alsoColors, true);

            EndOfProgram();
        }
        
        static void SortWords(string[] input, bool direction = false)
        {
            Array.Sort(input);
            if (direction)Array.Reverse(input);
            foreach (string word in input)
            {
                Console.Write(word + "   ");
            }
            Console.WriteLine();
        }
        static void EndOfProgram()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Press Any Key To Exit.");
            Console.ReadKey();
        }
    }
}
