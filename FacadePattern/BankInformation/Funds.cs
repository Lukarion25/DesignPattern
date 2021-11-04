using System;

namespace FacadePattern.BankInformation
{
    public class Funds
    {
        private int _cashInAccount = 9000;

        public int GetCashInAccount()
        {
            return _cashInAccount;
        }

        public void DecreaseCashInAccount(int cashWithdrawn)
        {
            _cashInAccount -= cashWithdrawn;
        }
        public void IncreaseCashInAccount(int cashDeposited)
        {
            _cashInAccount += cashDeposited;
        }

        public bool HaveEnoughMoney(int cashToWithdrawal)
        {
            if (cashToWithdrawal > this.GetCashInAccount())
            {
                Console.WriteLine("Error: You don't have enough money");
                Console.WriteLine("Current Balance: " + GetCashInAccount());
                return false;
            }
            else
            {
                this.DecreaseCashInAccount(cashToWithdrawal);
                Console.WriteLine("Withdrawal Complete: Current Balance is " + this.GetCashInAccount());
                return true;
            }
        }

        public void makeDeposit(int cashToDeposit)
        {
            this.IncreaseCashInAccount(cashToDeposit);
            Console.WriteLine("Deposit Complete: Current Balance is " + this.GetCashInAccount());
        }
    }
}
