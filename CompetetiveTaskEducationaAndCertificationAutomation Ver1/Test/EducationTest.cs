using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CompetetiveTaskEducationaAndCertificationAutomation.DataModel;
using CompetetiveTaskEducationaAndCertificationAutomation.Pages;
using CompetetiveTaskEducationaAndCertificationAutomation.Utilities;
using NUnit.Framework;
using System.Diagnostics.Metrics;

namespace CompetetiveTaskEducationaAndCertificationAutomation.Test
{
    [TestFixture]
    public class EducationTest : CommonDriver
    {

        HomePage homePageObj = new HomePage();
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();
        EducationPage educationPageObj = new EducationPage();
        List<Education> educations = new List<Education>();

        [OneTimeSetUp]

        public void readJsonData()
        {
            ReadJsonData readJsonDataobj = new ReadJsonData(@"C:\\CompetetiveTaskVer1\\CompetetiveTaskVer1\\CompetetiveTaskEducationaAndCertificationAutomation Ver1\\TestData\\UserData.json");

            educations = readJsonDataobj.EducationObjectWithNewtonsoftJson();

        }


        [SetUp]
        public void SetUpEducationTest()
        {
            Initialize();
            homePageObj.SignInActions();
            loginPageObj.LoginActions();
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            profilePageObj.ClickEducationTab();

        }

        [Test, Order(1), Description("This test is for deleting  education records")]
        public void DeleteEducationRecord()
        {
            educationPageObj.DeleteEducationRecords();
        }


        [Test, Order(2), Description("This test is for adding new education record")]

        public void TestAddnewEducation()
        {

            for (int i = 0; i < 2; i++)
            {

                string university = educations[i].UniversityName;
                string country = educations[i].CountryName;
                string title = educations[i].Title;
                string degree = educations[i].DegreeName;
                string graduationYear = educations[i].YearOfGraduation;

                educationPageObj.AddNewEducation(university, country, title, degree, graduationYear);
            }
        }


        [Test, Order(3), Description("Adding a duplicate education record")]

        public void TestAddDuplicateEducation()
        {

            string university = educations[1].UniversityName;
            string country = educations[1].CountryName;
            string title = educations[1].Title;
            string degree = educations[1].DegreeName;
            string graduationYear = educations[1].YearOfGraduation;

            educationPageObj.AddingDuplicateEducationRecord(university, country, title, degree, graduationYear);
        }

        [Test, Order(4), Description("Adding a new education record with special characters as input")]
        public void TestAddingNewEducationRecordWithSpecialCharacters()
        {

            string university = educations[2].UniversityName;
            string country = educations[2].CountryName;
            string title = educations[2].Title;
            string degree = educations[2].DegreeName;
            string graduationYear = educations[2].YearOfGraduation;

            educationPageObj.AddingNewEducationRecordWithSpecialCharacters(university, country, title, degree, graduationYear);
        }

        [Test, Order(5), Description("Adding a new education record with numbers as input")]
        public void TestAddingNewEducationRecordWithNumbers()
        {

            string university = educations[3].UniversityName;
            string country = educations[3].CountryName;
            string title = educations[3].Title;
            string degree = educations[3].DegreeName;
            string graduationYear = educations[3].YearOfGraduation;

            educationPageObj.AddingNewEducationRecordWithNumbers(university, country, title, degree, graduationYear);
        }

        [Test, Order(6), Description("Adding new education record without entering data in required fields")]
        public void TestAddNewEducationwithNullDataInAllFields()
        {

            string university = educations[4].UniversityName;
            string country = educations[4].CountryName;
            string title = educations[4].Title;
            string degree = educations[4].DegreeName;
            string graduationYear = educations[4].YearOfGraduation;

            educationPageObj.AddNewEducationwithNullDataInAllFields(university, country, title, degree, graduationYear);

        }

        [Test, Order(7), Description("Adding new education record with null data in the text box fields")]
        public void TestAddNewEducationwithNullDataInTextboxfields()
        {
            string university = educations[5].UniversityName;
            string country = educations[5].CountryName;
            string title = educations[5].Title;
            string degree = educations[5].DegreeName;
            string graduationYear = educations[5].YearOfGraduation;

            educationPageObj.AddNewEducationwithNullDataInTextboxfields(university, country, title, degree, graduationYear);

        }

