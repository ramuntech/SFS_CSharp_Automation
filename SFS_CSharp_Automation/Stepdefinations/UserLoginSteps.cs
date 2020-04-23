using System;
using TechTalk.SpecFlow;
using SFS_CSharp_Automation.Pages;

namespace SFS_CSharp_Automation.Stepdefinations
{
    [Binding]
    public class UserLoginSteps
    {
        LoginPage loginPage = null;

        [Given(@"I am in login page")]
        public void GivenIAmInLoginPage()
        {
            loginPage = new LoginPage(Base.SFSBase.driver);
            loginPage.verifyLoginPage("Login");
        }

        [When(@"I performLogin with '(.*)' and '(.*)'")]
        public void WhenIPerformLoginWithAnd(string userID, string Password)
        {
            loginPage.performUserLogin(userID, Password);
        }

    }
}
