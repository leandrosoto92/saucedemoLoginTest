using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace saucedemoLoginPage.Common
{
    public class Base
    {
        public IWebDriver driver;

        public Base(IWebDriver d = null)
        {
            driver = d;
        }
        public void OpenPage(IWebDriver driver, string  url)
        {
            sleep(1);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        public void sleep(int seg = 1)
        {
            Thread.Sleep(seg * 1000);
        }
        public IWebElement elementCSS(string elem)
        {
            return driver.FindElement(By.CssSelector(elem));
        } 
        public IWebElement elementID(string id)
        {
            return driver.FindElement(By.Id(id));
        }
        public void write(string text, IWebElement elem)
        {
            elem.Click();
            sleep();
            elem.SendKeys(text);
        }
    }
}
