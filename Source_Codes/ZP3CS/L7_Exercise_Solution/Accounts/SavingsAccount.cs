using System;

namespace L7_Exercise_Solution.Accounts
{
    public class SavingsAccount : AccountBase
    {
        public double InterestInPercents { get; set; }

        public DateTime NextInterestUpdate { get; set; }

        public SavingsAccount(double interestInPercents, DateTime nextInterestUpdate) : base()
        {
            if (interestInPercents < 0 || interestInPercents > 100)
            {
                throw new InvalidOperationException("Interest should be number between 0 and 100");
            }

            InterestInPercents = interestInPercents;
            NextInterestUpdate = CreatedDateTime.AddMonths(1);
        }

        public override void Withdrawal(double amount)
        {
            var balanceAfterWithdrawal = Balance - amount;

            if (balanceAfterWithdrawal < 0)
            {
                throw new InvalidOperationException("Withdrawal amount is too big!");
            }

            Balance = balanceAfterWithdrawal;
        }

        public void AddInterestToCurrentBalance()
        {
            if (DateTime.Today == NextInterestUpdate)
            {
                var interestToAdd = Balance / 100 * InterestInPercents;
                Balance += interestToAdd;
                NextInterestUpdate = NextInterestUpdate.AddMonths(1);
            }
        }
    }
}
