using System;
using System.Collections.Generic;
using WinformsPOCMVP.Business;
using WinformsPOCMVP.Domain;

namespace WinformsPOCMVP.Presentation
{
    public class CustomerDetailPresenter
    {
        private ICustomerDetailView View { get; set; }
        private ICustomerService Service { get; set; }
        
        public CustomerDetailPresenter(ICustomerDetailView view)
        {
            View = view;
            Service = new CustomerService();
        }

        public void Initialize()
        {
            View.BeginViewUpdate();

            IList<CustomerListViewModel> customerList = Service.GetCustomerList();
            customerList.Insert(0, new CustomerListViewModel(new Guid(), "Choose a company..."));
            View.CustomersSelectList = customerList;

            View.EndViewUpdate();
        }

        private void RetrieveAndBindModel(Guid id)
        {
            Customer model = Service.GetCustomerById(id);

            View.BeginViewUpdate();

            View.FirstName = model.FirstName;
            View.LastName = model.LastName;
            View.IsIndividualCustomer = (model.CustomerAccountType == CustomerAccountType.Individual);
            View.AccountNumber = model.AccountNumber;
            View.MailingAddressOne = model.MailingAddressOne;
            View.MailingAddressTwo = model.MailingAddressTwo;
            View.City = model.City;
            View.State = model.State;
            View.ZipCode = model.ZipCode;
            View.Country = model.Country;
            View.CompanyName = model.CompanyName;
            View.EmailAddress = model.EmailAddress;

            View.EndViewUpdate();
        }

        public void ShowCustomerDetails()
        {
            RetrieveAndBindModel(View.SelectedCustomer);
        }

        public void UpdateCustomer()
        {
            var model = new Customer
                            {
                                Id = View.SelectedCustomer,
                                FirstName = View.FirstName,
                                LastName = View.LastName,
                                CustomerAccountType =
                                    (View.IsIndividualCustomer)
                                        ? CustomerAccountType.Individual
                                        : CustomerAccountType.Company,
                                AccountNumber = View.AccountNumber,
                                MailingAddressOne = View.MailingAddressOne,
                                MailingAddressTwo = View.MailingAddressTwo,
                                City = View.City,
                                State = View.State,
                                ZipCode = View.ZipCode,
                                Country = View.Country,
                                CompanyName = View.CompanyName,
                                EmailAddress = View.EmailAddress
                            };

            Service.Save(model);
        }
    }
}
