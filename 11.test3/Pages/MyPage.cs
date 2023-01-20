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

        private string xPathGoToAuthors = "/html/body/div[1]/div[2]/div[2]/div[1]/div/div/div/ul/li[4]/a"; //нажать на вкладку популрные книги


        public MyPage GoToAuthors()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div/div/div/ul/li[4]/a")).Click();
            return new MyPage(driver);
        }

    }
}
