using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditUnionFactory factory = new SavingsAccountFactory();
            ISavingsAccount citiAccount = factory.GetSavingsAccount("CITI-555-ACC");
            ISavingsAccount nationalAccount = factory.GetSavingsAccount("NATIONAL-888-ACC");

            Console.WriteLine($"citiAccount is a {citiAccount.GetType()} and balance is {citiAccount.Balance}");
            Console.WriteLine($"nationalAccount is a {nationalAccount.GetType()} and balance is {nationalAccount.Balance}");
        }
    }
}
