using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestFor9
{
    internal class Genres
    {
        private IWebDriver driver;

        public Genres(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Genres GenresButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/ul[10]/li[12]/a[2]")).Click();
            return new Genres(driver);
        }
    }
}
