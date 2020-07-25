using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

[assembly: Parallelize(Workers = 2, Scope =ExecutionScope.ClassLevel)]
namespace Selenium_MSTest
{

    [TestClass]
    public class Tests1
    {
        [TestMethod]
        public void Test1a()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.utep.edu/");
            Console.WriteLine("1a");
            driver.Quit();
            //Assert.Pass();
        }
        [TestMethod]
        public void Test1b()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.utep.edu/");
            Console.WriteLine("1b");
            driver.Quit();
            //Assert.Pass();
        }
    }
    [TestClass]
    public class Tests2
    {

        [TestMethod]
        public void Test2a()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://betamy.utep.edu/My");
            Console.WriteLine("2a");
            driver.Quit();
            //Assert.Pass();
        }
        [TestMethod]
        public void Test2b()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://betamy.utep.edu/My");
            Console.WriteLine("2b");
            driver.Quit();
            //Assert.Pass();
        }
    }
}
