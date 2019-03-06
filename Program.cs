using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw030319
{
    class Program
    {
        static void Main(string[] args)
        {            
            MyQueue mq = new MyQueue();
            Customer shiran = new Customer(1, "Shiran", 1994, "david niv 10", 24);
            Customer meir = new Customer(2, "Meir", 1995, "Amioz 2", 23);
            Customer osher = new Customer(3, "Osher", 2020, "Neria 28", 22);
            Customer tohar = new Customer(4, "Tohar", 2022, "ashkelon", 21);
            mq.Enqueue(shiran);
            mq.Enqueue(meir);
            mq.Enqueue(osher);
            mq.Enqueue(tohar);

            //mq.DequeueCustomers(2);
            mq.DequeueProtectzia();
        }
    }
}
