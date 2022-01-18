using System;

namespace Task_1._2._3
{
    
    // Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрл Звездные Войны

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();

            int countOfLowWords = 0;

            string[] words = str.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsLower(words[i][0]))
                    countOfLowWords++;
            }
            Console.WriteLine("Count of words writing with lowercase letter: {0}", countOfLowWords);
        }
    }
}
