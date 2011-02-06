using System;
using System.Linq;
using System.Collections.Generic;
using WinformsPOCMVP.Data;
using WinformsPOCMVP.Domain;

namespace WinformsPOCMVP.Business
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository Respository { get; set; }

        public CustomerService(ICustomerRepository repository)
        {
            Respository = repository;
        }

        public CustomerService()
            : this(new CustomerRepository())
        { }

        public Customer GetCustomerById(Guid id)
        {
            return Respository.FetchBy(id);
        }

        public IList<Customer> GetAllCustomers()
        {
            return Respository.FetchAll();
        }

        public IList<CustomerListViewModel> GetCustomerList()
        {
            return (from c in Respository.QueryAll().ToList()
                    select new CustomerListViewModel(c.Id, c.CompanyName)).ToList();
        }

        public bool Save(Customer customer)
        {
            return Respository.Update(customer);
        }
    }
}
