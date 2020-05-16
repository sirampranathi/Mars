using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars
{
    [Binding]
    public class Addprofile
 {  
    [Given(@"Select Language Tab")]
    public static void GivenSelectLanguageTab()
  {
    Thread.Sleep(10000);
    Driver.TurnOnWait();
          
     //select language
     Driver.Mdriver.FindElement(By.XPath("//a[@class='item active' and @data-tab='first']")).Click();

  }

    [Given(@"Click on Addnew")]
    public static void GivenClickOnAddnew()
  {
    //select addnew button to enter language
     Driver.Mdriver.FindElement(By.XPath("//*[@class='ui teal button '] ")).Click();
   }

    [When(@"Enter new Language and Level")]
    public static void WhenEnterNewLanguageAndLevel()
  {
    //Add new language
    Driver.Mdriver.FindElement(By.XPath("//input[@name='name']")).SendKeys("English");
            
    //Add level
            Driver.Mdriver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            IWebElement levelElement = Driver.Mdriver.FindElement(By.XPath("//select[@name='level']"));
            SelectElement levelValue = new SelectElement(levelElement);
            levelValue.SelectByValue("Basic");

        }

        [Then(@"Click Add button")]
    public static void ThenClickAddButton()
  {
     //click add 
            Driver.Mdriver.FindElement(By.XPath("//input[@value='Add']")).Click();
            Thread.Sleep(1000);
    //Validation
            String language1 = Driver.Mdriver.FindElement(By.XPath("//table[1]/tbody/tr/td[1]")).Text;
            String actualText = Driver.Mdriver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String expectedText = language1 + " has been added to your languages";
            Assert.AreEqual(expectedText, actualText);
        }
    }
}