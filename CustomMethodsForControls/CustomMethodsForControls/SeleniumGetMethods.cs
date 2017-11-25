using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CustomMethodsForControls
{
    public static class SeleniumGetMethods
    {
        public static bool IsChecked(this IWebElement element)
        {
            if (!String.IsNullOrEmpty(element.GetAttribute("value"))){
                return true;
            }

            return false;
        }

        public  static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(this IWebElement element)
        {
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text; 
        }
    }
}
