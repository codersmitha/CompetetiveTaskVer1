using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CompetetiveTaskEducationaAnd_CertificationAutomation.Config;
using CompetetiveTaskEducationaAndCertificationAutomation.DataModel;
using CompetetiveTaskEducationaAndCertificationAutomation.Pages;
using CompetetiveTaskEducationaAndCertificationAutomation.Utilities;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CompetetiveTaskEducationaAndCertificationAutomation.Test
{
    public class EducationTest : CommonDriver
    {   
        
            //ExtentReports.CreateTest(TestContext.CurrentContext.Test.MethodName);
        HomePage homePageObj = new HomePage();
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();
        EducationPage educationPageObj = new EducationPage();

        [SetUp]
        public void SetUpEducationTest()
        {
            ExtentReporting.CreateTest(TestContext.CurrentContext.Test.MethodName);
            Initialize();
            homePageObj.SignInActions();
            loginPageObj.LoginActions();
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            profilePageObj.ClickEducationTab();

        }


        [Test, Order(1), Description("Adding new education record")]

        public void TestAddnewEducation()
        {

            ReadJsonData readJsonDataobj = new ReadJsonData("C://CompetetiveTaskVer1//CompetetiveTaskVer1//CompetetiveTaskEducationaAndCertificationAutomation//TestData//UserData.json");
            List<EducationDataModel> educations = new List<EducationDataModel>();
            educations = readJsonDataobj.EducationObjectWithNewtonsoftJson();

            for (int i = 0; i < 3; i++)
            {
                string university = educations[i].UniversityName;
                string country = educations[i].CountryName;
                string title = educations[i].Title;
                string degree = educations[i].DegreeName;
                string graduationYear = educations[i].YearOfGraduation;

                educationPageObj.AddNewEducation(university, country, title, degree, graduationYear);
            }
        }


        [Test, Order(2), Description("Adding a duplicate education record")]

        public void TestAddDuplicateEducation()
        {

            ReadJsonData readJsonDataobj = new ReadJsonData("C://CompetetiveTaskVer1//CompetetiveTaskVer1//CompetetiveTaskEducationaAndCertificationAutomation//TestData//UserData.json");
            List<EducationDataModel> educations = new List<EducationDataModel>();
            educations = readJsonDataobj.EducationObjectWithNewtonsoftJson();

           for (int i = 0; i < educations.Count; i++)
            {
                string university = educations[3].UniversityName;
                string country = educations[3].CountryName;
                string title = educations[3].Title;
                string degree = educations[3].DegreeName;
                string graduationYear = educations[3].YearOfGraduation;

                educationPageObj.AddNewEducation(university, country, title, degree, graduationYear);
           }
        }

        [Test, Order(3), Description("Adding a new education record with special characters")]
        public void TestAddingNewEducationRecordWithSpecialCharacters()
        {

            ReadJsonData readJsonDataobj = new ReadJsonData("C://CompetetiveTaskVer1//CompetetiveTaskVer1//CompetetiveTaskEducationaAndCertificationAutomation//TestData//UserData.json");
            List<EducationDataModel> educations = new List<EducationDataModel>();
            educations = readJsonDataobj.EducationObjectWithNewtonsoftJson();

            for (int i = 0; i < educations.Count; i++)
            {
                string university = educations[4].UniversityName;
                string country = educations[4].CountryName;
                string title = educations[4].Title;
                string degree = educations[4].DegreeName;
                string graduationYear = educations[4].YearOfGraduation;

                educationPageObj.AddNewEducation(university, country, title, degree, graduationYear);
            }
        }

        [TearDown]
        public void TearDownEducationTest()
        {
            Close();
            EndTest();
            ExtentReporting.EndReporting();
        }

        public void EndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch(testStatus)
            {
                case TestStatus.Failed:
                    ExtentReporting.LogFail($"Test has failed {message}");
                    break;
                case TestStatus.Skipped:
                    ExtentReporting.LogInfo($"Test skipped {message}");
                    break;
                default:
                break;
            }

            //ExtentReporting.LogScreenShot("Ending Test",);
        }

    }

}
