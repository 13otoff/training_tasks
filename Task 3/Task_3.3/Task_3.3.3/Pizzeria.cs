using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3._3._3
{
     class Pizzeria
    {
        public event Action OnOrder = delegate { };

        public void Sub(Order order) => OnOrder += order.OrderIsReady;

        public void Unsub(Order order) => OnOrder -= order.OrderIsReady;
        public void Cooking()
        {
            Console.WriteLine("Order is accepted");

            Thread.Sleep(3000);
            OnOrder.Invoke();
        }
    }
}
