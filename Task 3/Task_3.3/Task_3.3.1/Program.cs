using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 3, 5, 7, 9, 3, 5, 5 };

            PrintArr(arr);

            Function(arr, 3, x => x * x);
            Console.WriteLine();
            PrintArr(arr);

            Console.WriteLine();
            Console.WriteLine($"Sum - {arr.Sum()}");

            Console.WriteLine();
            Console.WriteLine($"Average - {arr.Average()}");

            Console.WriteLine();
            Console.WriteLine($"Most frequent - {arr.MostFrequent()}");
        }

        public static T[] Function<T>(T[] array, int index, Func<T, T> func)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    array[i] = func.Invoke(array[i]);
                }
            }
            return array;
        }

        public static void PrintArr<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
       
    }
}
