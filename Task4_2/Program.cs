using System;
using Task4_Library;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 101);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine(TaskHelper.Max(array));
        }
    }
}
