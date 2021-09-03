using System;
using Task4_Library;

namespace Task4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
                Console.Write($"{ array[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine(TaskHelper.MinIndex(array));
        }
    }
}