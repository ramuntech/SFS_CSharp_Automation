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
    public class LoginPage
    {
        //By objects
        By byLoginTitle = By.XPath("");

        //locator
        private IWebElement getLoginTitle()
        {
            return SFSBase.driver.FindElement(byLoginTitle);
        }

        //actions and methods
        public static void verifyLoginPage()
        {
          
        }
    }
}
