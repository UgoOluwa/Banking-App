using System;
using Bank_App_Class;

namespace Bank_App
{
    public class Helper
    {
        public static void RegisterCustomer()
        {
            Console.Write("What is your name: ");
            var name = Console.ReadLine();
            Console.Write("Please input your Email address: ");
            var email = Console.ReadLine();
            Console.Clear();
            var register = Admin.RegisterCustomers(name, email);
            if (register)
            {
                Program.Interface();
            }

        }

        public static void UserDashboard(string name, string uId)
        {
            Console.Clear();
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Welcome {0} what Transaction would you like to perform today",
                name);
            Console.WriteLine(
                " 1. Create account \n 2. Transfer fund \n 3. Deposit fund \n 4. Withdraw fund \n 5. Check account " +
                "balance \n 6. Print statement of account");
            var activity = Console.ReadLine();
            switch (activity)
            {
                case "1":
                    Create.CreateAccount(uId);
                    break;
            }
        }

        public static void TocContinue()
        {
            Console.WriteLine("Would you like to perform Another transaction: Yes/No");
            var response7 = Console.ReadLine();
            switch (response7.ToLower())
            {
                case "yes":
                    Program.Interface();
                    break;
                case "no":
                    Console.WriteLine("Thank you for banking with us");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Program.Interface();
                    break;
            }
        }


    }
}