//Reverse4 
//Author : Nate Christensen
//Date : 10/17/2018
//Program.cs

using System;

namespace Reverse4
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 4,
                two = 3,
                three = 2,
                four = 1;
            Console.WriteLine("Original One   : " + one);
            Console.WriteLine("Original Two   : " + two);
            Console.WriteLine("Original Three : " + three);
            Console.WriteLine("Original Four  : " + four);
            Console.WriteLine("======================");
            Reverse(ref one, ref two, ref three, ref four);
            Console.WriteLine("New One   : " + one);
            Console.WriteLine("New Two   : " + two);
            Console.WriteLine("New Three : " + three);
            Console.WriteLine("New Four  : " + four);

            EndOfProgram();
        }

        static void Reverse(ref int a, ref int b, ref int c, ref int d)
        {
            int temp;
            //Swap values 'a' and 'd'
            temp = a;
            a = d;
            d = temp;
            //Swap values 'b' and 'c'
            temp = b;
            b = c;
            c = temp;
        }
        static void EndOfProgram()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Press Any Key To Exit.");
            Console.ReadKey();
        }
    }
}
