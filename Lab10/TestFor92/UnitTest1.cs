using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TestFor9;

namespace TestFor92
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver("C:/Program Files/Google/Chrome/Application/chrome.exe");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://flibusta.is/");

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void BlogEntry()
        {


            TabLogin Elem1 = new TabLogin(driver); //ввести логин
            Elem1.TabLoginButton();

            TabPassword Elem2 = new TabPassword(driver); //ввести пароль
            Elem2.TabPasswordButton();

            ButInput Elem3 = new ButInput(driver); //нажать на кнопку вход
            Elem3.ButInputButton();

            CreateMaterial Elem4 = new CreateMaterial(driver); //ввести пароль
            Elem4.CreateMaterialButton();

            SectionInBlog Elem5 = new SectionInBlog(driver); //нажать на кнопку вход
            Elem5.SectionInBlogButton();


        }
        //private IWebDriver GetChromeDriver()
        //{
        //    return new ChromeDriver(driverPath, new ChromeOptions());
        //}
        //private IWebDriver driver { get; set; } = null!;
        //private string driverPath { get; set; } = @"C:\Program Files (x86)\Microsoft\Chrome\Application\msedge.exe";

        //[SetUp]
        //public void Setup()
        //{

        //    driver = GetChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl("https://litnet.com/auth/login?classic=1&link=https://litnet.com/");

        //    var AuthorizationPage = new AuthorizationPage(driver);
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
        //    AuthorizationPage.LogInPhone();
        //    AuthorizationPage.LogInPasword();
        //    AuthorizationPage.LogIn();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(70);
        //    var MyPage = new MyPage(driver);
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        //    MyPage.GoToHome();


        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        //}

        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //}

       
    }
}