namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using BankAccount.Interfaces;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer client, decimal balance, decimal interest) 
            :base(client , balance, interest)
        {

        }

        public void Withdraw(decimal sum)
        {
            if (this.Balance > sum)
            {
                this.Balance -= sum;
            }
            else
            {
                throw new ArgumentException("Withdraw sum is larger than total balance funds!");
            }
        }

        public void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public override decimal CalculateRate(int months)
        {
            if (this.Balance < 1000 && this.Balance > 0)
            {
                return 0.0M;
            }
            else
            {
                return this.Balance * (this.Interest / 100 * months);
            }
        }
    }
}
