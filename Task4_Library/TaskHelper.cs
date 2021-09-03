namespace Task4_Library
{
    public class TaskHelper
    {
        public static int Task4_1(int[] array) 
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }
    }
}
