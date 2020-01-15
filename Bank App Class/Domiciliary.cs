using System;
using System.Collections.Generic;

namespace Bank_App_Class
{
    public class Domiciliary : Accounts
    {


        private double DollarExchangeRate = 360;
        private double PounsExchangeRate = 469.61;
        private double EurosEXCHANGErate = 402.5;
        public Domiciliary(string aAccountNumber, string aAccountBalance, string aDateCreated, int aOwner) :
            base(aAccountNumber, aAccountBalance, aDateCreated, aOwner)
        {

        }

        public static string GetCurrency(string currency)
        {
            switch (currency)
            {
                case "1":
                    return "Dollars";
                case "2":
                    return "Pounds";
                case "3":
                    return "Euros";
                default:
                    return "Please enter a valid currency";
            }
        }

        public static string GetCurrencySymbol(string currency)
        {
            string symbolOfCurrency = "";
            switch (currency)
            {
                case "Dollars":
                    symbolOfCurrency = "$";
                    return symbolOfCurrency;
                case "Pounds":
                    symbolOfCurrency = "£";
                    return symbolOfCurrency;
                case "Euros":
                    symbolOfCurrency = "€";
                    return symbolOfCurrency;
                default:
                    return symbolOfCurrency;
            }


        }

        public double GetRate()
        {
            return 0;
        }

        public static List<string> CreateAccount(string aAccountType, string uId, string aCurrency)
        {
            DateTime now = DateTime.Now;
            string dateNow = now.ToString("F");
            Random rnd = new Random();
            var min = (int)Math.Pow(10, 10 - 1);
            var max = (int)Math.Pow(10, 10) - 1;
            var bankAccount = new Domiciliary(rnd.Next(min, max).ToString(), "0", dateNow, int.Parse(uId));
            Admin.SaveCustomerAccounts(aAccountType, bankAccount, int.Parse(uId));
            Admin.SaveDomiciliaryAccount(bankAccount.accountNumber, aCurrency);
            List<string> createdAccountInfo = new List<string>();
            createdAccountInfo.Add(bankAccount.accountNumber);
            createdAccountInfo.Add(bankAccount.accountBalance);
            createdAccountInfo.Add(bankAccount.owner.ToString());
            return createdAccountInfo;

        }

    }
}