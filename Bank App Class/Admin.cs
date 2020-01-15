using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank_App_Class
{
    public class Admin : Users
    {
        static Dictionary<Customer, List<Dictionary<string, Accounts>>> Customers = new Dictionary<Customer, List<Dictionary<string, Accounts>>>();
        static Dictionary<string, Accounts> Accounts = new Dictionary<string, Accounts>();
        static Dictionary<string, string> DomiciliaryAccounts = new Dictionary<string, string>();
        public Admin(string aName, string aEmail, int aid) : base(aName, aEmail, aid)
        {

        }

        public static bool RegisterCustomers(string aName, string aEmail)
        {
            Random rnd = new Random();
            var min = (int)Math.Pow(5, 5 - 1);
            var max = (int)Math.Pow(5, 5) - 1;
            var uniqueId = rnd.Next(min, max);
            var customer = new Customer(aName, aEmail, uniqueId);
            Customers.Add(customer, (new List<Dictionary<string, Accounts>>()));
            Console.WriteLine(" Sign Up Successfully \n Your Unique Id is {0}", uniqueId);
            return true;

        }

        public static string CheckUniqueId(string aUniqueId)
        {
            foreach (var value in Customers)
            {
                if (value.Key.id.ToString() == aUniqueId)
                {
                    return value.Key.name;
                }
            }

            return "";
        }

        public static void SaveCustomerAccounts(string aAccountType, Accounts aAccount, int aid)
        {
            foreach (var VARIABLE in Customers)
            {
                if (VARIABLE.Key.id == aid)
                {
                    var newAccount = new Dictionary<string, Accounts>();
                    VARIABLE.Value.Add(newAccount);
                }
            }
        }

        public static void SaveAccounts(string aAccountType, Accounts aAccount)
        {
            Accounts.Add(aAccountType, aAccount);
        }

        public static void SaveDomiciliaryAccount(string aAccountNumber, string aAccountCurrency)
        {
            DomiciliaryAccounts.Add(aAccountNumber, aAccountCurrency);
        }
    }
}