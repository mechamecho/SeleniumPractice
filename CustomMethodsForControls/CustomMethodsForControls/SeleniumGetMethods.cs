using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CustomMethodsForControls
{
    class SeleniumGetMethods
    {
        public  static string GetText(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id) 
                return PropertiesCollection.Driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == PropertyType.Name)
                return PropertiesCollection.Driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return String.Empty;
        }

        public static string GetTextFromDDL(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;

            else
                return String.Empty;
        }
    }
}
