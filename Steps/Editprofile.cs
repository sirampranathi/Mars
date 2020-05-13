using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars
{
    [Binding]
    public class Editprofile
    {
        [Given(@"Click Edit button")]
        public static void GivenClickEditButton()
        {
            Thread.Sleep(15000);
             Driver.TurnOnWait();
            //edit the language
            Driver.Mdriver.FindElement(By.XPath("//td[@class='right aligned']//span[@class='button']//i[@class='outline write icon']")).Click();

        }

        [When(@"Update current record")]
        public static void WhenUpdateCurrentRecord()
        {
            //select language to be edited
            Driver.Mdriver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']")).Clear();
            Driver.Mdriver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']")).SendKeys("French");
            Driver.Mdriver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            Driver.Mdriver.FindElement(By.XPath("//select[@class='ui dropdown']/option[text()='Basic']")).Click();

        }


        [Then(@"Click Update button")]
        public static void ThenClickUpdateButton()
        {
            Driver.Mdriver.FindElement(By.XPath("//input[@value='Update']")).Click();
            Console.WriteLine("Language has been updated");
        }
    }
}
