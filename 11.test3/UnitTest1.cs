using Docker.DotNet.Models;
using java.sql;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using _10.Steps;

namespace _10
{
    public class Tests
    {
        private IWebDriver GetEdgeDriver()
        {
            return new EdgeDriver(driverPath, new EdgeOptions());
        }
        private IWebDriver driver { get; set; } = null!;
        private string driverPath { get; set; } = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

        [SetUp]
        public void Setup()
        {

            driver = GetEdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://flibusta.is/");
            var steps = new Steps.Steps(driver);
            steps.Autorisation();
            
    }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        //test7
        [Test]
        public void ViewingBooksOfCertainGenreOfSelectedSubgenre()
        {
            var steps = new Steps.Steps(driver);
            steps.MyAuthors();
            steps.TabPopularBooks();
        }
       

    }
}