using System;

namespace WinformsPOCMVP.Business
{
    public class CustomerListViewModel
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }

        public CustomerListViewModel(string id, string companyName)
        {
            Id = id;
            CompanyName = companyName;
        }
    }
}
