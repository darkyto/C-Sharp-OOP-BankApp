namespace BankAccount.Interfaces
{
    using System;

    public interface IWithdrawable
    {
        void Withdraw(decimal sum);
    }
}
