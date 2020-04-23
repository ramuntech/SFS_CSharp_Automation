using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;

namespace SFS_CSharp_Automation.Base
{
    public class SFSBase
    {
        private static IWebDriver webDriver = null;
        WebDriverWait wait = null;

        public SFSBase(IWebDriver driver)
        {
            webDriver = driver;
        }

        public static IWebDriver driver
        {
            get { return webDriver; }
            set { webDriver = value; }
        }

        public static void launchHomePage()
        {
            string browser = ConfigurationManager.AppSettings["browser"];
            string appUrl = ConfigurationManager.AppSettings["appurl"];

            if (browser.ToUpper().Equals("CHROME"))
            {

            }
        }

        protected IWebElement getElement(By by, string controlName)
        {
            ReportLog.Test.Log(LogStatus.Pass, "Locataing element: " + controlName);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
            IWebElement ele = driver.FindElement(by);
            ReportLog.Test.Log(LogStatus.Pass, controlName + " element located ");
            return ele;
        }

        protected void setText(By by, string controlName, string text)
        {
            IWebElement ele = getElement( by, controlName);
            ReportLog.Test.Log(LogStatus.Pass, " Entering text " + text);
            ele.SendKeys(text);
            ReportLog.Test.Log(LogStatus.Pass, "Text entered as: " + controlName);
        }

        protected void Click(By by, string controlName)
        {
            IWebElement ele = getElement(by, controlName);
            ReportLog.Test.Log(LogStatus.Pass, "Clicking on element " + controlName);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
            ele.Click();
            ReportLog.Test.Log(LogStatus.Pass, "Clicked on element " + controlName);
        }
    }
}
