using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFor9
{
    internal class TabPassword
    {
        private IWebDriver driver;

        public TabPassword(IWebDriver driver)
        {
            this.driver = driver;
        }

        public TabPassword TabPasswordButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/div/div/form/div/div[3]/input")).SendKeys("polkpolk1");
            return new TabPassword(driver);
        }
    }
}
