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
    class LoginPage : LoginPageLocators
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public void Login()
        {
            IList<string> acceptedUsers = this.UsersList.Text.Replace("Accepted usernames are:\r\n", "").Split("\r\n");
            Random random = new Random();
            write(acceptedUsers[random.Next(0, acceptedUsers.Count - 1)], this.Username);
            string password = this.loginPasssword.Text.Replace("Password for all users:\r\n", "");
            write(password, this.Password);
            sleep();
            LoginBtn.Click();

        }
    }
}
