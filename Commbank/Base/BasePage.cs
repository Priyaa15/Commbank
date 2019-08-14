﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commbank.Base
{
    public abstract class BasePage : Base
    {

        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }



    }
}
