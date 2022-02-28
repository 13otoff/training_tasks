using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    class Order
    {
        public Client Client { get; set; }
        public Pizza Pizza { get; set; }

        public Order(Client client, Pizza pizza)
        {
            Client = client;
            Pizza = pizza;
        }

        public void OrderIsReady()
        {
            Console.WriteLine($"{Client.Name}, u {Pizza} pizza is ready!");
        }
    }
}
