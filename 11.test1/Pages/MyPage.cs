using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class MyPage
    {
        private IWebDriver driver;

        public MyPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToHome = "/html/body/div/div[1]/div[1]/h1/a"; //нажать на вклладку главная


        public MyPage GoToHome()
        {
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/h1/a")).Click();
            return new MyPage(driver);
        }

    }
}
