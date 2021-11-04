using FacadePattern.BankInformation;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var credential = new Credential(123456, 0000);
            var accountNumber = new AccountNumber();
            var securityCode = new SecurityCode();
            var funds = new Funds();

            var bankAccountFacade = new BankAccountFacade(credential, accountNumber, securityCode, funds);
            bankAccountFacade.WithdrawCash(5000);
            bankAccountFacade.WithdrawCash(10000);
        }
    }
}
