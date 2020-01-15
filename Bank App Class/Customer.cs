using System.Collections.Generic;

namespace Bank_App_Class
{
    public class Customer : Users
    {
        Dictionary<string, string> Accounts = new Dictionary<string, string>();

        public Customer(string aName, string aEmail, int aid) : base(aName, aEmail, aid)
        {

        }




    }
}