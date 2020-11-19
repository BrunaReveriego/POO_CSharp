using ExemploHeranca.Entidades;
using Microsoft.VisualBasic;
using System;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Bruna", 500.0);
            Account acc2 = new SavingsAccount(1002, "Gabriel", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
