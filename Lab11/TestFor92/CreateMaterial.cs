using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFor92
{
    internal class CreateMaterial
    {
        private IWebDriver driver;

        public CreateMaterial(IWebDriver driver)
        {
            this.driver = driver;
        }

        public CreateMaterial CreateMaterialButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[3]/div/div/ul/li[6]/a")).Click();
            return new CreateMaterial(driver);
        }
    }

}
