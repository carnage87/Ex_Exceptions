using System;
using System.Collections.Generic;
using System.Text;
using Exercicios_de_Fixacao_7.Entities.Exceptions;
using System.Globalization;

namespace Exercicios_de_Fixacao_7.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (balance < 0)
            {
                throw new DomainException("Initial balance cannot be negative.");
            }
            if (withdrawLimit < 1)
            {
                throw new DomainException("Withdraw limit must be superior at 0 (zero).");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw limit exceeded.");
            }
            if (amount > Balance)
            {
                throw new DomainException("Balance cannot stay negative.");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance: $" + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
