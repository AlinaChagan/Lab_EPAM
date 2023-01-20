using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class MyPageAll
    {
        private IWebDriver driver;

        public MyPageAll(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToAll = "/html/body/div[1]/div[2]/div[1]/div/div[2]/div/div/div/table/tbody/tr/td[1]/a[1]"; //нажать на пункт все 
        private string xPathGoToAkrill = "/html/body/div/div[2]/div[1]/div/ol/li[12]/a"; //нажать на пункт Akrill


        public MyPageAll GoToAll()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div[2]/div/div/div/table/tbody/tr/td[1]/a[1]")).Click();
            return new MyPageAll(driver);
        }

        public MyPageAll GoToAkrill()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/ol/li[12]/a")).Click();
            return new MyPageAll(driver);
        }
    }
}