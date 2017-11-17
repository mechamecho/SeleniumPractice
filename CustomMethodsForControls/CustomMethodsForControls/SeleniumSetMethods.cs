using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CustomMethodsForControls
{
    class SeleniumSetMethods
    {
        

        //for libraries it is always a wise idea, to set them as static methods
        //EnterText
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if(elementtype ==PropertyType.Id)
                PropertiesCollection.Driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesCollection.Driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click into a button, Checkbox, option, etc.
        public static void Click( string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.Driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropertiesCollection.Driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(string element, string value, PropertyType elementtype )
        {
            
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
