using System;

namespace L7_Exercise_Solution.Accounts
{
    public abstract class AccountBase
    {
        public double Balance { get; protected set; }

        public DateTime CreatedDateTime { get; private set; }

        public Client AccountOwner { get; set; }

        protected AccountBase()
        {
            CreatedDateTime = DateTime.Now;
            Balance = 0;
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }

        public abstract void Withdrawal(double amount);
    }
}
