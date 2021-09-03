﻿using System;
using Task4_Library;

namespace Task4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write($"{ array[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine(TaskHelper.SumByOddIndexes(array));
        }
    }
}
