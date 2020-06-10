using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.FeaturefileSteps
{
    [Binding]
    public class _2LoginSteps
    {
        [Given(@"User Launch the Webpage")]
        public void GivenUserLaunchTheWebpage()
        {
            //Navigate to the URL
            Driver.driver.Navigate().GoToUrl("http://192.168.99.100:5000");
            //Maximize the window
            Driver.driver.Manage().Window.Maximize();

        }

        [Given(@"Click on Signin Button")]
        public void GivenClickOnSigninButton()
        {

            //click on signin
            Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();
            //Enter user name
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("siram.pranathi@gmail.com");
            //Enter password
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("Chinna76");

        }

        [When(@"Enter valid Login details")]
        public void WhenEnterValidLoginDetails()
        {
        }
        
        [Then(@"Click on Login Button")]
        public void ThenClickOnLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
