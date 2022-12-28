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
    internal class TabGenres
    {
        private IWebDriver driver;

        public TabGenres(IWebDriver driver)
        {
            this.driver = driver;
        }

        public TabGenres TabGenresButton()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[3]/div/div/ul/li[1]/ul/li[2]/a")).Click();
            return new TabGenres(driver);
        }
    }
}
