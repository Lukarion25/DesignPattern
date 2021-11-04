namespace FacadePattern.BankInformation
{
    public class AccountNumber
    {
        private int GetAccountNumber()
        {
            return 123456;
        }

        public bool IsAccountActive(int accountNumber)
        {
            if (accountNumber == this.GetAccountNumber())
            {
                return true;
            }
           
            return false;
        }
    }
}
