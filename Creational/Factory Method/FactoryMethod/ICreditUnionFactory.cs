namespace FactoryMethod
{
    public interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string accountNo);
    }
}