using System;
using System.Linq;
using System.Collections.Generic;
using WinformsPOCMVP.Domain;

namespace WinformsPOCMVP.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private IList<Customer> _customers;

        public CustomerRepository()
        {
            _customers = PopulateCustomerList();
        }

        public Customer FetchBy(Guid id)
        {
            return _customers.Where(x => x.Id == id).FirstOrDefault();
        }

        public IList<Customer> FetchAll()
        {
            return _customers;
        }

        public IQueryable<Customer> QueryAll()
        {
            return _customers.AsQueryable();
        }

        private IList<Customer> PopulateCustomerList()
        {
            var customerList = new List<Customer>();

            customerList.Add(new Customer
                    {
                        Id = new Guid("6F2BF47B-1A4F-4D7D-AE21-DB14ECF40444"),
                        CustomerAccountType = CustomerAccountType.Individual,
                        FirstName = "Jacob",
                        LastName = "Henderson",
                        CompanyName = "Acme",
                        EmailAddress = "JHenderson@Acme.com",
                        PhoneOne = "234-987-2837",
                        PhoneTwo = "657-948-3092",
                        AccountNumber = "948rudfj8u98",
                        MailingAddressOne = "28IF Penny Lane",
                        MailingAddressTwo = "Box 548",
                        City = "Westingham",
                        State = "MN",
                        ZipCode = "94837",
                        Country = "USA"
                    });

            customerList.Add(new Customer
                    {
                        Id = new Guid("0D89B22B-97D4-4D1D-901D-A42198AF8FEC"),
                        CustomerAccountType = CustomerAccountType.Individual,
                        FirstName = "Ralph",
                        LastName = "Peterson",
                        CompanyName = "MGT Global",
                        EmailAddress = "rpeterson@mgtg.com",
                        PhoneOne = "584-845-1548",
                        PhoneTwo = "584-845-3659",
                        AccountNumber = "viv8e804489jr0o",
                        MailingAddressOne = "9087 West Ally",
                        MailingAddressTwo = string.Empty,
                        City = "Northham",
                        State = "MN",
                        ZipCode = "94848",
                        Country = "USA"
                    });
            
            customerList.Add(new Customer
                    {
                        Id = new Guid("436B3B33-BA39-4315-BE82-20D24347AB9A"),
                        CustomerAccountType = CustomerAccountType.Individual,
                        FirstName = "Billy",
                        LastName = "Johnson",
                        CompanyName = "Ajax",
                        EmailAddress = "bill_johnson@Ajax.net",
                        PhoneOne = "564-3425-7867",
                        PhoneTwo = "456-689-4563",
                        AccountNumber = "g9r8efo4j84009",
                        MailingAddressOne = "W. 7876",
                        MailingAddressTwo = "2nd Floor",
                        City = "Eastgate",
                        State = "MN",
                        ZipCode = "94455",
                        Country = "USA"
                    });

            return customerList;
        }

        public bool Update(Customer customer)
        {
            return true;
        }
    }
}
