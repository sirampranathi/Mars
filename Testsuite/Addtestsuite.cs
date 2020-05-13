using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Mars.Testsuite
{
    [Binding]
    
    [Scope(Scenario= "Add Language deatails")]
    class Addtestsuite : Driver
    {
    [Given]
    public void GivenSelectLanguageTab()
        {
            Addprofile.GivenSelectLanguageTab();

        }
        [Given]
    public void GivenClickOnAddnew()
        {
            Addprofile.GivenClickOnAddnew();
        }
        [When]
    public  void WhenEnterNewLanguageAndLevel()
        {
            Addprofile.WhenEnterNewLanguageAndLevel();

        }
        [Then]
        public static void ThenClickAddButton()
        {
            Addprofile.ThenClickAddButton();
        }


    }
}
