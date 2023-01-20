using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using _10.Driver;
using _10.Pages;
using _10.Service;

namespace _10.Steps
{
    public class Steps
    {

        private IWebDriver driver;

        public Steps(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Autorisation() //войти на сайт
        {
            var AuthorizationPage = new Pages.AuthorizationPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            AuthorizationPage.LogInName();
            AuthorizationPage.LogInPasword();
            AuthorizationPage.LogInButn();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(70);

        }


        public void MyAuthors()//вкладка авторы
        {
            var MyPage = new Pages.MyPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            MyPage.GoToAuthors();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }


        public void TabLetterO() //вкладка буква "О"
        {
            var MyPageO = new Pages.MyPageO(driver);
            MyPageO.GoToO();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }


        public void TabObrain() //вкладка автор Меган О'Брайен
        {
            var MyPageObrain = new Pages.MyPageObrain(driver);
            MyPageObrain.GoToObrain();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }



        public void TabSee() //кнопка отслеживать
        {
            var TabSeePage = new Pages.TabSeePage(driver);
            TabSeePage.GoToSee();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);


        }

    }
}
