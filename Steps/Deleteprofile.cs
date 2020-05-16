using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars
{
    [Binding]
    public class Deleteprofile
    {
        [Given(@"Click on Delete button")]
        public static void GivenClickOnDeleteButton()
        {
            Driver.TurnOnWait();
            Thread.Sleep(10000);

            //select language
            Driver.Mdriver.FindElement(By.XPath("//*[@class='remove icon']")).Click();

        }

        [Then(@"Pop up displayed")]
        public static void ThenPopUpDisplayed()
        {
          
            //Validation
            String language1 = Driver.Mdriver.FindElement(By.XPath("//table[1]/tbody/tr/td[1]")).Text;
            String actualText = Driver.Mdriver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String expectedText = language1 + " has been deleted from your languages";
            Assert.AreEqual(expectedText, actualText);
        }
    }
}
