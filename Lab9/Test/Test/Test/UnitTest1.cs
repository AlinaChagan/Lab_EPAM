using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace Test
{

    public class Tests
    {
        [Test]
        public void SearchForHotels()
        {
            WebDriver driver = new ChromeDriver("C:\\Webdriver\\chromedriver_win32\\chromedriver.exe");
            driver.Url = "http://flibusta.is";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/div/div/form/div/div[2]/input")).SendKeys("ChaganCHik");
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/div/div/form/div/div[3]/input")).SendKeys("polkpolk1");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);

            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/div/div/form/div/input[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);

            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[3]/div/div/ul/li[1]/ul/li[2]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);

            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/ul[10]/li[12]/a[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);

            //driver.Quit(); - закрытие браузера 
        }
    }
}