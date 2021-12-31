using System;

namespace Task_1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a");
            bool isSideA = int.TryParse(Console.ReadLine(), out int sideA);

            Console.WriteLine("Enter side b");
            bool isSideB = int.TryParse(Console.ReadLine(), out int sideB);


            if (isSideA && isSideB && (sideA <= 0 || sideB <= 0))
            {
                throw new Exception("Incorrect values");
            }

            int area = sideA * sideB;

            Console.WriteLine($"Area of rectangle = {area}");
        }
    }
}
