﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinformsPOCMVP.Business;

namespace WinformsPOCMVP.Ui
{
    public partial class CustomerDetailView : Form, ICustomerDetailView
    {
        private CustomerDetailPresenter _presenter;

        public CustomerDetailView()
        {
            InitializeComponent();
        }

        private void CustomerDetailView_Load(object sender, EventArgs eventArgs)
        {
            _presenter = new CustomerDetailPresenter(this);
            //_presenter.Initialize();
        }

        public bool IsIndividualCustomer
        {
            get { return IndividualCustomerCheckBox.Checked; }
            set { IndividualCustomerCheckBox.Checked = value; }
        }

        public string FirstName
        {
            get { return FirstNameTextBox.Text; }
            set { FirstNameTextBox.Text = value; }
        }

        public string LastName
        {
            get { return LastNameTextBox.Text; }
            set { LastNameTextBox.Text = value; }
        }

        public new string CompanyName
        {
            get { return CompanyNameTextBox.Text; }
            set { CompanyNameTextBox.Text = value; }
        }

        public string EmailAddress
        {
            get { return EmailTextBox.Text; }
            set { EmailTextBox.Text = value; }
        }

        public string PhoneOne
        {
            get { return PhoneOneTextBox.Text; }
            set { PhoneOneTextBox.Text = value; }
        }

        public string PhoneTwo
        {
            get { return PhoneTwoTextBox.Text; }
            set { PhoneTwoTextBox.Text = value; }
        }

        public string AccountNumber
        {
            get { return AccountNumberTextBox.Text; }
            set { AccountNumberTextBox.Text = value; }
        }

        public string MailingAddressOne
        {
            get { return AddressLineOneTextBox.Text; }
            set { AddressLineOneTextBox.Text = value; }
        }

        public string MailingAddressTwo
        {
            get { return AddressLineTwoTextBox.Text; }
            set { AddressLineTwoTextBox.Text = value; }
        }

        public string City
        {
            get { return CityTextBox.Text; }
            set { CityTextBox.Text = value; }
        }

        public string State
        {
            get { return StateTextBox.Text; }
            set { StateTextBox.Text = value; }
        }

        public string ZipCode
        {
            get { return ZipCodeTextBox.Text; }
            set { ZipCodeTextBox.Text = value; }
        }

        public string Country
        {
            get { return CountryTextBox.Text; }
            set { CountryTextBox.Text = value; }
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void BeginViewUpdate()
        {
            //disable event handling
        }

        public void EndViewUpdate()
        {
            //enable event handling
        }

        public string CustomerAccountTypeText
        {
            set { AccountTypeLabel.Text = value; }
        }
        
        public IList<CustomerListViewModel> CustomersSelectList
        {
            set { CustomerListComboBox.DataSource = value; }
        }

        public Guid SelectedCustomer
        {
            get { return (Guid)CustomerListComboBox.SelectedValue; }
        }

    }
}