namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using BankAccount.Interfaces;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer client, decimal balance, decimal interest)
            : base(client, balance, interest)
        {

        }

        public void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public override decimal CalculateRate(int months)
        {
            if (this.Customer is IndividualCustomer && months > 3)
            {
                return (this.Balance * (this.Interest / 100 * months)) - (this.Balance * (this.Interest / 100 * 3));
            }           
            else if (this.Customer is CompanyCustomer && months > 2)
            {
                return (this.Balance * (this.Interest / 100 * months)) - (this.Balance * (this.Interest / 100 * 2));
            }
            else
            {
                return 0.0M;
            }
        }
    }
}
