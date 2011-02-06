using System;
using System.Collections.Generic;
using WinformsPOCMVP.Business;

namespace WinformsPOCMVP.Presentation
{
    public interface ICustomerDetailView
    {
        //Properties
        bool IsIndividualCustomer { get; set; }
        string CustomerAccountTypeText { set; }
        IList<CustomerListViewModel> CustomersSelectList { set; }
        Guid SelectedCustomer { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string CompanyName { get; set; }
        string EmailAddress { get; set; }
        string PhoneOne { get; set; }
        string PhoneTwo { get; set; }
        string AccountNumber { get; set; }
        string MailingAddressOne { get; set; }
        string MailingAddressTwo { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        string Country { get; set; }

        //Methods
        void Cancel();
        void Save();
        void BeginViewUpdate();
        void EndViewUpdate();
    }
}
