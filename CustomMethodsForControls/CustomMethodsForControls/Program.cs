using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CustomMethodsForControls
{
    class Program
    {
        

        static void Main(string[] args)
        {

        }

        [SetUp]
        //opens the browser
        public void Initialize()
        {
            //Create reference for our browser
            PropertiesCollection.Driver = new ChromeDriver();
            //Navigate to Google page
            PropertiesCollection.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&amp;Password=&amp;Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        //Executes the tests 
        public void ExecuteTest()
        {
            //Initialize a page instance
            EAPageObject page = new EAPageObject();

            page.TxtInitial.SendKeys("ExecuteAutomation");
            page.BtnSave.Click();


            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", PropertyType.Id);

            ////Initial
            //SeleniumSetMethods.EnterText("Initial", "Nafissa", PropertyType.Name);
            //Console.WriteLine("The value from my Title is: "+SeleniumGetMethods.GetTextFromDDL( "TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: "+SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            ////Click Save
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
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
            PropertiesCollection.Driver.Close();

            Console.WriteLine("Closed the Browser");
        }
    }
}
