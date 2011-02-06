using System;
using System.Collections.Generic;
using System.Linq;
using WinformsPOCMVP.Domain;

namespace WinformsPOCMVP.Data
{
    public interface ICustomerRepository
    {
        Customer FetchBy(Guid id);
        IList<Customer> FetchAll();
        IQueryable<Customer> QueryAll();
        bool Update(Customer customer);
    }
}
