using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFor9
{
    internal class TabLogin
    {
        private IWebDriver driver;

        public TabLogin(IWebDriver driver)
        {
            this.driver = driver;
        }

        public TabLogin TabLoginButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/div/div/form/div/div[2]/input")).SendKeys("ChaganCHik");
            return new TabLogin(driver);
        }
    }
}
