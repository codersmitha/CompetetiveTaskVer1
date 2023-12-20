using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
//using CompetetiveTaskEducationaAnd_CertificationAutomation.Config;
using CompetetiveTaskEducationaAndCertificationAutomation.DataModel;
using CompetetiveTaskEducationaAndCertificationAutomation.Pages;
using CompetetiveTaskEducationaAndCertificationAutomation.Utilities;
using NUnit.Framework;
using System.Diagnostics.Metrics;

namespace CompetetiveTaskEducationaAndCertificationAutomation.Test
{

    [TestFixture]
    public class CertificationsTest : CommonDriver
    {

        HomePage homePageObj = new HomePage();
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();
        EducationPage educationPageObj = new EducationPage();
        CertificationsPage certificationsPageObj = new CertificationsPage();
        List<Certification> certifications = new List<Certification>();


        [OneTimeSetUp]

        public void readJsonData()
        {
            ReadJsonData readJsonDataobj = new ReadJsonData(@"C:\CompetetiveTaskVer1\CompetetiveTaskVer1\CompetetiveTaskEducationaAndCertificationAutomation Ver1\TestData\CertificationData.json");
                    
           certifications = readJsonDataobj.CertificationObjectWithNewtonsoftJson();

        }


        [SetUp]
        public void SetUpEducationTest()
        {
            Initialize();
            homePageObj.SignInActions();
            loginPageObj.LoginActions();
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            profilePageObj.ClickCertificationsTab();

        }

        [Test, Order(1), Description("This test is for deleting  certification records")]
        public void TestDeleteCertificationRecords()
        {
            certificationsPageObj.DeleteCertificationRecords();
        }

        [Test, Order(2), Description("This test is for adding new certification records")]
        public void TestAddNewCertificationRecord()
        {
            for (int i = 0; i < 2; i++)
            {

                string certificationName = certifications[i].CertificationName;
                string certificationRecivedFrom = certifications[i].CertificationReceivedFrom;
                string certificationYear = certifications[i].CertificationYear;

                certificationsPageObj.AddNewCertificationRecord(certificationName, certificationRecivedFrom, certificationYear);

            }

        }


        [Test, Order(3), Description("This test is for adding a duplicate certification record")]
        public void TestAddDuplicateCertificationRecord()
        {

            string certificationName = certifications[0].CertificationName;
            string certificationRecivedFrom = certifications[0].CertificationReceivedFrom;
            string certificationYear = certifications[0].CertificationYear;

            certificationsPageObj.AddDuplicateCertificationRecord(certificationName, certificationRecivedFrom, certificationYear);

        }


        [Test, Order(4), Description("This test is for adding a certification record with null Value In dropdown field")]
        public void TestAddCertificationRecordWIthNullValueInDropdownField()
        {

            string certificationName = certifications[2].CertificationName;
            string certificationRecivedFrom = certifications[2].CertificationReceivedFrom;
            string certificationYear = certifications[2].CertificationYear;

            certificationsPageObj.AddCertificationRecordWIthNullValueInDropdownField(certificationName, certificationRecivedFrom, certificationYear);

        }

        [Test, Order(5), Description("This test is for adding a certification record with null Value In Textbox field")]
        public void TestAddCertificationRecordWIthNullValueInTextboxFields()
        {

            string certificationName = certifications[3].CertificationName;
            string certificationRecivedFrom = certifications[3].CertificationReceivedFrom;
            string certificationYear = certifications[3].CertificationYear;

            certificationsPageObj.AddCertificationRecordWIthNullValueInTextboxFields(certificationName, certificationRecivedFrom, certificationYear);
        }

        [Test, Order(6), Description("This test is for adding a certification record with null Value In dropdown field")]

        public void TestAddCertificationRecordWIthNullValueInAllFields()
        {

            string certificationName = certifications[4].CertificationName;
            string certificationRecivedFrom = certifications[4].CertificationReceivedFrom;
            string certificationYear = certifications[4].CertificationYear;

            certificationsPageObj.AddCertificationRecordWIthNullValueInAllFields(certificationName, certificationRecivedFrom, certificationYear);
        }



        [Test, Order(7), Description("This test is for adding a certification record with special characters as input in textbox fieldsfield")]

