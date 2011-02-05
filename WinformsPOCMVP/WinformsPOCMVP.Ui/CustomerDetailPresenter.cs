using System;
using System.Collections.Generic;
using WinformsPOCMVP.Business;
using WinformsPOCMVP.Domain;

namespace WinformsPOCMVP.Ui
{
    public class CustomerDetailPresenter
    {
        private ICustomerDetailView _view;
        private ICustomerService _service;
        
        public CustomerDetailPresenter(ICustomerDetailView view)
        {
            _view = view;
            _service = new CustomerService();
        }

        public void Initialize()
        {
            _view.BeginViewUpdate();

            IList<CustomerListViewModel> customerList = _service.GetCustomerList();
            customerList.Insert(0, new CustomerListViewModel(new Guid(), "Choose a company..."));
            _view.CustomersSelectList = customerList;

            _view.EndViewUpdate();
        }

        private void RetrieveAndBindModel(Guid id)
        {
            Customer model = _service.GetCustomerById(id);

            _view.BeginViewUpdate();

            _view.FirstName = model.FirstName;
            _view.LastName = model.LastName;
            _view.IsIndividualCustomer = (model.CustomerAccountType == CustomerAccountType.Individual);
            _view.AccountNumber = model.AccountNumber;
            _view.MailingAddressOne = model.MailingAddressOne;
            _view.MailingAddressTwo = model.MailingAddressTwo;
            _view.City = model.City;
            _view.State = model.State;
            _view.ZipCode = model.ZipCode;
            _view.Country = model.Country;
            _view.CompanyName = model.CompanyName;
            _view.EmailAddress = model.EmailAddress;

            _view.EndViewUpdate();
        }

        internal void ShowCustomerDetails()
        {
            RetrieveAndBindModel(_view.SelectedCustomer);
        }

        internal void UpdateCustomer()
        {
            Customer model = new Customer();
            model.Id = _view.SelectedCustomer;
            model.FirstName = _view.FirstName;
            model.LastName = _view.LastName;
            model.CustomerAccountType = 
                (_view.IsIndividualCustomer)?CustomerAccountType.Individual:CustomerAccountType.Company;
            model.AccountNumber = _view.AccountNumber;
            model.MailingAddressOne = _view.MailingAddressOne;
            model.MailingAddressTwo = _view.MailingAddressTwo;
            model.City = _view.City;
            model.State = _view.State;
            model.ZipCode = _view.ZipCode;
            model.Country = _view.Country;
            model.CompanyName = _view.CompanyName;
            model.EmailAddress = _view.EmailAddress;
            _service.Save(model);
        }
    }
}
