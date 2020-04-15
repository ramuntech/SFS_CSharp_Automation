using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SFS_CSharp_Automation.Base
{
    public class Hooks
    {
        [BeforeTestRun]
        public static void beforeTestRun()
        {
            Console.WriteLine("BeforeTestRun");
        }

        [AfterTestRun]
        public static void afterTestRun()
        {
            Console.WriteLine("AfterTestRun");
        }

        [BeforeScenario]
        public static void beforeScenario()
        {
            SFSBase.launchHomePage();
        }

        [AfterScenario]
        public static void afterScenario()
        {
           if (SFSBase.driver != null)
            {
                SFSBase.driver.Close();
                SFSBase.driver.Quit();
                SFSBase.driver.Dispose();
            }
        }
    }
}
