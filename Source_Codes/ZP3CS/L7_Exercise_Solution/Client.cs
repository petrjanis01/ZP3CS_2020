using System;
using System.Collections.Generic;
using System.Linq;
using L7_Exercise_Solution.Accounts;

namespace L7_Exercise_Solution
{
    public class Client : Person
    {
        public List<AccountBase> ClientsAccounts { get; set; }

        public Client(string name, string surname, DateTime birthDate) : base(name, surname, birthDate)
        {
            ClientsAccounts = new List<AccountBase>();

        }

        public void CreateNewAccountForClient<TAccount>(TAccount newAccount) where TAccount : AccountBase
        {
            if (newAccount is LoanAccount && ClientsAccounts.Any(ca => ca is CommonAccount) == false)
            {
                throw new InvalidOperationException("Client has to have at least one current account to own loan account");
            }

            newAccount.AccountOwner = this;
            ClientsAccounts.Add(newAccount);
        }
    }
}
