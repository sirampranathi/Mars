using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

using NUnit.Framework.Interfaces;
using AventStack.ExtentReports.Model;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        public static Boolean signin = true;



       
        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
           

            if(signin)
            {
                SignIn.SigninStep();
            }
            else
            {
                Signup.register();
                
            }

          


        }

        [AfterScenario]
        public void TearDown()
        {

            
            driver.Quit();


        }


       
    }
}
