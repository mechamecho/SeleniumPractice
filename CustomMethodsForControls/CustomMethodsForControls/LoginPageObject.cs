using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CustomMethodsForControls
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How=How.Name, Using ="UserName")]
        public IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement TxtPassWord { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement BtnLogin { get; set; }

        public EAPageObject Login(string UserName, string Password)
        {
            //UserName
            //Extended Methods
            TxtUserName.EnterText(UserName);

            //Password
            TxtPassWord.EnterText(Password);

            //Click button
            BtnLogin.Submit();

            //To Navotagte to the HomePage, returns an instance of it
            return new EAPageObject();
            
        }
    }
}
