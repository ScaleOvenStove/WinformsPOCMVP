using System;
using WinformsPOCMVP.Business;
using WinformsPOCMVP.Domain;

namespace WinformsPOCMVP.Ui
{
    public class CustomerDetailPresenter
    {
        private ICustomerDetailView _view;
        private ICustomerService _service;
        private ViewMode _viewMode = ViewMode.Edit;

        public CustomerDetailPresenter(ICustomerDetailView view)
        {
            _view = view;
            _service = new CustomerService();
            //Initialize();
        }

        public void Initialize()
        {
            _view.BeginViewUpdate();

            if(_viewMode == ViewMode.Edit)
            {
                RetrieveAndBindModel(new Guid("6F2BF47B-1A4F-4D7D-AE21-DB14ECF40444"));
            }

            _view.CustomersSelectList = _service.GetCustomerList();

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
            _view.CompanyName = model.CompanyName;
            _view.EmailAddress = model.EmailAddress;

            _view.EndViewUpdate();
        }

        internal void ShowCustomerDetails()
        {
            
        }
    }
}
