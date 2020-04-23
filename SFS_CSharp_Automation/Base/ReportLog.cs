using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;

namespace SFS_CSharp_Automation.Base
{
    public class ReportLog
    {
        private static ExtentReports report;
        private static ExtentTest test;

       
        public static ExtentReports Report {
            get { return report; }
            set { report = value; }
        }

        public static ExtentTest Test
        {
            get { return test; }
            set { test = value; }
        }
    }
}
