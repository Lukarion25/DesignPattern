namespace FacadePattern.BankInformation
{
    public class SecurityCode
    {
        private int GetSecurityCode()
        {
            return 0000;
        }

        public bool IsSecurityCodeCorrect(int securityCode)
        {
            if (securityCode == this.GetSecurityCode())
            {
                return true;
            }

            return false;
        }
    }
}
