using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
            //edit language 
            Driver.Mdriver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']")).Clear();
            Driver.Mdriver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']")).SendKeys("French");
            
            //edit level
            Driver.Mdriver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            IWebElement levelElement = Driver.Mdriver.FindElement(By.XPath("//select[@name='level']"));
            SelectElement levelValue = new SelectElement(levelElement);
            levelValue.SelectByValue("Basic");

        }


        [Then(@"Click Update button")]
        public static void ThenClickUpdateButton()
        {
            Driver.Mdriver.FindElement(By.XPath("//input[@value='Update']")).Click();


            //Validation
            Thread.Sleep(1000);
            String language1 = Driver.Mdriver.FindElement(By.XPath("//table[1]/tbody/tr/td[1]")).Text;
            String actualText = Driver.Mdriver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String expectedText = language1+" has been updated to your languages";
            Assert.AreEqual(expectedText, actualText);
            

        }


    }
}
