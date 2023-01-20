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

        private string xPathGoToAuthors = "/html/body/div/div[2]/div[2]/div[3]/div/div/ul/li[1]/ul/li[3]/a"; //нажать на вкладку авторы


        public MyPage GoToAuthors()
        {
            driver.FindElement(By.XPath(xPathGoToAuthors)).Click();
            return new MyPage(driver);
        }

    }
}
