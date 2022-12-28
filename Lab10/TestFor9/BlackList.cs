using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFor9
{
    internal class BlackList
    {
        private IWebDriver driver;

        public BlackList(IWebDriver driver)
        {
            this.driver = driver;
        }

        public BlackList BlackListButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/a")).Click();
            return new BlackList(driver);
        }
    }
}
