using System;
using System.Linq;
using System.Collections.Generic;
using WinformsPOCMVP.Data;
using WinformsPOCMVP.Domain;

namespace WinformsPOCMVP.Business
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public CustomerService()
            : this(new CustomerRepository())
        { }

        public Customer GetCustomerById(Guid id)
        {
            return _repository.FetchBy(id);
        }

        public IList<Customer> GetAllCustomers()
        {
            return _repository.FetchAll();
        }

        public IList<CustomerListViewModel> GetCustomerList()
        {
            return (from c in _repository.QueryAll().ToList()
                    select new CustomerListViewModel(c.Id.ToString(), c.CompanyName)).ToList();
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
