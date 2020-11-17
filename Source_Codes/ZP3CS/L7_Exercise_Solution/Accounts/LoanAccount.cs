using System;

namespace L7_Exercise_Solution.Accounts
{
    public class LoanAccount : AccountBase
    {
        public DateTime NextPaymentDate { get; set; }

        public LoanAccount(double balance) : base()
        {
            if (balance >= 0)
            {
                throw new InvalidOperationException("Balance should be negative when creating loan account");
            }

            NextPaymentDate = CreatedDateTime.AddMonths(1);
            Balance = balance;
        }

        public void LoanPayback()
        {
            if (DateTime.Today == NextPaymentDate)
            {
                Deposit(10000);
                NextPaymentDate = NextPaymentDate.AddMonths(1);
            }
        }

        public override void Deposit(double amount)
        {
            if (amount + Balance > 0)
            {
                throw new InvalidOperationException("Balance on loan account cannot be positive.");
            }

            Balance += amount;
        }

        public override void Withdrawal(double amount)
        {
            throw new InvalidOperationException("Can't withdrawal from loan account");
        }
    }
}
