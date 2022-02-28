using System;

namespace Task_3._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria p = new Pizzeria();
            Order o = new Order(new Client("Vasya"), Pizza.Mixed);

            Order o2 = new Order(new Client("Petya"), Pizza.Sausage);

            p.Sub(o);
            p.Cooking();
            p.Unsub(o);

            p.Sub(o2);
            p.Cooking();
            p.Unsub(o2);
        }
    }
}
