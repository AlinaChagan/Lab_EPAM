using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFor92
{
    internal class SectionInBlog
    {
        private IWebDriver driver;

        public SectionInBlog(IWebDriver driver)
        {
            this.driver = driver;
        }

        public SectionInBlog SectionInBlogButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/dl/dt[1]/a")).Click();
            return new SectionInBlog(driver);
        }
    }


}
