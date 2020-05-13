using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Mars
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I sign in to the website")]
        public static void Given_I_sign_in_to_the_website()
        {
            //Enter Url
            Driver.Mdriver.Navigate().GoToUrl("http://192.168.99.100:5000");
            //Maximize the window
            Driver.Mdriver.Manage().Window.Maximize();
        }

        [When(@"I enter login details")]
        public static void When_I_enter_login_details()
        {
            //click on signin
            Driver.Mdriver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();

            //Enter user name
            Driver.Mdriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("siram.pranathi@gmail.com");
            //Enter password
            Driver.Mdriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("Chinna76");
        }

        [Then(@"I logged in")]
        public static void Then_I_logged_in()
        {
            //click on login
            Driver.Mdriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();

        }
    }
}


