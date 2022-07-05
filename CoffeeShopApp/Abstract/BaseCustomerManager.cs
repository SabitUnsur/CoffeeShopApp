using CoffeeShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer) //Virtual ile bunu ezebiliriz.
        {
            Console.WriteLine("Saved to db : " +customer.FirstName);    
        }
    }
}
