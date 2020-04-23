using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using RelevantCodes.ExtentReports;
using System.IO;

namespace SFS_CSharp_Automation.Base
{
    public class Hooks
    {

        [BeforeTestRun]
        public static void beforeTestRun()
        {
            string reportsPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            ReportLog.Report = new ExtentReports(reportsPath + "//Reports//SFS_Report_"+DateTime.Now.ToString("ddMMyyhhmmsss")+".html");
           
        }
        
        [AfterTestRun]
        public static void afterTestRun()
        {
            ReportLog.Report.Close();
            ReportLog.Report.Flush();
        }

        [BeforeScenario]
        public static void beforeScenario()
        {
            String scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            ReportLog.Test = ReportLog.Report.StartTest(scenarioTitle);
            ReportLog.Test.Log(LogStatus.Pass, "Scenario startd");
            SFSBase.launchHomePage();
        }

        [AfterScenario]
        public static void afterScenario()
        {

            ReportLog.Test.Log(LogStatus.Pass, "Quitting drivers");
            if (SFSBase.driver != null)
            {
                SFSBase.driver.Close();
                SFSBase.driver.Quit();  
            }

            ReportLog.Test.Log(LogStatus.Pass, "closing test");
            ReportLog.Report.EndTest(ReportLog.Test);
        }
    }
}
