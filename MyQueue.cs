using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw030319
{
    class MyQueue
    {
        private List<Customer> customers = new List<Customer>();

        public void Enqueue(Customer newCustomer)
        {

            customers.Add(newCustomer);
        }
        public Customer Dequeue()
        {
            Customer result = customers[0];
            customers.RemoveAt(0);
            return result;
        }
        public void Init(List<Customer> newList)
        {
            customers = newList;
        }
        public void Clear()
        {
            customers.Clear();
        }
        public Customer WholsNext()
        {
            return customers[0];
        }
        public int Count { get; }

        public void SortByProtection()
        {
            customers.Sort(new ISortByProtection());
        }
        public void SortByTotalPurchases()
        {
            customers.Sort(new ISortByTotalPurchases());

        }
        public void SortByBirthYear()
        {
            customers.Sort(new ISortByBirthYear());

        }
        public List<Customer> DequeueCustomers(int x)
        {            
            for (int i = 0; i < x; i++)
            {
                customers.RemoveAt(0);
            }
            customers.ForEach(c => Console.WriteLine(c));
            return customers;
        }
        public void AniRakSheela(Customer c)
        {
            Customer Shoel = c;
            customers.Remove(c);
            customers.Insert(0, Shoel);
            customers.ForEach(d => Console.WriteLine(d));

        }
        public Customer DequeueProtectzia()
        {
            {
                int MaxPro = 0;
                foreach(Customer customer in customers)
                {
                    if (customer.Protection > MaxPro)
                        MaxPro = customer.Protection;
                }
                Console.WriteLine(MaxPro);
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].Protection == MaxPro)
                    {
                    Console.WriteLine(customers[i]);
                    return customers[i];
                    }
                }
                return customers[0];
            }
        }
    }
}
