using System;

namespace Task_1._1._3
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
                    for (int k = number; k > i; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1 + 2 * i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
