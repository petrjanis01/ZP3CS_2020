using System;

namespace L7_Exercise_Solution.Accounts
{
    public class CommonAccount : AccountBase
    {
        public int NegativeBalanceLimit { get; private set; }

        public CommonAccount(int negativeBalanceLimit) : base()
        {
            NegativeBalanceLimit = negativeBalanceLimit;
        }

        public override void Withdrawal(double amount)
        {
            var balanceAfterWithdrawal = Balance - amount;

            if (balanceAfterWithdrawal < NegativeBalanceLimit)
            {
                throw new InvalidOperationException("Withdrawal amount is too big!");
            }

            Balance = balanceAfterWithdrawal;
        }
    }
}
