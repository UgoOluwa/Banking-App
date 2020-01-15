using System;
using Bank_App_Class;

namespace Bank_App
{
    class Program
    {
        static void Main(string[] args)
        {

            Program.Interface();
        }

        public static void Interface()
        {
            Console.Title = "Zorn Bank";
            Console.WriteLine(" <<1>> Sign In \n <<2>> Sign Up \n <<3>> Exit");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.Write("Please Enter your Unique Id: ");
                var UniqueId = Console.ReadLine();
                var check = Admin.CheckUniqueId(UniqueId);
                if (check != "")
                {
                    Helper.UserDashboard(check, UniqueId);
                }
                else
                {
                    Console.WriteLine("Invalid Unique Id");
                    Interface();
                }


            }
            else if (input == "2")
            {
                Helper.RegisterCustomer();
            }
            else if (input == "3")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid input");
                Program.Interface();
            }
        }



    }
}
