//���������� ���� �� 9 ������������ � ������� Page Object
//�������� ���� ���� � ������ ������
//1) ����� �� ���� http://flibusta.is/;
//2) ����� �� ������� �����;
//3) ������� ���� ��������;
//4) ������ �� ����� �������� ���� �������� � ������ ������


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
            TabLogin Elem1 = new TabLogin(driver); //������ �����
            Elem1.TabLoginButton();

            TabPassword Elem2 = new TabPassword(driver); //������ ������
            Elem2.TabPasswordButton();

            ButInput Elem3 = new ButInput(driver); //������ �� ������ ����
            Elem3.ButInputButton();

            TabGenres Elem4 = new TabGenres(driver); //������� �����
            Elem4.TabGenresButton();

            Genres Elem5 = new Genres(driver); //������� ���� ��������
            Elem5.GenresButton();

            BlackList Elem6 = new BlackList(driver); //�������� � ��
            Elem6.BlackListButton();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
    }
}