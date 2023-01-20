using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class MyPageBooks
    {
        private IWebDriver driver;

        public MyPageBooks(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToBooks = "/html/body/div/div[2]/div[2]/div[3]/div/div/ul/li[1]/a"; //нажать на пункт КНИГИ


        public MyPageBooks GoToBooks()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[3]/div/div/ul/li[1]/a")).Click();
            return new MyPageBooks(driver);
        }

    }
}