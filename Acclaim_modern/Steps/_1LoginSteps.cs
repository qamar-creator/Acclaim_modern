using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
  
namespace Acclaim_modern
{
    [Binding]
    public class Login
    {
        [Given(@"go to this url ""(.*)""")]
        public static void GivenGoToThisUrl(string url)
        {
            SETUP setup = new SETUP();
            setup.TestMethodLogin(url);

        }

        [Given(@"enter username and password")]
        public void GivenEnterUsernameAndPassword()
        {
        }

        [Given(@"I enter as below")]
        public static void GivenIEnterAsBelow(Table credentials)
        {
            dynamic Credentials = credentials.CreateDynamicInstance();
            string username = Credentials.username;
            string password = Credentials.password;
            CustomControls.Entertext("#txtLoginId", username, propertytype.CssSelector);
            CustomControls.Entertext("#txtPassword", password, propertytype.CssSelector);

        }



        [Given(@"the user should stay on the same login screen\.")]
        public static void GivenTheUserShouldStayOnTheSameLoginScreen_()
        {
            CustomControls.click("#btnLogin", propertytype.CssSelector);
            delayfor.delay();
        }

        [Given(@"the user should land on page titles ""(.*)""")]
        public void GivenTheUserShouldLandOnPageTitles(string dashboard)
        {
            CustomControls.click("#btnLogin", propertytype.CssSelector);
            delayfor.delay();

            Globalelements.Expectedresult = dashboard;
            Globalelements.Actualresult = CustomControlGets.GettextfromLabel("div[class='col-lg-7'] h2", propertytype.CssSelector);
            Console.WriteLine("The landed page lands on " + Globalelements.Actualresult);
            Assertions.assertionequals(Globalelements.Actualresult, Globalelements.Expectedresult);
        }

    }
}