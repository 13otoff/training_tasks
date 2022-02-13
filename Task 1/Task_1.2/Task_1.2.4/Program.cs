using System;

namespace Task_1._2._4
{
    class Program
    {

        // я плохо учил русский язык... забываю начинать предложения с заглавной?! хорошо, что можно написать программу.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            string newStr = "";

            char[] ch = str.ToCharArray();
            char[] separators = { '.', '!', '?'};
            for (int i = 0; i < ch.Length; i++)
            {
                if (i == 0)
                {
                    newStr += char.ToUpper(ch[0]);
                }
                else
                {
                    if (i == ch.Length - 1)
                    {
                        newStr += ch[ch.Length - 1];
                        break;
                    }
                    for (int j = 0; j < separators.Length; j++)
                    {

                        if (ch[i] == separators[j] && char.IsLetter(ch[i + 2]))
                        {
                            newStr += separators[j] + " ";
                            newStr += char.ToUpper(ch[i + 2]);
                            i += 3;
                        }
                        else if (ch[i] == separators[j] && !char.IsLetter(ch[i + 2]) && char.IsLetter(ch[i + 3]))
                        {
                            newStr += "?! ";
                            newStr += char.ToUpper(ch[i + 3]);
                            i += 4;
                        }
                        else if (ch[i] == separators[j] && !char.IsLetter(ch[i + 2]) && !char.IsLetter(ch[i + 3]) &&
                            char.IsLetter(ch[i + 4]))
                        {
                            newStr += "... ";
                            newStr += char.ToUpper(ch[i + 4]);
                            i += 5;
                        }

                    }
                    if (!char.IsUpper(ch[i]))
                        newStr += ch[i];
                }
            }
            Console.WriteLine("Result:");
            Console.WriteLine(newStr);
        }
    }
}
