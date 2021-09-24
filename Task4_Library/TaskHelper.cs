using System;

namespace Task4_Library
{
    public class TaskHelper
    {
        public static int Min(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException();
            }

            return array[MinIndex(array)];
        }

        public static int Max(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException();
            }
            return array[MaxIndex(array)];
        }

        public static int MinIndex(int[] array)
        {
            int minIndex = 0;

            if (array == null || array.Length == 0)
            {
                throw new ArgumentException();
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[minIndex] > array[i])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int MaxIndex(int[] array)
        {
            int maxIndex = 0;

            if (array == null || array.Length == 0)
            {
                throw new ArgumentException();
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[maxIndex] < array[i])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int SumByOddIndexes(int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int[] Reverse(int[] array)
        {
            int[] reverseArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[i] = array[array.Length - 1 - i];
            }

            return reverseArray;
        }

        public static int OddCount(int[] array)
        {
            int n = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    ++n;
                }
            }

            return n;
        }

        public static void HalfReverse(int[] array)
        {
            int halfSize = array.Length / 2;
            int oddPart = array.Length % 2;

            for (int i = 0; i < halfSize; i++)
            {
                int temp = array[i];
                array[i] = array[halfSize + oddPart + i];
                array[halfSize + oddPart + i] = temp;
            }
        }

        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        public static void ReverseSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j] > array[j - 1])
                {
                    Swap(ref array[j], ref array[j - 1]);

                    j--;
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
