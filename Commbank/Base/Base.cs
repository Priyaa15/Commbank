using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commbank.Base
{
    public class Base
    {
        private IWebDriver _driver { get; set; }

        public BasePage CurrentPage { get; set; }

        // This method replaces calling of a new page everytime
        //of type base page and supports new object instance
        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };

            PageFactory.InitElements(DriverContext.Driver, pageInstance);

            return pageInstance;
        }

        //Method to get the actual current  Page using as
        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
