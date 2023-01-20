using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class MyPageReiting
    {
        private IWebDriver driver;

        public MyPageReiting(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToReiting = "/html/body/div/div[2]/div[1]/div/form/input[4]"; //нажать на htqnbyu


        public MyPageReiting GoToReiting()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/form/input[4]")).Click();
            return new MyPageReiting(driver);
        }

    }
}