using Mars;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Mars
{
    [Binding]
    class Driver
    {
        public static IWebDriver Mdriver { get; set; }
        [BeforeScenario]
        [OneTimeSetUp]
        public static void Setup()

        {
            Mdriver = new ChromeDriver();
            LoginSteps.Given_I_sign_in_to_the_website();

            LoginSteps.When_I_enter_login_details();

            LoginSteps.Then_I_logged_in();
        }
        //Implicit Wait
        public static void TurnOnWait()
        {
            Mdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }


    }
}
        



