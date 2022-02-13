using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3._1._2
{
    class Program
    {
        // dictionary! List, item. list: collection; list? text
        
        static void Main(string[] args)
        {
            Console.WriteLine("Your article:");

            string text = Console.ReadLine();

            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':'}, StringSplitOptions.RemoveEmptyEntries);

            string[] wordsToLower = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
                wordsToLower[i] = words[i].ToLower();

            var table = new Dictionary<string, int>();

            for (int i = 0; i < wordsToLower.Length; i++)
            {
                if (!table.ContainsKey(wordsToLower[i]))
                    table.Add(wordsToLower[i], 1);
                else
                    table[wordsToLower[i]]++;
            }

            var sortDict = table.Where(x => x.Value > 1);

            if (sortDict.Any())
            {
                Console.WriteLine("Most frequently used words:");
                foreach (var pair in sortDict)
                {
                    Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
                }
            }
            else
                Console.WriteLine("There are few repeated words in your text!");

        }
    }
}
