using System;
using System.Collections.Generic;

namespace Task_3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 1, 2, 3, 4, 5, 6};

            DynamicArray<int> a = new DynamicArray<int>(arr);

            Console.WriteLine(a.Length);
            Console.WriteLine(a.Capacity);

            Print(a);

            a.Add(9);

            Print(a);

            int[] arr2 = { 11, 12, 13 };
            a.AddRange(arr2);

            Print(a);

            a.Remove(11);
            Print(a);

            a.Insert(3, 777);
            Print(a);

            a[5] = 666;
            Print(a);
        }

        private static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
