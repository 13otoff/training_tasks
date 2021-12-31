using System;

namespace Task_1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            RandomArr(arr);
            ShowArr(arr);
            Console.WriteLine();
            SumElems(arr);
        }

        public static void SumElems(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
        }

        public static void ShowArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0}\t", item);
            }
        }

        public static void RandomArr(int[] arr)
        {
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10, 10);
            }
        }
    }
}
