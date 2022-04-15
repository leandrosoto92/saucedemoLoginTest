using System;
using saucedemoLoginPage.Common;
using NUnit.Framework;
using OpenQA.Selenium;

namespace saucedemoLoginPage.PageObjects
{
    class HomePageLocators : Base
    {
        public HomePageLocators(IWebDriver driver) : base(driver) { }
        public IWebElement title => this.elementCSS("span[class='title']");
    }
}
