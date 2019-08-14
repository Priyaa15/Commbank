using Commbank.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommBankTest.Pages
{
    class TravellingGuidancePage : BasePage
    {
        //Objects for the Travel Guidance page
        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'A mix of cash and cards')]")]
        IWebElement SubTopic1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'Get travel insurance')]")]
        IWebElement SubTopic2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'Review home and contents insurance')]")]
        IWebElement SubTopic3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'Check your limits')]")]
        IWebElement SubTopic4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'Check the expiry date')]")]
        IWebElement SubTopic5 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'Consider paying bills and credit cards automatically')]")]
        IWebElement SubTopic6 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'Know the fees and charges')]")]
        IWebElement SubTopic7 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'Tell us before you go')]")]
        IWebElement SubTopic8 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'Have a back-up plan')]")]
        IWebElement SubTopic9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'CommBank emergency details')]")]
        IWebElement SubTopic10 { get; set; }


        [FindsBy(How = How.CssSelector, Using = "div.content:nth-child(1) > p:nth-child(28) > a:nth-child(1)")]
        IWebElement NetBankLnk { get; set; }

        public NetbankLoginPage LogonToNetbankLink()
        {
            NetBankLnk.Click();        
            DriverContext.Driver.SwitchTo().Window(DriverContext.Driver.WindowHandles.Last());
            return GetInstance<NetbankLoginPage>();
        }



        public string GetSubtopics(int topic)
        {
         
            switch (topic)
            {
                case 1:return SubTopic1.Text;
                case 2: return SubTopic2.Text;
                case 3: return SubTopic3.Text;           
                case 4: return SubTopic4.Text;
                case 5: return SubTopic5.Text;
                case 6: return SubTopic6.Text;
                case 7: return SubTopic7.Text;
                case 8: return SubTopic8.Text;
                case 9: return SubTopic9.Text;
                case 10: return SubTopic10.Text;
                default: return null;

                   
            }
           


        }




    }


}
