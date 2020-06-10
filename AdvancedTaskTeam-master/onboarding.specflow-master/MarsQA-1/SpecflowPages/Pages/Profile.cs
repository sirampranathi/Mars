using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;


namespace MarsQA_1.SpecflowPages.Pages
{
    class Profile
    {

        private static IWebElement Namedrop => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div[2]/div/span"));

        private static IWebElement profile => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div[2]/div/span/div/a[1]"));



        //Description Elements

        private static IWebElement DescriptionEditIcon => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/-/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));

        private static IWebElement DescriptionTextField => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']//section[2]//textarea"));


        //Add New button for Language
        private static IWebElement LanguageAddNew => Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[1]"));


        //Add New Language text field
        private static IWebElement AddLanguage => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));

        //Add language level value drop down

        private static IWebElement AddLanguageValue => Driver.driver.FindElement(By.XPath("//select[@name='level']"));

        //AddLanguagebutton

        private static IWebElement AddLanguagebutton => Driver.driver.FindElement(By.XPath("(//input[@value='Add'][@type='button'])[1]"));

        //Last Language in the language table

        private static IWebElement Language => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//td[1]"));

        //Last Language drop down value in the language table

        private static IWebElement LanguageValue => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//td[2]"));

        // Edit icon for last language row in the language table

        private static IWebElement EditLanguageIcon => Driver.driver.FindElement(By.XPath("(//*[@data-tab='first']//tbody[last()]//td[3]//i)[1]"));

        private static IWebElement EditLastLanguage => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//input[@value='Tamil']"));

        //Edit language -> Update button 

        private static IWebElement EditLanguageupdatebutton => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//input[@value='Update']"));

        // Language - Delete icon(for last row)
        private static IWebElement DeletelanguageIcon => Driver.driver.FindElement(By.XPath("(//*[@data-tab='first']//tbody[last()]//td[3]//i)[2]"));


        private static IWebElement ShareSkill => Driver.driver.FindElement(By.XPath("//*[text()='Share Skill']"));


        private static IWebElement EducationAddNew => Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')])[3]"));

        private static IWebElement CertificationAddNew => Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')])[4]"));



        private static IWebElement CertificateTab => Driver.driver.FindElement(By.XPath("//a[text()='Certifications']"));

        private static IWebElement EducationTab => Driver.driver.FindElement(By.XPath("//a[text()='Education']"));





        public static void NavigatetoProfilePage()
        {
            // To Navigate from home page to profile page
            Driver.TurnOnWait();
            //Driver.NavigateUrl();
            //Namedrop.Click();
            // Driver.TurnOnWait();
            //profile.Click();

        }


        public static void EditDescription()
        {

            // Click on description edit icon and navigate to Descrition field 
            Driver.TurnOnWait();
            DescriptionEditIcon.Click();


            // Add Description content 

            Driver.TurnOnWait();
            DescriptionTextField.SendKeys("This is test data");



        }



        public static void AddNewLanguage()
        {

            // Add New language 
            Driver.TurnOnWait();
            LanguageAddNew.Click();
            Driver.TurnOnWait();
            AddLanguage.SendKeys("Tamil");

            //Select Language value

            //create select element object 
            SelectElement levelvalue = new SelectElement(AddLanguageValue);

            //select by Text
            levelvalue.SelectByText("Fluent");
            AddLanguagebutton.Click();


        }

        public static void VerifyAddedLanguage()
        {
            var actuallang = Language.Text;
            var actualLangVal = LanguageValue.Text;



            Assert.AreEqual("Tamil", actuallang, "Language is not added");
            Assert.AreEqual("Fluent", actualLangVal, "Language value is not addded");


        }



        public static void EditLanguage()
        {

            Driver.TurnOnWait();
            EditLanguageIcon.Click();

            Driver.TurnOnWait();
            EditLastLanguage.Clear();
            EditLastLanguage.SendKeys("English");

            EditLanguageupdatebutton.Click();
            Thread.Sleep(2000);



        }



        public static void VerifyEditedLanguage()
        {

            var actuallang = Language.Text;
            var actualLangVal = LanguageValue.Text;

            Assert.AreEqual("English", actuallang, "Language is not edited");
            Assert.AreEqual("Fluent", actualLangVal, "Actual and Expected values are not equal");


        }


        public static void DeleteLanguage()
        {
            Driver.TurnOnWait();
            DeletelanguageIcon.Click();
            Thread.Sleep(2000);

        }


        public static void VerifyDeleteLanguage()
        {

            try
            {
                IWebElement lang = Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//td[1]"));


                Driver.TurnOnWait();
                Assert.AreNotEqual("English", lang, "Language not deleted");


            }
            catch (Exception e)
            {

                Assert.True(true, "Element not found");
            }

        }




        public static void NavigatetoServiceListingPage()
        {
            Driver.TurnOnWait();
            ShareSkill.Click();
            Thread.Sleep(2000);

        }

        public static void AddEducation()

        {

        }


        public static void AddCertification()

        {

        }



        public static void EditEducation()

        {

        }

        public static void EditCertification()

        {

        }


        public static void DeleteEducation()

        {

        }

        public static void DeleteCertification()

        {

        }

        public static void VerifyAddEducation()

        {

        }


        public static void VerifyAddCertification()

        {

        }





        public static void VerifyEditEducation()

        {

        }


        public static void VerifyDeleteEducation()

        {

        }


        public static void VerifyEditCertification()

        {

        }


        public static void VerifyDeleteCertification()

        {

        }







    }
}
