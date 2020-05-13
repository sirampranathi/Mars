using OpenQA.Selenium;
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
    Driver.Mdriver.FindElement(By.XPath("//select[@class='ui dropdown']/option[text()='Fluent']")).Click();
   }

    [Then(@"Click Add button")]
    public static void ThenClickAddButton()
  {
     //click add 
    Driver.Mdriver.FindElement(By.XPath("//input[@value='Add']")).Click();

        }
    }
}
