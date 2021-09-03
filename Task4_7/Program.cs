using System;
using Task4_Library;

namespace Task4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{ array[i]} ");
            }

            Console.WriteLine();
            
            Console.WriteLine(TaskHelper.OddCount(array));
        }
    }
}
