namespace Bank_App_Class
{
    public class Savings : Accounts
    {
        public Savings(string aAccountNumber, string aAccountBalance, string aDateCreated, int aOwner) :
            base(aAccountNumber, aAccountBalance, aDateCreated, aOwner)
        {

        }

        public int GetMinimumBalance()
        {
            return 500;
        }

    }
}