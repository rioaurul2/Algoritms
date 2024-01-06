using System;
using System.Collections.Generic;

namespace Sirul_lui_fibonacii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var fibonaci = new List<long> {1,1};
            int fibonaciLenght = 20;
            for (int i = 1; i < fibonaciLenght-1; i++)
            {
                fibonaci.Add(fibonaci[i] + fibonaci[i - 1]);

            }
            foreach (int number in fibonaci)
            {
                Console.WriteLine(number);
            }
        }
    }
}
