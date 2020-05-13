using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Mars.Testsuite
{
    [Binding]

    [Scope(Scenario = "Edit Language deatails")]
   class Edittestsuite
    {
        [Given]
        public static void GivenClickEditButton()
        {
            Editprofile.GivenClickEditButton();
        }
        [When]
        public static void WhenUpdateCurrentRecord()
        {
            Editprofile.WhenUpdateCurrentRecord();
        }
        [Then]
        public static void ThenClickUpdateButton()
        {
            Editprofile.ThenClickUpdateButton();

        }
    }
}
