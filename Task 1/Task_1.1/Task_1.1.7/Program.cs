using System;

namespace Task_1._1._7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];

            RandomArr(array);
            ShowArr(array);
            FindMinMaxValues(array);
            SortArr(array);
            ShowArr(array);
            
        }

        public static void ShowArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
        }

        public static void RandomArr(int [] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10, 10);
            }
        }

        public static void SortArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void FindMinMaxValues(int[] arr)
        {
            int maxValue = arr[0];
            int minValue = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (minValue > arr[i + 1])
                    minValue = arr[i + 1];
                if (maxValue < arr[i + 1])
                    maxValue = arr[i + 1];
            }
            Console.WriteLine($"minValue = {minValue}, maxValue = {maxValue}");
            Console.WriteLine();
        }
    }
}
