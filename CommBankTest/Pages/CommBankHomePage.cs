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
    class CommBankHomePage : BasePage
    {
        //Objects for the commbank page
        [FindsBy(How = How.XPath, Using = "//*[@id='products']/div/div/div[3]/div[5]/div/a/div/div[3]/p")]
        IWebElement TravelTellMelnk { get; set; }

  


        public TravellingGuidancePage TellMeMoreLink()
        {
            TravelTellMelnk.Click();
            return GetInstance<TravellingGuidancePage>();
        }

    }
}
