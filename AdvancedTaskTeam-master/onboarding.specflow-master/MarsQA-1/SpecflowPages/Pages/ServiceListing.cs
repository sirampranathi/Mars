using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ServiceListing
    {

        private static IWebElement Title => Driver.driver.FindElement(By.XPath("//input[@name ='title'][@type='text']"));

        private static IWebElement Description => Driver.driver.FindElement(By.XPath("//textarea[@name ='description']"));

        private static IWebElement Category => Driver.driver.FindElement(By.XPath("//select[@name ='categoryId']"));

        private static IWebElement SubCategory => Driver.driver.FindElement(By.XPath("//select[@name ='subcategoryId']"));

        private static IWebElement Tags => Driver.driver.FindElement(By.XPath("(//input[@aria-label='Add new tag'])[1]"));


        private static IWebElement HourlyBasisServiceType => Driver.driver.FindElement(By.XPath("(//input[@name='serviceType'])[1]"));

        private static IWebElement OneOffServiceType => Driver.driver.FindElement(By.XPath("(//input[@name='serviceType'])[2]"));

        private static IWebElement onSiteLocationType => Driver.driver.FindElement(By.XPath("(//input[@name='locationType'])[1]"));

        private static IWebElement onlineLocationType => Driver.driver.FindElement(By.XPath("(//input[@name='locationType'])[2]"));
        private static IWebElement startDate => Driver.driver.FindElement(By.XPath("//input[@name='startDate']"));

        private static IWebElement endDate => Driver.driver.FindElement(By.XPath("//input[@name='endDate']"));

        private static IWebElement MondayCheckbox => Driver.driver.FindElement(By.XPath("//*[@index='1'][@type='checkbox']"));



        private static IWebElement MondayStartTime => Driver.driver.FindElement(By.XPath("//*[@index='1'][@name='StartTime']"));
        private static IWebElement MondayendTime => Driver.driver.FindElement(By.XPath("//*[@index='1'][@name='EndTime']"));

        private static IWebElement SkillExchangeradiobutton => Driver.driver.FindElement(By.XPath("(//input[@name='skillTrades'])[1]"));



        private static IWebElement Creditradiobutton => Driver.driver.FindElement(By.XPath("(//input[@name='skillTrades'])[2]"));

        private static IWebElement ActiveRadiobutton => Driver.driver.FindElement(By.XPath("(//input[@name='isActive'])[1]"));

        private static IWebElement HiddenRadiobutton => Driver.driver.FindElement(By.XPath("(//input[@name='isActive'])[2]"));

        private static IWebElement SkillTags => Driver.driver.FindElement(By.XPath("(//input[@aria-label='Add new tag'])[2]"));


        private static IWebElement Savebutton => Driver.driver.FindElement(By.XPath("//input[@value='Save']"));

        public static void SaveServiceListing()
        {

            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ServiceListData.xlsx", "Service Data");
            Driver.TurnOnWait();

            //Enter Title

            Title.SendKeys(ExcelLibHelper.ReadData(2, "Title"));

            //Enter Description

            Description.SendKeys(ExcelLibHelper.ReadData(2, "Description"));

            //Select Category
            SelectElement catg = new SelectElement(Category);
            Driver.TurnOnWait();
            catg.SelectByText(ExcelLibHelper.ReadData(2, "Category"));

            //Select Subcategory

            SelectElement subcatg = new SelectElement(SubCategory);
            Driver.TurnOnWait();
            subcatg.SelectByText(ExcelLibHelper.ReadData(2, "Sub Category"));

            //Tags 
            Driver.TurnOnWait();
            Tags.Click();
            Driver.TurnOnWait();
            Tags.SendKeys(ExcelLibHelper.ReadData(2, "Tags") + "\n");

            //Select Service Type from radio buttons

            OneOffServiceType.Click();


            //Select Location Type radio button

            onlineLocationType.Click();

            //Select Available days and Time
            //select startdate
            startDate.Click();
            Driver.TurnOnWait();
            startDate.SendKeys(ExcelLibHelper.ReadData(2, "StartDate"));

            //Select end date
            endDate.Click();
            Driver.TurnOnWait();
            endDate.SendKeys(ExcelLibHelper.ReadData(2, "EndDate"));

            //Select Monday
            MondayCheckbox.Click();

            //Select start time for Monday
            MondayStartTime.Click();
            Driver.TurnOnWait();
            MondayStartTime.SendKeys(ExcelLibHelper.ReadData(2, "MondayStartTime"));
            Driver.TurnOnWait();

            //Select end time for Monday
            MondayendTime.Click();
            Driver.TurnOnWait();
            MondayendTime.SendKeys(ExcelLibHelper.ReadData(2, "MondayendTime"));
            Driver.TurnOnWait();

            //Select Skill Trade radio button



            SkillExchangeradiobutton.Click();
            Driver.TurnOnWait();

            SkillTags.SendKeys(ExcelLibHelper.ReadData(2, "SkillExchangeTags") + "\n");

            //Select Active radio button

            ActiveRadiobutton.Click();

            //Save the data
            Driver.TurnOnWait();
            Thread.Sleep(3000);

            Savebutton.Click();
            Thread.Sleep(3000);

            Driver.TurnOnWait();
        }


    }
}
