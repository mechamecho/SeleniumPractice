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
        DataEntry dataentry = new DataEntry();


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

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement TxtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement TxtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement BtnSave { get; set; }

        [FindsBy(How = How.Name, Using = "Male")]
        public IWebElement GenderMaleChoice { get; set; }

        [FindsBy(How = How.Name, Using = "Female")]
        public IWebElement GenderFemaleChoice { get; set; }

        [FindsBy(How = How.Name, Using = "english")]
        public IWebElement EnglishCheckbox { get; set; }

        [FindsBy(How = How.Name, Using = "Hindi")]
        public IWebElement HindiCheckbox { get; set; }

        //To select the title
        public void SelectTitle(string title)
        {
            switch (title.ToLower())
            {
                case ("mr."):
                    DDLTitleID.SelectDropDown("Mr.");
                    break;

                case ("ms."):
                    DDLTitleID.SelectDropDown("Ms.");
                    break;

            }
        }

        //To click the Gender RadioButton
        public void ClickGender(string gender)
        {
            Console.WriteLine(GenderMaleChoice.IsChecked());
            //to Uncheck the male option
            GenderMaleChoice.Clicks();
            Console.WriteLine(GenderMaleChoice.IsChecked());

            switch (gender.ToLower())
            {
                case ("male"):
                    GenderMaleChoice.Clicks();
                    break;

                case ("female"):
                    GenderFemaleChoice.Clicks();
                    break;
            }
        }


        //To click the Languages checkboxes
        public void ClickLanguage(string[] languages)
        {
            foreach (string language in languages)
            {
                switch (language.ToLower())
                {
                    case ("english"):
                        EnglishCheckbox.Clicks();
                        break;

                    case ("hindi"):
                        HindiCheckbox.Clicks();
                        break;
                }
            }


        }

        public void FillUserForm(string title, string initial, string firstName, string middleName, string gender, string [] languages)
        {
            //The extended methods works directly on the IWebElement
            SelectTitle(title);
            TxtInitial.EnterText(initial);
            TxtFirstName.EnterText(firstName);
            TxtMiddleName.EnterText(middleName);
            ClickGender(gender);
            ClickLanguage(languages);

            string TitleText = DDLTitleID.GetTextFromDDL();
            string Initial = TxtInitial.GetText();
            string Firstname = TxtFirstName.GetText();
            string Middlename = TxtMiddleName.GetText();
            string Gender="Male";
            if (GenderMaleChoice.IsChecked())
            {
                Gender=GenderMaleChoice.GetText();
            }
            if (GenderFemaleChoice.IsChecked())
            {
                 Gender = GenderFemaleChoice.GetText();
            }

            if (EnglishCheckbox.IsChecked())
            {
                languages[0] = "English";
            }
            else
            {
                languages[0] = "not chosen";
            }


            if (HindiCheckbox.IsChecked())
            {
                languages[1] = "Hindi";

            }


            dataentry.PopulateUserFormTable(TitleText, Initial, Firstname, Middlename, Gender, languages);

            BtnSave.Clicks();






        }

    }
}
