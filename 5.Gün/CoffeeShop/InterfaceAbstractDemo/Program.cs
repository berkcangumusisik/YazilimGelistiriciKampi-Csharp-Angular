using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            { 
                DateOfBirth = new DateTime(1999,4,12), 
                FirstName="BERKCAN", 
                LastName="GÜMÜŞIŞIK", 
                NationalityId="1234567890"  
            });

            Console.ReadLine();
        }

       

    }
}
