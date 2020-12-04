using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Singleton implementation Test --> ");

            Singleton singletonObjectOne = Singleton.GetInstance;
            Singleton singletonObjectTwo = Singleton.GetInstance;

            if (singletonObjectOne == singletonObjectTwo) Console.WriteLine("Singleton implementation works.");
            else Console.WriteLine("Singleton objects are different, therefore singleton implementation is incorrect.");
        }
    }
}
