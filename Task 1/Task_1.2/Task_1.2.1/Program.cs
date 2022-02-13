using System;

namespace Task_1._2._1
{
    // Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();

            string[] words = str.Split(new char[]{' ', ',', '.', ':', ';', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            int countOfChars = 0;

            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsLetter(ch[i]))
                    countOfChars++;  
            }

            int meanValue = countOfChars / words.Length;
            Console.WriteLine("Mean value(int): {0}", meanValue);
        }
    }
}
