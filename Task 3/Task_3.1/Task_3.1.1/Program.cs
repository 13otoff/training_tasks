using System;

namespace Task_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter what number of people will be crossed out");
            int number = int.Parse(Console.ReadLine());

            Person person = new Person(n, number);
            Console.WriteLine("Generated a circle of people. Start to delete every second person");
            person.Deletion();
        }
    }
}
