using System;

namespace Task_2._1._1
{
    class Program
    {

        static void Main(string[] args)
        {
            
            MyString str = new MyString("hellos");

            MyString str2 = new MyString("hello");


            MyString result = str + str2;
            Console.WriteLine((string)result);

            Console.WriteLine(result[2]);

            Console.WriteLine(result.FindSymbol('e'));

            bool succes = str == str2;
            Console.WriteLine(succes);
        }
    }
}
