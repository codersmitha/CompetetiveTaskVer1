//using AventStack.ExtentReports;
//using OpenQA.Selenium.DevTools.V117.Runtime;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace CompetetiveTaskEducationaAnd_CertificationAutomation.Config
//{
     
//    public class ExtentReporting
//    {
//        private static ExtentReports extentReports;
//        private static ExtentTest extentTest;

//        private static ExtentReports StartReporting()
//        {
//            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"..\..\..\..\results\";

//            if(extentReports == null)
//            { 
//                Directory.CreateDirectory(path);

//                extentReports = new ExtentReports();
//                var htmlReporter = new ExtentHtmlReporter(path);

//                //extentReports.AttachReporter(htmlReporter);
//                extentReports.AttachReporter((IObserver<AventStack.ExtentReports.Listener.Entity.ReportEntity>)htmlReporter);
//            }
//            return extentReports;
//        }

//        public static void CreateTest(String testName)
//        {
//            extentTest = StartReporting().CreateTest(testName);
//        }

//        public static void EndReporting()
//        {
//            StartReporting().Flush();
//        }

//        public static void LogInfo(String Info)
//        {
//            extentTest.Info(Info);
//        }

//        public static void LogPass(String Info)
//        {
//            extentTest.Pass(Info);

//        }

//        public static void LogFail(String Info)
//        {
//            extentTest.Fail(Info);
//        }

//        public static void LogScreenShot(String Info,String Image)
//        {
//            extentTest.Info(Info,MediaEntityBuilder.CreateScreenCaptureFromBase64String(Image).Build());
//        }
//    }
//}
