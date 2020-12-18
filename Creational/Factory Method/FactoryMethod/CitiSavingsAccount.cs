namespace FactoryMethod
{
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 20000;
        }
    }
}