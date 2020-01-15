using System;
using System.Collections.Generic;
using Bank_App_Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Create_Account
{
    [TestClass]
    public class CreateAccountTest
    {
        [TestMethod]
        public void CreateAccount_Returns_A_List()
        {
            //Arrange
            string aAccountType = "Savings";
            string uId = "536372";
            string accountNumber = "87575757575"; // The main class has a random string generator, so you have to level the playing field 

            // Act
            DateTime now = DateTime.Now;
            string dateNow = now.ToString("F");
            var bankAccount = new Savings(accountNumber, "0", dateNow, int.Parse(uId));
            List<string> createdAccountInfo = new List<string>();
            createdAccountInfo.Add(bankAccount.accountNumber);
            createdAccountInfo.Add(bankAccount.accountBalance);
            createdAccountInfo.Add(bankAccount.owner.ToString());

            // Assert
            var actual = Users.CreateAccount(aAccountType, uId);
            CollectionAssert.AreEqual(createdAccountInfo, actual, "Lists are not Equal");
        }


    }
}
