using Commbank.Config;
using Commbank.Helpers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commbank.Base
{
    public abstract class TestInitializeHook : Base
    {
        public readonly BrowserType Browser;
        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }

        public void InitializeSettings()
        {
            //Set all the settings for framework
            ConfigReader.SetFrameworkSettings();

            //Set logs
            LogHelpers.CreateLogFile();

            //Open Browser
            OpenBrowser(Browser);
            LogHelpers.Write("Initialised framework");

        }



        private void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                default:

                    break;
            }
        }

        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("Opened the browser !!!");
        }
    }
}
