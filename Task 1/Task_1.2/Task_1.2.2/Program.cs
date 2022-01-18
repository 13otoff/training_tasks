using System;

namespace Task_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string first = Console.ReadLine();

            Console.WriteLine("Enter second string:");
            string second = Console.ReadLine();

            char[] charsOfFirst = first.ToCharArray();
            char[] charsOfSecond = second.ToCharArray();
            string result = "";


            for (int i = 0; i < charsOfFirst.Length; i++)
            {
                result += charsOfFirst[i];
                for (int j = 0; j < charsOfSecond.Length; j++)
                {
                    if (charsOfSecond[j] == charsOfFirst[i])
                    {
                        result += charsOfFirst[i];
                        break;
                    }
                }
            }
            Console.WriteLine("Result:");
            Console.WriteLine(result);
        }
    }
}
