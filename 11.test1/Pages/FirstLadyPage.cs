using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class FirstLadyPage
    {
        private IWebDriver driver;

        public FirstLadyPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToFirstLady = "/html/body/div/div[2]/div[1]/div/form[2]/a[9]";


        public FirstLadyPage GoToFirstLady()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/form[2]/a[10]")).Click();
            return new FirstLadyPage(driver);
        }

    }
}
