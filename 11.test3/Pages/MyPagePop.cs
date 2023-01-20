using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class MyPagePop
    {
        private IWebDriver driver;

        public MyPagePop(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToPop = "/html/body/div/div[2]/div[1]/div/a[5]"; //нажать на рейтинг


        public MyPagePop GoToPop()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/a[5]")).Click();
            return new MyPagePop(driver);
        }

    }
}