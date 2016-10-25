using SpecFramework.ActionClasses;
using SpecFramework.GlobalParam;
using SpecFramework.TestClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFramework.StepDefinitions
{
    [Binding]
    public sealed class UberTest
    {
        private UbTest ur = new UbTest();

        [Given(@"User is at homepage (.*)")]
        public void GivenUserIsAtHomepage(string url)
        {
            UIActions.GoToUrl(url);
        }
        [When(@"User clicks on Login")]
        public void WhenUserClicksOnLogin()
        {
            Console.WriteLine("In when");
            UIActions.Click(ur.signin);
        }

        [Then(@"User is navigate to Login Page")]
        public void ThenUserIsNavigateToLoginPage()
        {
            Console.WriteLine("In Then");
        }

        [When(@"User clicks on rider signin")]
        public void WhenUserClicksOnRiderSignin()
        {
            UIActions.Click(ur.rider_signin);
        }

        [Then(@"User is at ridersignin page")]
        public void ThenUserIsAtRidersigninPage()
        {
            Console.WriteLine("In rider then");
        }

        [Given(@"User being at login page (.*)")]
        public void GivenUserBeingAtLoginPage(string url)
        {
            UIActions.GoToUrl(url);
        }





    }
}
