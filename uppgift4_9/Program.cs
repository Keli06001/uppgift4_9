using System;

namespace uppgift4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange triangelns sidolängd");
            int sido=int.Parse(Console.ReadLine());
            for (int i = 1; i <= sido; i++) 
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}