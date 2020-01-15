using System;
using System.Collections.Generic;
using System.Text;
using Bank_App_Class;

namespace Bank_App
{
    static class Create
    {
        public static void CreateAccount(string uId)
        {
            Console.Clear();
            Console.WriteLine(" <<1>> Savings \n <<2>> Current \n <<3>> Domiciliary");
            string accountChosen = Console.ReadLine();
            switch (accountChosen)
            {
                case "1":
                    accountChosen = "Savings";
                    var createdAccount = Users.CreateAccount(accountChosen, uId);
                    Console.WriteLine("Account Created Successfully");
                    Console.WriteLine("Your Account Number is {0}", createdAccount[0]);
                    Console.WriteLine("Your Account Balance is NGN{0}", createdAccount[1]);
                    Console.WriteLine("Your Unique ID is {0}", createdAccount[2]);
                    Console.WriteLine("You must deposit NGN500 as minimum amount");
                    Helper.TocContinue();
                    break;
                case "2":
                    accountChosen = "Current";
                    var createdAccountCurrent = Users.CreateAccount(accountChosen, uId);
                    Console.WriteLine("Account Created Successfully");
                    Console.WriteLine("Your Account Number is {0}", createdAccountCurrent[0]);
                    Console.WriteLine("Your Account Balance is NGN{0}", createdAccountCurrent[1]);
                    Console.WriteLine("Your Unique ID is {0}", createdAccountCurrent[2]);
                    Helper.TocContinue();
                    break;
                case "3":
                    accountChosen = "Domiciliary";
                    Console.Clear();
                    Console.WriteLine(" <<1>> Dollars \n <<2>> Pounds \n <<3>> Euros");
                    var accountChosenDomiciliary = Console.ReadLine();
                    var currencyChosen = Domiciliary.GetCurrency(accountChosenDomiciliary);
                    var currencySymbol = Domiciliary.GetCurrencySymbol(currencyChosen);
                    var createdAccountDomiciliary = Domiciliary.CreateAccount(accountChosen, uId, currencyChosen);
                    Console.WriteLine("Account Created Successfully");
                    Console.WriteLine("Your Account Number is {0}", createdAccountDomiciliary[0]);
                    Console.WriteLine("Your Account Balance is {0}{1}", currencySymbol, createdAccountDomiciliary[1]);
                    Console.WriteLine("Your Unique ID is {0}", createdAccountDomiciliary[2]);
                    Helper.TocContinue();
                    break;
            }
        }
    }
}
