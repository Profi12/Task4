using System;
using Task4_Library;

namespace Task4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write($"{ array[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            TaskHelper.ReverseSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
