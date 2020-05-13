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
            Console.WriteLine(" Language has been deleted");
        }
    }
}