        public void TestAddCertificationRecordWithspecialcharacters()
        {
            string certificationName = certifications[5].CertificationName;
            string certificationRecivedFrom = certifications[5].CertificationReceivedFrom;
            string certificationYear = certifications[5].CertificationYear;

            certificationsPageObj.AddCertificationRecordWithspecialcharacters(certificationName, certificationRecivedFrom, certificationYear);
        }

        [Test, Order(8), Description("This test is for adding a certification record with numbers as input in textbox fieldsfield")]

        public void TestAddCertificationRecordWithnumbersAsInput()
        {

            string certificationName = certifications[6].CertificationName;
            string certificationRecivedFrom = certifications[6].CertificationReceivedFrom;
            string certificationYear = certifications[6].CertificationYear;

            certificationsPageObj.AddCertificationRecordWithnumbersAsInput(certificationName, certificationRecivedFrom, certificationYear);
        }

        [Test, Order(9), Description("This test is for adding a certification record with spaces as input in textbox fields")]

        public void TestAddCertificationRecordWithspacesAsInput()
        {

            string certificationName = certifications[7].CertificationName;
            string certificationRecivedFrom = certifications[7].CertificationReceivedFrom;
            string certificationYear = certifications[7].CertificationYear;

            certificationsPageObj.AddCertificationRecordWithSpacesAsInput(certificationName, certificationRecivedFrom, certificationYear);
        }

        [Test, Order(10), Description("This test is for adding a certification record with existing record's value as input in textbox fields")]

        public void TestAddExistingRecordValuesForTextBoxFields()
        {

            string certificationName = certifications[8].CertificationName;
            string certificationRecivedFrom = certifications[8].CertificationReceivedFrom;
            string certificationYear = certifications[8].CertificationYear;

            certificationsPageObj.AddExistingRecordValuesForTextBoxFields(certificationName, certificationRecivedFrom, certificationYear);
        }


        [Test, Order(11), Description("This test is to abandon the process without saving the entered Certifications details.")]

        public void TestCancelAddCertificationData()
        {
            string certificationName = certifications[9].CertificationName;
            string certificationRecivedFrom = certifications[9].CertificationReceivedFrom;
            string certificationYear = certifications[9].CertificationYear;

            certificationsPageObj.CancelAddCertificationData(certificationName, certificationRecivedFrom, certificationYear);
        }

        [Test, Order(12), Description("This test is to add certification record with very long values for the textbox fields.")]

        public void TestAddVeryLongValuesForTextBoxFields()
        {
            string certificationName = certifications[10].CertificationName;
            string certificationRecivedFrom = certifications[10].CertificationReceivedFrom;
            string certificationYear = certifications[10].CertificationYear;

            certificationsPageObj.AddVeryLongValuesForTextBoxFields(certificationName, certificationRecivedFrom, certificationYear);
        }



        [Test, Order(13), Description("This test is to update all the field values of a certification record with new  values ")]

        public void TestUpdateAllFieldWithNewValues()
        {
            string certificationName = certifications[11].CertificationName;
            string certificationRecivedFrom = certifications[11].CertificationReceivedFrom;
            string certificationYear = certifications[11].CertificationYear;

            certificationsPageObj.UpdateAllFieldWithNewValues(certificationName, certificationRecivedFrom, certificationYear);
        }

        [Test, Order(14), Description("This test is to update textbox fields with new values and without changing  the dropdown field value  of a certification record ")]

        public void TestUpdateCertificationTextboxFeldWithNewValues()
        {
            string certificationName = certifications[13].CertificationName;
            string certificationRecivedFrom = certifications[13].CertificationReceivedFrom;
            string certificationYear = certifications[13].CertificationYear;

            certificationsPageObj.UpdateCertificationTextboxFeldWithNewValues(certificationName, certificationRecivedFrom, certificationYear);
        }



        [Test, Order(15), Description("This test is to update  the dropdown field value with new value and without changing the values in the textbox fields  of a certification record ")]

        public void TestUpdateCertificationDropdownFeldWithNewValues()
        {
            string certificationName = certifications[12].CertificationName;
            string certificationRecivedFrom = certifications[12].CertificationReceivedFrom;
            string certificationYear = certifications[12].CertificationYear;

            certificationsPageObj.UpdateCertificationDropdownFeldWithNewValues(certificationName, certificationRecivedFrom, certificationYear);
        }

        [Test, Order(16), Description("This test is to update all the field values of a certification record with null  values ")]

