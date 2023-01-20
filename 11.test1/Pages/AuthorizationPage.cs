using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    internal class AuthorizationPage
    {
        private IWebDriver driver;

        public AuthorizationPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        private const string TARGET_URL = "http://flibusta.is/";

        private string xPathLogInName = "/html/body/div/div[2]/div[2]/div[2]/div/div/form/div/div[2]/input"; // поле имя пользователя ChaganCHik
        private string xPathLogInPasword = "/html/body/div/div[2]/div[2]/div[2]/div/div/form/div/div[3]/input"; // поле пароля polkpolk1
        private string xPathLogInButn = "/html/body/div/div[2]/div[2]/div[2]/div/div/form/div/input[1]"; // кнопка войти
       


        public AuthorizationPage LogInName()
        {
            driver.FindElement(By.XPath(xPathLogInName)).SendKeys("+ChaganCHik");
            return new AuthorizationPage(driver);
        }
        public AuthorizationPage LogInPasword()
        {
            driver.FindElement(By.XPath(xPathLogInPasword)).SendKeys("polkpolk1");
            return new AuthorizationPage(driver);
        }
        public AuthorizationPage LogInButn()
        {
            driver.FindElement(By.XPath(xPathLogInButn)).Click();
            return new AuthorizationPage(driver);
        }
        
    }
}
