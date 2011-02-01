using System;
using System.Collections.Generic;
using WinformsPOCMVP.Domain;

namespace WinformsPOCMVP.Business
{
    public interface ICustomerService
    {
        Customer GetCustomerById(Guid id);
        IList<Customer> GetAllCustomers();
        bool Save(Customer customer);
    }
}
