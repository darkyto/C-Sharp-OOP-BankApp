namespace BankAccount
{
    using System;
    using System.Collections.Generic;

    public class Bank
    {
        private string bankName;
        private List<Account> acounts;
        private List<Customer> customers;

        public Bank(string name, List<Account> acounts , List<Customer> customers)
        {
            this.BankName = name;
            this.Acounts = acounts;
            this.Customers = customers;
        }

        protected List<Customer> Customers
        {
            get { return customers; }
            private set { customers = value; }
        }

        protected List<Account> Acounts
        {
            get { return acounts; }
            private set { acounts = value; }
        }
        public string BankName
        {
            get { return this.bankName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Bank name value cannot be null or empty string!");
                }
                this.bankName = value; 
            }
        }

        public override string ToString()
        {
            return string.Format("Bank name: " + this.BankName);
        }

    }
}
