using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        //Create reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {

        }

        [SetUp]
        //opens the browser
        public void initialize()
        {
            //Navigate to Google page
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened URL");
        }

        [Test]
        //Executes the tests 
        public void ExecuteTest()
        {
            //Find the element
            IWebElement element = driver.FindElement(By.Name("q"));


            //Perform Ops
            element.SendKeys("executeautomation");

            Console.WriteLine("Executed Test");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }

        [TearDown]
        //Closes the browser/driver
        public void CleanUp()
        {
            //To close the browser after typing the value
            driver.Close();

            Console.WriteLine("Closed the Browser");
        }
    }
}
