using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    public abstract class Account
    {
        #region fields
        private Customer customer;
        private decimal balance;
        private decimal interest; // monthly percent
        #endregion

        #region Consturctor
        public Account(Customer client, decimal balance, decimal interest)
        {
            this.Customer = client;
            this.Balance = balance;
            this.Interest = interest;
        }
        #endregion

        #region Properties
        public decimal Interest
        {
            get { return this.interest; }
            protected set { this.interest = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public Customer Customer
        {
            get { return this.customer; }
            private set { this.customer = value; }
        }
        #endregion

        #region Methods
        public virtual decimal CalculateRate(int months)
        {
            return this.Balance * (this.Interest / 100) * months; // base case to override in special cases
        }
        #endregion

    }
}
