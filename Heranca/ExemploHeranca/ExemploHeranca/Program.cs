using ExemploHeranca.Entidades;
using System;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            account.Loan(100);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.0;



        }
    }
}
