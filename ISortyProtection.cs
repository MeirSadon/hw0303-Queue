using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw030319
{
    class ISortByProtection : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {

            return x.Protection - y.Protection;
        }
    }
    class ISortByTotalPurchases : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.TotalPurchases - y.TotalPurchases;
        }
    }
    class ISortByBirthYear : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.BirthYear - y.BirthYear;
        }
    }
}
