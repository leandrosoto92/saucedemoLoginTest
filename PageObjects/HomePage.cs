using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using saucedemoLoginPage.Common;
using NUnit.Framework;
using OpenQA.Selenium;

namespace saucedemoLoginPage.PageObjects
{
    class HomePage : HomePageLocators
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public bool LoginSuccessfuly()
        {
            return title.Text.Equals("PRODUCTS");
        }
    }
}
