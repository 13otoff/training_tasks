using System;

namespace Task_1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[3,4,5];

            RandomArr(array);
            ShowArr(array);

            Console.WriteLine("Changed array");
            Console.WriteLine();

            ChangeElems(array);
            ShowArr(array);
        }

        public static void ShowArr(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write("{0,5}", arr[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public static void ChangeElems(int [,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        } 
                    }
                }
            }
        }

        public static void RandomArr(int[,,] arr)
        {
            Random r = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = r.Next(-10, 10);
                    }
                }
            }
        }
    }
}
