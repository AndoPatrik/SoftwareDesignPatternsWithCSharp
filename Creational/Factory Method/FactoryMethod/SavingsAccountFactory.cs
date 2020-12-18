using System;

namespace FactoryMethod
{
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string accountNumber)
        {
            if (accountNumber.Contains("CITI")) { return new CitiSavingsAccount(); }
            else if (accountNumber.Contains("NATIONAL")) { return new NationalSavingsAccount(); }
            else throw new ArgumentException("Invalid Account Number");
        }
    }
}