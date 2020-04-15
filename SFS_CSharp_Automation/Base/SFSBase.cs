using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace SFS_CSharp_Automation.Base
{
    public class SFSBase
    {
        private static IWebDriver webDriver = null;

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
    }
}
