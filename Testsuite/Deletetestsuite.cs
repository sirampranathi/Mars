using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Mars.Testsuite
{
    [Binding]
    [Scope(Scenario = "Delete Language deatails")]

    class Deletetestsuite
    {
        [Given]
        public static void GivenClickOnDeleteButton()
        {
            Deleteprofile.GivenClickOnDeleteButton();
        }
        [Then]
        public static void ThenPopUpDisplayed()
        {
            Deleteprofile.ThenPopUpDisplayed();
        }
    }
    
}
