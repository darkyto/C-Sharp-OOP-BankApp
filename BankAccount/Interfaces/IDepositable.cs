namespace BankAccount.Interfaces
{
    using System;

    public interface IDepositable
    {
        void Deposit(decimal sum);
    }
}