        [Test, Order(8), Description("Adding new education record without choosing values for the dropdown fields")]
        public void TestAddNewEducationwithNullDataInDropdownfields()
        {

            string university = educations[6].UniversityName;
            string country = educations[6].CountryName;
            string title = educations[6].Title;
            string degree = educations[6].DegreeName;
            string graduationYear = educations[6].YearOfGraduation;

            educationPageObj.AddNewEducationwithNullDataInDropdownfields(university, country, title, degree, graduationYear);

        }


        [Test, Order(9), Description("Adding a new education record with existing field values of text box abd choosing different values for dropdown fields")]
        public void TestAddingNewEducationRecordWithExistingValuesAsInputInTextboxFields()
        {

            string university = educations[7].UniversityName;
            string country = educations[7].CountryName;
            string title = educations[7].Title;
            string degree = educations[7].DegreeName;
            string graduationYear = educations[7].YearOfGraduation;

            educationPageObj.AddingNewEducationRecordWithExistingValuesAsInputInTextboxFields(university, country, title, degree, graduationYear);
        }


        [Test, Order(10), Description("Adding a new education record with spaces as input for the textbox fields")]
        public void TestAddingNewEducationRecordWithSpaceAsInput()
        {

            string university = educations[8].UniversityName;
            string country = educations[8].CountryName;
            string title = educations[8].Title;
            string degree = educations[8].DegreeName;
            string graduationYear = educations[8].YearOfGraduation;

            educationPageObj.AddingNewEducationRecordWithSpaceAsInput(university, country, title, degree, graduationYear);
        }

        [Test, Order(11), Description("This test is to abandon the process without saving the entered education details")]
        public void TestCancelDataAddingNewEducationRecord()
        {

            string university = educations[2].UniversityName;
            string country = educations[2].CountryName;
            string title = educations[2].Title;
            string degree = educations[2].DegreeName;
            string graduationYear = educations[2].YearOfGraduation;

            educationPageObj.CancelDataAddingNewEducationRecord(university, country, title, degree, graduationYear);
        }

        [Test, Order(12), Description("Adding a new education record with very long values as input in text fields")]
        public void TestAddingNewEducationRecordWithLongValuesAsInput()
        {

            string university = educations[9].UniversityName;
            string country = educations[9].CountryName;
            string title = educations[9].Title;
            string degree = educations[9].DegreeName;
            string graduationYear = educations[9].YearOfGraduation;

            educationPageObj.AddingNewEducationRecordWithLongValuesAsInput(university, country, title, degree, graduationYear);
        }


        [Test, Order(13), Description("This test is for updating education record with new value in all the fields")]
        public void TestUpdateAllFieldWithNewValues()
        {

            string university = educations[10].UniversityName;
            string country = educations[10].CountryName;
            string title = educations[10].Title;
            string degree = educations[10].DegreeName;
            string graduationYear = educations[10].YearOfGraduation;

            educationPageObj.UpdateAllFieldWithNewValues(university, country, title, degree, graduationYear);

        }


        [Test, Order(14), Description("This test is to update education record with new values in text fields")]
        public void TestUpdateTextBoxFieldWithNewValues()
        {

            string university = educations[11].UniversityName;
            string country = educations[11].CountryName;
            string title = educations[11].Title;
            string degree = educations[11].DegreeName;
            string graduationYear = educations[11].YearOfGraduation;

            educationPageObj.UpdateTextBoxFieldWithNewValues(university, country, title, degree, graduationYear);

        }


        [Test, Order(15), Description("This test is to Update education record with new values in Drop down fields")]
        public void TestUpdateDropdownFieldWithNewValues()
        {
            string university = educations[12].UniversityName;
            string country = educations[12].CountryName;
            string title = educations[12].Title;
            string degree = educations[12].DegreeName;
            string graduationYear = educations[12].YearOfGraduation;

            educationPageObj.UpdateDropdownFieldWIthNewValues(country, title, graduationYear);
        }

