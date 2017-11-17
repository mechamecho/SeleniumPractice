using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CustomMethodsForControls
{
    class EAPageObject
    {

        public EAPageObject()
        {
            //To initialize the instance of this class(Page) and populate it with the given elements(properties of this class)
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        //To identify the title element
        [FindsBy(How=How.Id, Using ="TitleId")]
        public IWebElement DDLTitleID { get; set; }

        [FindsBy(How=How.Name, Using ="Initial")]
        public IWebElement TxtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement BtnSave { get; set; }
    }
}
