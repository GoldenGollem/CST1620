using System;

namespace _0808SortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words =
                {"peach", "apple", "mango", "pineapple", "dragon fruit","plum","oragne"};
             
            SortWords("peach", "apple", "mango", "pineapple", "dragon fruit");
            Console.WriteLine();
            SortWords("plum", "oragne", "apple");
            Console.WriteLine();
            SortWords(words);
            Console.WriteLine();

            int myNum=
            Convert.ToInt32("FE", 16);
            string hexNum = Convert.ToString(myNum, 16);

            Console.WriteLine("myNumber = "+myNum);
            Console.WriteLine(hexNum);

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit.");
            Console.ReadKey();
        }
        static void SortWords(params string[] input)
        {
            Array.Sort(input);
            foreach(string word in input)
            {
                Console.Write(word + "   ");
            }
        }
    }
}
