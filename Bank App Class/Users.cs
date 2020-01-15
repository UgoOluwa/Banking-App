using System;
using System.Collections.Generic;

namespace Bank_App_Class
{
    public class Users
    {
        public int id;
        public string name;
        public string email;
        private static int decoy;
        public Users(string aName, string aEmail, int aid)
        {
            name = aName;
            email = aEmail;
            id = aid;
        }

        // public int Id
        // {
        //     get { return id; }
        //     set { id = value; }
        // }

        public static List<string> CreateAccount(string aAccountType, string uId)
        {
            DateTime now = DateTime.Now;
            string dateNow = now.ToString("F");
            Random rnd = new Random();
            var min = (int)Math.Pow(10, 10 - 1);
            var max = (int)Math.Pow(10, 10) - 1;
            var bankAccount = new Savings(rnd.Next(min, max).ToString(), "0", dateNow, int.Parse(uId));
            Admin.SaveAccounts(aAccountType, bankAccount);
            Admin.SaveCustomerAccounts(aAccountType, bankAccount, int.Parse(uId));

            List<string> createdAccountInfo = new List<string>();
            createdAccountInfo.Add(bankAccount.accountNumber);
            createdAccountInfo.Add(bankAccount.accountBalance);
            createdAccountInfo.Add(bankAccount.owner.ToString());
            return createdAccountInfo;

        }
    }
}
