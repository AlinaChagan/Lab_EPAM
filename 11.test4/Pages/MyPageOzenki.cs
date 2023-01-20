using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class MyPageOzenki
    {
        private IWebDriver driver;

        public MyPageOzenki(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToPop = "/html/body/div/div[2]/div[1]/div/a[1]"; //нажать на оценки


        public MyPageOzenki GoToOzenki()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/a[1]")).Click();
            return new MyPageOzenki(driver);
        }

    }
}