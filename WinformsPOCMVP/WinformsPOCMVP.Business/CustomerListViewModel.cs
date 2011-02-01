using System;

namespace WinformsPOCMVP.Business
{
    public class CustomerListViewModel
    {
        Guid Id { get; set; }
        string CompanyName { get; set; }

        public CustomerListViewModel(Guid id, string companyName)
        {
            Id = id;
            CompanyName = companyName;
        }
    }
}
