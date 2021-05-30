using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploHeranca.Entidades
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //método de superclasse como virtual
        //sobreposição => reimplementação da subclasse a operação que já existe
        //na superclasse 

        public override void Withdraw(double amount)
        {

            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
