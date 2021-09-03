namespace Task4_Library
{
    public class TaskHelper
    {
        public static int Min(int[] array) 
        {
            return array[MinIndex(array)];
        }

        public static int Max(int[] array)
        {
            return array[MaxIndex(array)];
        }

        public static int MinIndex(int[] array)
        {
            int minIndex = 0;

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
    }
}
