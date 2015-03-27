namespace BankAccount
{
    using System;
    using System.Collections.Generic;

    public class ConsoleTests
    {
        static void Main(string[] args)
        {
            /*
             OK==== A bank holds different types of accounts for its customers: 
             OK==== deposit accounts, loan accounts and mortgage accounts. 
             OK==== Customers could be individuals or companies. 
             OK==== All accounts have customer, balance and interest rate (monthly based).
             OK==== Deposit accounts are allowed to deposit and with draw money.
             OK==== Loan and mortgage accounts can only deposit money.
             OK==== All accounts can calculate their interest amount for a given period (in months). 
             OK==== In the common case its is calculated as follows: number_of_months * interest_rate.
             OK==== Loan accounts have no interest for the first 3 months if are held by individuals 
             OK==== and for the first 2 months if are held by a company.
             OK==== Deposit accounts have no interest if their balance is positive and less than 1000.
             OK==== Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
             OK==== Your task is to write a program to model the bank system by classes and interfaces.
             OK==== You should identify the classes, interfaces, base classes and abstract actions and implement 
             OK==== the calculation of the interest functionality through overridden methods.
             */
            Line('=', 50);
            Console.WriteLine("         PROBLEM : BANK ACCOUNTS");
            Line('=', 50); 
            
            IndividualCustomer newCustomer = new IndividualCustomer("Petur Ivanov");
            CompanyCustomer newCompanyClient = new CompanyCustomer("OZIRIS OOD");

            DepositAccount peshoPepositAcc = new DepositAccount(newCustomer, 10000, 0.5M);
            DepositAccount ozirisDeposisAcc = new DepositAccount(newCompanyClient, 2500, 1.2M);

            List<Account> accounts = new List<Account> { peshoPepositAcc, ozirisDeposisAcc };
            List<Customer> customers = new List<Customer> { newCustomer, newCompanyClient };

            Bank newBank = new Bank("KTB", accounts, customers); // Bank lists of custmers and accounts are protected (not visible after initalization)
            Console.WriteLine(newBank.ToString());
            Line('-', 50);

            var result = peshoPepositAcc.CalculateRate(12); // generated interest for 12 months with 10000 in account
            Console.WriteLine("Client : {0}\nBalance : {2}\nInterest rate for the period : {1}", newCustomer.Name, result , peshoPepositAcc.Balance); Line('-', 50);

            var ozirisRes = ozirisDeposisAcc.CalculateRate(24);
            Console.WriteLine("Client : {0}\nBalance : {2}\nInterest rate for the period : {1}", newCompanyClient.Name, ozirisRes, ozirisDeposisAcc.Balance); Line('-', 50);


            LoanAccount peshoLoanAcc = new LoanAccount(newCustomer, 5000, 1);        //test for individual client with loan
            LoanAccount companyLoanAcc = new LoanAccount(newCompanyClient, 5000, 1); // test for company client with loan
            var loanRate = peshoLoanAcc.CalculateRate(12);
            var loanRateCompany = companyLoanAcc.CalculateRate(12); 
            Console.WriteLine("Loan test for individual and company with different calculation of rate"); 
            Console.WriteLine("Pesho loan account rate 12 month "+loanRate);
            Console.WriteLine("Company loan account rate 12 month " + loanRateCompany); Line('-', 50);

            Console.WriteLine("Deposit (222) into Pesho loan account (5000)");
            peshoLoanAcc.Deposit(222);
            Console.WriteLine("New abalance : {0}",peshoLoanAcc.Balance); Line('-', 50);

            Console.WriteLine("Withdraw money (150) from Pesho's deposit account(10000)");
            peshoPepositAcc.Withdraw(150);
            Console.WriteLine("New balance after withdrawal: {0}", peshoPepositAcc.Balance); Line('-', 50);

            Console.WriteLine("Creating new MortgageAccount for Pesho (balance:5000 , interest: 1% monthly)");
            MortgageAccount peshoMortrage = new MortgageAccount(newCustomer, 5000, 1);            
            Console.WriteLine("Intereset: "+peshoMortrage.CalculateRate(12) + " (NO interest for 6 months and then 6 month 1%)");
            Line('-', 50);

            Console.WriteLine("Creating new MortgageAcc for OZIRIS OOD (balance:1000 , interest: 2% monthly)");
            MortgageAccount ozirisMortAcc = new MortgageAccount(newCompanyClient, 1000, 2);
            Console.WriteLine("Intereset: " + ozirisMortAcc.CalculateRate(12) + " (first 12 months 1/2 % )");
            Line('-', 50);
            Line('=', 50);
        }
        public static void Line(char symbol, int lenght) 
        {
            Console.WriteLine(new string(symbol,lenght));
        }
    }
}
