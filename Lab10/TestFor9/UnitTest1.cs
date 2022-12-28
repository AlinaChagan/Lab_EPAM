//переделать тест из 9 лабораторной с помощью Page Object
//Добавить один жанр в черный список
//1) Зайти на сайт http://flibusta.is/;
//2) Зайти на вкладку жанры;
//3) Выбрать жанр Зоология;
//4) Нажать на пункт Добавить жанр Зоология в черный список


//using TestFor9;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
namespace TestFor9
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
        public void KatologaConversionButtonTest()
        {
            TabLogin Elem1 = new TabLogin(driver); //ввести логин
            Elem1.TabLoginButton();

            TabPassword Elem2 = new TabPassword(driver); //ввести пароль
            Elem2.TabPasswordButton();

            ButInput Elem3 = new ButInput(driver); //нажать на кнопку вход
            Elem3.ButInputButton();

            TabGenres Elem4 = new TabGenres(driver); //вкладка жанры
            Elem4.TabGenresButton();

            Genres Elem5 = new Genres(driver); //выбрать жанр Зоология
            Elem5.GenresButton();

            BlackList Elem6 = new BlackList(driver); //добавить в чс
            Elem6.BlackListButton();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
    }
}