﻿using System;

namespace WinformsPOCMVP.Business
{
    public class CustomerListViewModel
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }

        public CustomerListViewModel(Guid id, string companyName)
        {
            Id = id;
            CompanyName = companyName;
        }
    }
}