        public void TestUpdatCertificationAllFeldWithNullValues()
        {
            string certificationName = certifications[15].CertificationName;
            string certificationRecivedFrom = certifications[15].CertificationReceivedFrom;
            string certificationYear = certifications[15].CertificationYear;

            certificationsPageObj.UpdatCertificationAllFeldWithNullValues(certificationName, certificationRecivedFrom, certificationYear);
        }

        [Test, Order(17), Description("This test is to update dropdown field values of a certification record with null  values ")]

        public void TestUpdatCertificationDropdownFieldWithNullValue()
        {
            string certificationName = certifications[14].CertificationName;
            string certificationRecivedFrom = certifications[14].CertificationReceivedFrom;
            string certificationYear = certifications[14].CertificationYear;

            certificationsPageObj.UpdatCertificationDropdownFieldWithNullValue(certificationName, certificationRecivedFrom, certificationYear);
        }

        [Test, Order(18), Description("This test is to update Textbox field with null  values of a certification record ")]

        public void TestUpdatCertificationTextboxFieldWithNullValue()
        {
            string certificationName = certifications[16].CertificationName;
            string certificationRecivedFrom = certifications[16].CertificationReceivedFrom;
            string certificationYear = certifications[16].CertificationYear;

            certificationsPageObj.UpdatCertificationTextboxFieldWithNullValue(certificationName, certificationRecivedFrom, certificationYear);
        }



        [Test, Order(19), Description("This test is to update an existing  certification record without editing all fields ")]

        public void TestUpdatCertificationWithouteditFieldValues()
        {
            certificationsPageObj.UpdatCertificationWithouteditFieldValues();
        }



        [Test, Order(20), Description("This test is to update Textbox field with specialcharacters as new value for an existing certification record ")]

        public void TestUpdateCertificationTextboxFeldWithSpecialCharacters()
        {
            string certificationName = certifications[17].CertificationName;
            string certificationRecivedFrom = certifications[17].CertificationReceivedFrom;
            string certificationYear = certifications[17].CertificationYear;

            certificationsPageObj.UpdateCertificationTextboxFeldWithSpecialCharacters(certificationName, certificationRecivedFrom, certificationYear);
        }


        [Test, Order(21), Description("This test is to update Textbox field with numbers as new value for an existing certification record ")]

        public void TestUpdateCertificationTextboxFeldWithnumbersAsInput()
        {
            string certificationName = certifications[18].CertificationName;
            string certificationRecivedFrom = certifications[18].CertificationReceivedFrom;
            string certificationYear = certifications[18].CertificationYear;

            certificationsPageObj.UpdateCertificationTextboxFeldWithnumbersAsInput(certificationName, certificationRecivedFrom, certificationYear);
        }


        [Test, Order(22), Description("This test is to update Textbox field with spaces as new value for an existing certification record ")]

        public void TestUpdateCertificationTextboxFeldWithSpacesAsInput()
        {
            string certificationName = certifications[19].CertificationName;
            string certificationRecivedFrom = certifications[19].CertificationReceivedFrom;
            string certificationYear = certifications[19].CertificationYear;

            certificationsPageObj.UpdateCertificationTextboxFeldWithSpacesAsInput(certificationName, certificationRecivedFrom, certificationYear);
        }


        [Test, Order(23), Description("This test is to update Textbox field with spaces as new value for an existing certification record ")]

        public void TestCancelUpdateCertificationData()
        {
            string certificationName = certifications[20].CertificationName;
            string certificationRecivedFrom = certifications[20].CertificationReceivedFrom;
            string certificationYear = certifications[20].CertificationYear;

            certificationsPageObj.CancelUpdateCertificationData(certificationName, certificationRecivedFrom, certificationYear);
        }


        [Test, Order(24), Description("This test is to update Textbox field with very long values for an existing certification record ")]

        public void TestUpdateCertificationTextboxFeldWithVeryLongValueAsInput()
        {
            string certificationName = certifications[21].CertificationName;
            string certificationRecivedFrom = certifications[21].CertificationReceivedFrom;
            string certificationYear = certifications[21].CertificationYear;

            certificationsPageObj.UpdateCertificationTextboxFeldWithVeryLongValueAsInput(certificationName, certificationRecivedFrom, certificationYear);
        }



    }
}

