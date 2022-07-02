using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Entidades
{
    class Account
    {
        public int Number { get; set; } //Número
        public string Holder { get; set; } //Suporte
        public double Balance { get; set; } // Equilíbrio
        public double WithdrawLimit { get; set; } //Limite de retirada

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount) //montante
        {
            Balance = Balance + amount;
        }
        public void Withdraw(double amount) //Retirar
        {
            if (amount<=WithdrawLimit && amount < Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine("New balance: {0}",Balance.ToString("F2"));

            }
            else if(amount> WithdrawLimit)
            {
                Console.WriteLine("Withdraw error: The amount exceeds withdraw limit");
            }
            else if (amount>Balance)
            {
                Console.WriteLine("Withdraw error: Not enough balance");
            }
        }
      
    }
}
