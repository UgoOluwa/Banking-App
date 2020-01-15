using System.Collections.Generic;

namespace Bank_App_Class
{

    public abstract class Accounts
    {
        public string accountNumber;
        public string accountBalance;
        public string dateCreated;
        public int owner;
        Dictionary<string, List<string>> Transactions = new Dictionary<string, List<string>>();

        public Accounts(string aAccountNumber, string aAccountBalance, string aDateCreated, int aOwner)
        {
            accountNumber = aAccountNumber;
            accountBalance = aAccountBalance;
            dateCreated = aDateCreated;
            owner = aOwner;
        }


    }
}