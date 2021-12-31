using System;

namespace Task_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N");

            bool isNumber = int.TryParse(Console.ReadLine(), out int number);

            if (isNumber)
            {
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
