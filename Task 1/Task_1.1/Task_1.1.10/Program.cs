using System;

namespace Task_1._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5,5];

            RandomArr(arr);
            ShowArr(arr);
            Console.WriteLine();
            SumElems(arr);
        }

        public static void SumElems(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }                  
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }

        public static void ShowArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,5}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void RandomArr(int[,] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(-10,10);
                }
            }
        }
    }
}
