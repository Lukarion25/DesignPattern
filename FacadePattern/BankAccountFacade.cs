using FacadePattern.BankInformation;
using System;

namespace FacadePattern
{
    public class BankAccountFacade
    {
        private Credential _credential;
        private AccountNumber _accountNumber;
        private SecurityCode _securityCode;
        private Funds _funds;

        public BankAccountFacade(Credential credential, AccountNumber accountNumber, SecurityCode securityCode, Funds funds)
        {
            _credential = credential;
            _accountNumber = accountNumber;
            _securityCode = securityCode;
            _funds = funds;
        }

        public void WithdrawCash(int cash)
        {
            if (_accountNumber.IsAccountActive(_credential.AccountNumber) && _securityCode.IsSecurityCodeCorrect(_credential.SecurityCode) && _funds.HaveEnoughMoney(cash))
            {
                Console.WriteLine("Transaction Complete\n");
            }
            
            Console.WriteLine("Transaction Failed\n");
        }

        public void DepositCash(int cash)
        {
            if (_accountNumber.IsAccountActive(_credential.AccountNumber) && _securityCode.IsSecurityCodeCorrect(_credential.SecurityCode))
            {
                _funds.makeDeposit(cash);
                Console.WriteLine("Transaction Complete\n");
            }
            
            Console.WriteLine("Transaction Failed\n");
        }
    }
}
