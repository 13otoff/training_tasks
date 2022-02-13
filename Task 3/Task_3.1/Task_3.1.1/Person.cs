using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._1
{
    public class Person
    {
        private int i;
        private int countOfPeople;
        private int number;

        public int Number
        {
            get { return number; }
            private set 
            {
                if (value > 1 && value <= countOfPeople)
                    number = value;
                else
                    throw new ArgumentException("Number must be less than count of people");
            }
        }


        public int CountOfPeople
        {
            get { return countOfPeople; }
            private set 
            {
                if (value > 1 && value >= number)
                    countOfPeople = value;
                else
                    throw new ArgumentException("Circle of people must consist of more than 1 person");
            }
        }

        public Person(int countOfPeople, int number, int i = 1)
        {
            CountOfPeople = countOfPeople;
            Number = number;
            this.i = i;
        }

        public override string ToString()
        {
            string result = $"Round {i}. Deleted person. People left: {CountOfPeople - 1}";

            if (Number < CountOfPeople)
                return result;
            else
                return result + $"{Environment.NewLine}Game over. Cannot be cross out person";
        }



        public void Deletion()
        {
            Console.WriteLine(ToString());
            if (Number < CountOfPeople)
            {
                i++;
                CountOfPeople--;
                Deletion();
            }
            return;
        }
    }
}
