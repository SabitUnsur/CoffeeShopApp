using CoffeeShopApp.Abstract;
using CoffeeShopApp.Concrete;
using CoffeeShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopApp.Adapters;

namespace CoffeeShopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarBucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth=2002,FirstName="Sabit",
                LastName="Ünsür",NationalityId=134324234});

            Console.ReadLine();

        }
    }

}
