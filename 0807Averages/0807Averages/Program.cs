//Averages
//Author : Nate Christensen
//Date : 10/18/2018
//Program.cs

using System;

namespace _0807Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 21, 74, 66, 43, 68, 51, 79, 80 };
            Console.WriteLine("Average of 19: " + Average(19));
            Console.WriteLine("Average of 72, 66: " + Average(72, 66));
            Console.WriteLine("Average of 68, 78, 16: " + Average(68, 78, 16));
            Console.WriteLine("Average of 21, 74, 66, 43, 68, 51, 79, 80: " + Average(numbers));
            EndOfProgram();
        }


        static double Average(params int[] input)
        {
            double sum = 0;
            double average = 0;
            foreach (double value in input)
            {
                sum += value;
            }
            average = sum / input.Length;
            return average;
        }
        static double Average(params double[] input)
        {
            double sum = 0;
            double average = 0;
            foreach (double value in input)
            {
                sum += value;
            }
            average = sum / input.Length;
            return average;
        }
        static double Average(params decimal[] input)
        {
            double sum = 0;
            double average = 0;
            foreach (double value in input)
            {
                sum += value;
            }
            average = sum / input.Length;
            return average;
        }


        static void EndOfProgram()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Press Any Key To Exit.");
            Console.ReadKey();
        }
    }
}
