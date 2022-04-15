using System;
using saucedemoLoginPage.Common;
using NUnit.Framework;
using OpenQA.Selenium;

namespace saucedemoLoginPage.PageObjects
{
    class LoginPageLocators : Base
    {
        public LoginPageLocators(IWebDriver driver) : base(driver) { }
        public IWebElement Username => this.elementID("user-name");
        public IWebElement Password => this.elementID("password");
        public IWebElement LoginBtn => this.elementID("login-button");
        //public IWebElement UsersList => this.elementID("login_credentials").FindElement(By.TagName("#text"));

        public IWebElement UsersList => this.elementID("login_credentials");
        public IWebElement loginPasssword => this.elementCSS("div[class='login_password']");

    }
}