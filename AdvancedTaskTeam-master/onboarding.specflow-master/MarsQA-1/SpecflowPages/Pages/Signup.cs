using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using MarsQA_1.Utils;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Signup
    {
        private static IWebElement Joinbutton=> Driver.driver.FindElement(By.XPath("//button[text()='Join']"));

        private static IWebElement FirstName => Driver.driver.FindElement(By.Name("firstName"));

        private static IWebElement LastName => Driver.driver.FindElement(By.Name("lastName"));


        private static IWebElement Emailaddress => Driver.driver.FindElement(By.Name("email"));


        private static IWebElement password => Driver.driver.FindElement(By.Name("password"));

        private static IWebElement confirmPassword => Driver.driver.FindElement(By.Name("confirmPassword"));

        private static IWebElement Checkbox => Driver.driver.FindElement(By.XPath("//input[@name='terms']"));

        private static IWebElement Submit => Driver.driver.FindElement(By.XPath("//div[@id='submit-btn']"));



        public static void register()
        {


            Driver.NavigateUrl();
            Joinbutton.Click();
            Driver.TurnOnWait();
            FirstName.SendKeys("FirstNameTest");

            Driver.TurnOnWait();
            LastName.SendKeys("LastNameTest");

            Driver.TurnOnWait();
            Emailaddress.SendKeys("test@t.com");

            Driver.TurnOnWait();
            password.SendKeys("Test@123");


            Driver.TurnOnWait();
            confirmPassword.SendKeys("Test@123");

            Driver.TurnOnWait();
            Checkbox.Click();


            Driver.TurnOnWait();
            Submit.Click();

            Driver.TurnOnWait();

        }


        public static void verifyregister()
        {

        }



        




    }
}
