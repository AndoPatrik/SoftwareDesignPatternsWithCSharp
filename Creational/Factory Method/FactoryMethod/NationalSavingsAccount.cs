namespace FactoryMethod
{
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Balance = 5000;
        }
    }
}