
namespace ExemploHeranca.Entidades
{
    class Account
    {

        // protected => libera alteração para subclasses Ex: BusinessAccount

        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }


        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
