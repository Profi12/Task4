using System;
using Task4_Library;

namespace Task4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 20;
            int[] arr = new int[count];
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = random.Next(0, 101);
                Console.Write($"{ arr[i]} ");
            }

            Console.WriteLine();

             TaskHelper.Sort(arr);

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