        [Test, Order(16), Description("Update education record with null values in all fields")]
        public void TestUpdateEducationRecordWithNullValues()
        {
            string university = educations[4].UniversityName;
            string country = educations[4].CountryName;
            string title = educations[4].Title;
            string degree = educations[4].DegreeName;
            string graduationYear = educations[4].YearOfGraduation;

            educationPageObj.UpdateEducationRecordWithNullValues(university, country, title, degree, graduationYear);
        }

        [Test, Order(18), Description("This test is to update education record with null values in Drop down fields")]
        public void TestUpdateDropdownFieldWIthNullValues()
        {

            string university = educations[6].UniversityName;
            string country = educations[6].CountryName;
            string title = educations[6].Title;
            string degree = educations[6].DegreeName;
            string graduationYear = educations[6].YearOfGraduation;

            educationPageObj.UpdateDropdownFieldWIthNullValues(university, country, title, degree, graduationYear);

        }


        [Test, Order(19), Description("This test is for updating education record without editing all the field values")]
        public void TestUpdateEducationRecordWithoutEditingAllFieldValues()
        {

            educationPageObj.UpdateEducationRecordWithoutEditingAllFieldValues();
        }


        [Test, Order(20), Description("Update education record with special characters as input for textbox fields")]
        public void TestUpdateTextboxFieldsWithSpecialCharactersAsValues()
        {
            string university = educations[13].UniversityName;
            string country = educations[13].CountryName;
            string title = educations[13].Title;
            string degree = educations[13].DegreeName;
            string graduationYear = educations[13].YearOfGraduation;

            educationPageObj.UpdateTextboxFieldsWithSpecialCharactersAsValues(university, country, title, degree, graduationYear);
        }

        [Test, Order(21), Description("Update education record with numbers as input for textbox fields")]
        public void TestUpdateTextboxFieldsWithNumbersAsValues()
        {
            string university = educations[14].UniversityName;
            string country = educations[14].CountryName;
            string title = educations[14].Title;
            string degree = educations[14].DegreeName;
            string graduationYear = educations[14].YearOfGraduation;

            educationPageObj.UpdateTextboxFieldsWithNumbersAsValues(university, country, title, degree, graduationYear);
        }


        [Test, Order(22), Description("This test is to update education record with spaces as input in  textfields")]
        public void TestUpdateTextboxFieldsWithSpacesAsValues()
        {
            string university = educations[8].UniversityName;
            string country = educations[8].CountryName;
            string title = educations[8].Title;
            string degree = educations[8].DegreeName;
            string graduationYear = educations[8].YearOfGraduation;

            educationPageObj.UpdateTextboxFieldsWithSpacesAsValues(university, country, title, degree, graduationYear);

        }

        [Test, Order(23), Description("Cancel update education record entry")]
        public void TestCancelUpdateEducationInputValues()
        {
            string university = educations[15].UniversityName;
            string country = educations[15].CountryName;
            string title = educations[15].Title;
            string degree = educations[15].DegreeName;
            string graduationYear = educations[15].YearOfGraduation;

            educationPageObj.CancelUpdateEducationInputValues(university, country, title, degree, graduationYear);
        }

        [Test, Order(24), Description("Cancel update education record entry")]
        public void TestUpdateTextboxFieldsWithExistingRecordsTextBoxFieldValues()
        {
            string university = educations[16].UniversityName;
            string country = educations[16].CountryName;
            string title = educations[16].Title;
            string degree = educations[16].DegreeName;
            string graduationYear = educations[16].YearOfGraduation;

            educationPageObj.UpdateTextboxFieldsWithExistingRecordsTextBoxFieldValues(university, country, title, degree, graduationYear);
        }

        
        [Test, Order(13), Description("Update education record with null values in textbox fields")]
        public void TestUpdateTextBoxFieldWithNullValues()
        {

            
            string university = educations[17].UniversityName;
            string country = educations[17].CountryName;
            string title = educations[17].Title;
            string degree = educations[17].DegreeName;
            string graduationYear = educations[17].YearOfGraduation;

            educationPageObj.UpdateTextBoxFieldWithNullValues(university, country, title, degree, graduationYear);

        }
                           
          
    }

}
