namespace FacadePattern.BankInformation
{
    public class Credential
    {
        public Credential(int accountNumber, int securityCode)
        {
            _accountNumber = accountNumber;
            _securityCode = securityCode;
        }

        private int _accountNumber;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        private int _securityCode;

        public int SecurityCode
        {
            get { return _securityCode; }
            set { _securityCode = value; }
        }


    }
}
