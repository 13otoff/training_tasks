using System;

namespace Task_3._3._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string:");

            string s = Console.ReadLine();

            Console.WriteLine(s.GetLanguage());
        }
    }
}
