using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using saucedemoLoginPage.Common;
using saucedemoLoginPage.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace saucedemoLoginPage
{
    public class LoginTest : Base
    {
        LoginPage login;
        HomePage home;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            login = new LoginPage(driver);
            home = new HomePage(driver);
            OpenPage(driver, "https://www.saucedemo.com/");
            sleep(5);
        }

        [Test]
        public void Test1()
        {
            login.Login();
            sleep(5);
            if (home.LoginSuccessfuly())
            {
                Console.WriteLine("Login succeeded");
            }
            else
            {
                Console.WriteLine("Wrong login");
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}