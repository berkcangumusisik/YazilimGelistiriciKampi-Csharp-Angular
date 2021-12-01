using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
   public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if (customer.FirstName.Trim().Length > 0 &&
                customer.LastName.Trim().Length > 0 &&
                customer.NationalityId.Length == 11 &&
                customer.DateOfBirth.Year > 1900);
            {
                return true;
            }

        }
    }
}
