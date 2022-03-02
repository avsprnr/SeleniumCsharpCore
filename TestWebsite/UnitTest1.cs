using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestWebsite
{
    public class Tests:DriverHelper
    {
        
        [SetUp] 
        public void Setup()
        {
            Driver = new ChromeDriver();

            Console.WriteLine("Setup");


        }

        [Test]
        public void Test1()
        {
            
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(10);
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");


            Assert.Pass();
        }
    }
}