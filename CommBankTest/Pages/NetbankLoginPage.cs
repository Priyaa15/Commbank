using Commbank.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommBankTest.Pages
{
    class NetbankLoginPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "txtMyClientNumber$field")]
        IWebElement ClientNumberFld { get; set; }

        [FindsBy(How = How.XPath, Using = "txtMyPassword$field")]
        IWebElement PswdFld { get; set; }

        public bool HasClientNumberField()
        {
            return ClientNumberFld.Displayed ? true : false;
        }

        public bool HasPasswordField()
        {
            return PswdFld.Displayed ? true : false;
        }
    }


}
