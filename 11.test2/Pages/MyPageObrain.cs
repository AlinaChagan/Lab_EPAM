using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class MyPageObrain
    {
        private IWebDriver driver;

        public MyPageObrain(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoMyPageObrain = "/html/body/div[1]/div[2]/div[1]/div/ul/li[3]/div/table/tbody/tr/td/a[4]"; //нажать на автора Obrain


        public MyPageObrain GoToObrain()
        {
            driver.FindElement(By.XPath(xPathGoMyPageObrain)).Click();
            return new MyPageObrain(driver);
        }
    }
}