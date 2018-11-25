using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Test1
{
    class Program
    {
        static int total;
        static void Main(string[] args)
        {
            int tax = 99;
            Console.WriteLine("Enter total sale amount.");
            total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"tax is {tax}");
            Console.WriteLine($"Total is {total}");
            //DoSomething(total);
            //DoSomething(Math.PI);
            //DoSomething(Console.ReadLine());
            //Console.WriteLine(DoTotal(total));
            if (!DoTotal(total)) Console.WriteLine($"ERROR with {total} in DoTotal()");
            //Console.WriteLine($"Total in Main() is {total}");
            // Console.WriteLine($"tax in Main() is {tax}");
            EndOfProgram();
        }
        private static void DoSomething(int saleAmount)
        {
            double tax =1.07;
            int x = 50;
            double total = saleAmount*tax;
            Console.WriteLine($"saleAmount in DoSoemthing() is {saleAmount}");
            Console.WriteLine($"Tax in DoSoemthing() is {tax}");
            Console.WriteLine($"Total in DoSoemthing() is {total}");
        }
        private static void DoSomething(double preciseTotal)
        {
            Console.WriteLine($"preciseTotal in DoSoemthing2() is {preciseTotal}");

        }
        private static void DoSomething(string preciseTotal)
        {
            Console.WriteLine($"preciseTotal in DoSoemthing3() is {preciseTotal}");

        }
        private static bool DoTotal(double total)
        {
            if (total >= 0 && total <= 100)
            {
                Console.WriteLine($"Total = {total}");
                return true;
            }
            else return false;
        }
        private static void EndOfProgram()
        {
            Console.WriteLine("Press any Key to exit.");
            Console.ReadKey();
        }
    }
}
