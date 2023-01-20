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

        private string xPathGoToAuthors = "/html/body/div/div[1]/div[2]/div[1]/ul/li[1]/a"; //нажать на вкладку книжная полка


        public MyPage GoToBookPolka()
        {
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[1]/ul/li[1]/a")).Click();
            return new MyPage(driver);
        }

    }
}
