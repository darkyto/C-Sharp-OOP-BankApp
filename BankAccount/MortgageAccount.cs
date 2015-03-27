
namespace BankAccount
{
    using System;
    using BankAccount.Interfaces;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer client, decimal balance, decimal interest)
            : base(client, balance, interest)
        {

        }

        public void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public override decimal CalculateRate(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months <= 6)
                {
                    return 0.0M; //no interest for the first 6 months for individuals.
                }
                else
                {
                    months -= 6; 
                    return (this.Balance * (this.Interest / 100 * months));
                }
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (months <= 12) // // Mortgage accounts have ½ interest for the first 12 months for companies
                {
                    return (this.Balance * (this.Interest / 200 * months));
                }
                else
                {
                    months -= 12;
                    return ((this.Balance * (this.Interest / 200 * 12)) + (this.Balance * (this.Interest / 100 * months)));
                }
            }
            else
            {
                return 0.0M;
            }
        }
    }
}
