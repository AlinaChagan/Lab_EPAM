using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class TabSkachatPage
    {
        private IWebDriver driver;

        public TabSkachatPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToEmail = "/html/body/div/div[2]/div[1]/div/form/label[1]/select"; //ввести почту сюда
        private string xPathGoToFormat = "/html/body/div/div[2]/div[1]/div/form/label[2]/select"; //выбрать формат здесь
        private string xPathGoToSend = "/html/body/div/div[2]/div[1]/div/form/input"; //кнопка отправить
      
        
        public TabSkachatPage TabUpLoad()
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/div[3]/a[4]")).Click();
            return new TabSkachatPage(driver);
        }
    }
}
