using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class TabMailPage
    {
        private IWebDriver driver;

        public TabMailPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToMail = "/html/body/div/div[2]/div[1]/div/div[3]/a[4]"; //нажать на mail


        public TabMailPage GoToMail()
        {
            driver.FindElement(By.XPath("xPathGoToMail")).Click();
            return new TabMailPage(driver);
        }

    }
}
