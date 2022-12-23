using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFor9
{
    internal class ButInput
    {
        private IWebDriver driver;

        public ButInput(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ButInput ButInputButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/div/div/form/div/input[1]")).Click();
            return new ButInput(driver);
        }
    }
}
