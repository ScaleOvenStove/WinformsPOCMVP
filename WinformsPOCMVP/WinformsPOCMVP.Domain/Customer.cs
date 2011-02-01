using System;

namespace WinformsPOCMVP.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }
        public CustomerAccountType CustomerAccountType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneOne { get; set; }
        public string PhoneTwo { get; set; }
        public string AccountNumber { get; set; }
        public string MailingAddressOne { get; set; }
        public string MailingAddressTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }
}
