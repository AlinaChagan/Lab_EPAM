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



        public void MySiteGlavnai()//вкладка главная
        {
            var MyPage = new Pages.MyPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            MyPage.GoToHome();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }


        public void TabBooks() //вкладка книги
        {
            var MyPageBooks = new Pages.MyPageBooks(driver);
            MyPageBooks.GoToBooks();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }

        public void TabAll() //вкладка все
        {
            var MyPageAll = new Pages.MyPageAll(driver);
            MyPageAll.GoToAll();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }


        public void TabAkrill() //вкладка Akrill
        {
            var MyPageAll = new Pages.MyPageAll(driver);
            MyPageAll.GoToAkrill();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);


        }
        public void TabFirstLady()//вкладка первая леди
        {
            var FirstLadyPage = new Pages.FirstLadyPage(driver);
            FirstLadyPage.GoToFirstLady();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            
        }       




        public void TabMail()//нажать на mail
        {
           var TabMailPage = new Pages.TabMailPage(driver);
            TabMailPage.GoToMail();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);


        }


        public void TabUpLoad()//ввести почту и выбрать формат
        {
            var TabSkachatPage = new Pages.TabSkachatPage(driver);
            TabSkachatPage.TabUpLoad();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);


        }
        //public void AuthorName() //нажать отправить
        //{
        //   var MyLaibraryPage = new Pages.MyLaibraryPage(driver);
        //    MyLaibraryPage.ChooseAuthor();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);

        //}
        //public void Sibscribe()
        //{
        //   var AuthorPage = new Pages.AuthorPage(driver);
        //    AuthorPage.TrackAuthor();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);

        //}
    }
}
