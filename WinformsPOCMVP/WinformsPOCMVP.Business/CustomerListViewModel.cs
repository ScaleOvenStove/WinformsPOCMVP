using System;

namespace WinformsPOCMVP.Business
{
    public class CustomerListViewModel
    {
        string Id { get; set; }
        string CompanyName { get; set; }

        public CustomerListViewModel(string id, string companyName)
        {
            Id = id;
            CompanyName = companyName;
        }
    }
}
