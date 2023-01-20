using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class TabSeePage
    {
        private IWebDriver driver;

        public TabSeePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToSee = "/html/body/div/div[2]/div[1]/div/form[2]/p[3]"; //нажать на кнопку отслеживать


        public TabSeePage GoToSee()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/form[2]/p[3]")).Click();
            return new TabSeePage(driver);
        }

    }
}
