using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class MyPageO
    {
        private IWebDriver driver;

        public MyPageO(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToO = "/html/body/div[1]/div[2]/div[1]/div/div[2]/div/div/div/table/tbody/tr/td[1]/a[16]"; //нажать на букву О


        public MyPageO GoToO()
        {
            driver.FindElement(By.XPath(xPathGoToO)).Click();
            return new MyPageO(driver);
        }

    }
}