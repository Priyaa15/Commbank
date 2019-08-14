using System;
using Commbank.Config;
using CommBankTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CommBankTest
{
    [TestClass]
    public class UnitTest1 : HookInitialize
    {

        [TestMethod]
        public void TestMethod1()
        {
            ConfigReader.SetFrameworkSettings();


            CurrentPage = GetInstance<CommBankHomePage>();
            CurrentPage = CurrentPage.As<CommBankHomePage>().TellMeMoreLink();
        
            //Assert sub topics
            Assert.AreEqual("1. A mix of cash and cards", CurrentPage.As<TravellingGuidancePage>().GetSubtopics(1));
            Assert.AreEqual("2. Get travel insurance", CurrentPage.As<TravellingGuidancePage>().GetSubtopics(2));
            Assert.AreEqual("3. Review home and contents insurance", CurrentPage.As<TravellingGuidancePage>().GetSubtopics(3));
            Assert.AreEqual("4. Check your limits ", CurrentPage.As<TravellingGuidancePage>().GetSubtopics(4));
            Assert.AreEqual("5. Check the expiry date", CurrentPage.As<TravellingGuidancePage>().GetSubtopics(5));
            Assert.AreEqual("6. Consider paying bills and credit cards automatically", CurrentPage.As<TravellingGuidancePage>().GetSubtopics(6));
            Assert.AreEqual("7. Know the fees and charges", CurrentPage.As<TravellingGuidancePage>().GetSubtopics(7));
            Assert.AreEqual("8. Tell us before you go", CurrentPage.As<TravellingGuidancePage>().GetSubtopics(8));
            Assert.AreEqual("9. Have a back-up plan", CurrentPage.As<TravellingGuidancePage>().GetSubtopics(9));
            Assert.AreEqual("CommBank emergency details", CurrentPage.As<TravellingGuidancePage>().GetSubtopics(10));

            //log onto netbank
            CurrentPage.As<TravellingGuidancePage>().LogonToNetbankLink();
            CurrentPage = CurrentPage.As<NetbankLoginPage>();

            //Assert username password exists
            Assert.IsTrue(CurrentPage.As<NetbankLoginPage>().HasClientNumberField());
            Assert.IsTrue(CurrentPage.As<NetbankLoginPage>().HasPasswordField());

        }
    }
}
