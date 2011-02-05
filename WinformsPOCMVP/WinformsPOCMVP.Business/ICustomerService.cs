using System;
using System.Collections.Generic;
using WinformsPOCMVP.Domain;

namespace WinformsPOCMVP.Business
{
    public interface ICustomerService
    {
        Customer GetCustomerById(Guid id);
        IList<Customer> GetAllCustomers();
        IList<CustomerListViewModel> GetCustomerList();
        bool Save(Customer customer);
    }
}
