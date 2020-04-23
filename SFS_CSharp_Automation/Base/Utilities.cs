using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS_CSharp_Automation.Base
{
    public class Utilities
    {
        WebDriverWait wait = null;

        protected IWebElement getElement(IWebDriver driver, By by, string controlName)
        {
            ReportLog.Test.Log(LogStatus.Pass, "Locataing element: " + controlName);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
            IWebElement ele = driver.FindElement(by);
            ReportLog.Test.Log(LogStatus.Pass, controlName + " element located ");
            return ele;
        }

        protected void setText(IWebDriver driver, By by, string controlName, string text)
        {
            IWebElement ele = getElement(driver, by, controlName);
            ReportLog.Test.Log(LogStatus.Pass," Entering text " + text);
            ele.SendKeys(text);
            ReportLog.Test.Log(LogStatus.Pass, "Text entered as: " + controlName);
        }

        protected void Click(IWebDriver driver, By by, string controlName)
        {
            IWebElement ele = getElement(driver, by, controlName);
            ReportLog.Test.Log(LogStatus.Pass, "Clicking on element " + controlName);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
            ele.Click();
            ReportLog.Test.Log(LogStatus.Pass, "Clicked on element " + controlName);
        }

    }
}
