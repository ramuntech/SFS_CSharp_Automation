using NUnit.Framework;
using OpenQA.Selenium;
using SFS_CSharp_Automation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SFS_CSharp_Automation.Pages
{
    public class LoginPage : SFS_CSharp_Automation.Base.SFSBase
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        //By objects
        By byLoginTitle = By.XPath("");
        By byUserID = By.XPath("");
        By byPassword = By.XPath("");
        By byLoginButton = By.XPath("");

        //locator
        private IWebElement getLoginTitle()
        {
            return SFSBase.driver.FindElement(byLoginTitle);
        }

        //actions and methods
        public void verifyLoginPage(string title)
        {
            Assert.AreEqual(title, getElement(byLoginTitle, title));
        }

        public void performUserLogin(string userID, string password)
        {
            setText(byUserID, "User ID textbox", userID);
            setText(byPassword, "Password textbox", password);
            Click(byLoginButton, "Login button");

        }
    }
}
