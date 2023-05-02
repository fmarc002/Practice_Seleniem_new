using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MyNewProjectToPractice
{
    public class BaseTests
    {
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver is null)
                {
                    Inicialize();
                }
                return driver;
            }
        }

        [SetUp]
        public static void Inicialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }

        [TearDown]
        public static void EndTest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}