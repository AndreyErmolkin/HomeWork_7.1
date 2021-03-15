using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 4, 5, 1, 3, 5, 7, 8, 3, 9, 2, 4, 1, 3, 6, 9, 5, 6, 6, 1, 2 };
            List<int> results = new List<int>();
            int count = numbers.Count;

            numbers.Sort();
            foreach (var num in numbers)
            {
                Console.Write(" {0}", num);
            }
            Console.WriteLine();
            foreach (int num2 in numbers.Distinct())
            {
                Console.WriteLine(num2 + " - " + numbers.Where(x => x == num2).Count() + " times");
                
            }
            Console.WriteLine();

        }
    }
}