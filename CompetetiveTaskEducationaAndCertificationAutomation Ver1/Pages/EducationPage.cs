using CompetetiveTaskEducationaAndCertificationAutomation.DataModel;
using CompetetiveTaskEducationaAndCertificationAutomation.Utilities;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetetiveTaskEducationaAndCertificationAutomation.Pages
{
    public class EducationPage : CommonDriver

    {

        int cancelFlag = 0;
        String actualMessage = "";
        String expectedMessage = "";
        ProfilePage profilePageobj = new ProfilePage();
        public void DeleteEducationRecords()
        {
            int rowCount = driver.FindElements(By.XPath("//div[@data-tab='third']//tbody")).Count;
            for (int i = 1; i <= rowCount;)
            {
                Thread.Sleep(2000);
                IWebElement deleteButton = driver.FindElement(By.XPath("//div[@data-tab='third']//tbody[1]//i[@class='remove icon']"));
                deleteButton.Click();
                rowCount--;
                Thread.Sleep(3000);

                IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                //Thread.Sleep(3000);
                string actualMessage = messageBox.Text;
                Console.WriteLine(actualMessage);

                string expectedMessage = "Education entry successfully removed";
                Assert.That(actualMessage.Equals(expectedMessage), "Education has not been deleted");
                Thread.Sleep(1000);
            }

        }

        public void AddNewEducation(string university, string country, string title, string degree, string graduationYear)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);

            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);

            Thread.Sleep(2000);
            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);

            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);

            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);

            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Education has been added";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been added");

        }

        public void AddingDuplicateEducationRecord(string university, string country, string title, string degree, string graduationYear)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);

            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);

            Thread.Sleep(2000);
            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);

            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);

            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);

            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);

            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "This information is already exist.";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has been added");

        }

        public void AddingNewEducationRecordWithSpecialCharacters(string university, string country, string title, string degree, string graduationYear)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);
            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);
            Thread.Sleep(2000);

            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);
            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);
            Thread.Sleep(2000);

            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string expectedMessage = "Education has been added";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been added");

        }

        public void AddingNewEducationRecordWithNumbers(string university, string country, string title, string degree, string graduationYear)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);
            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);
            Thread.Sleep(2000);

            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);
            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);
            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string expectedMessage = "Education has been added";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been added");
        }

        public void AddNewEducationwithNullDataInAllFields(string university, string country, string title, string degree, string graduationYear)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//div[@data-tab='third']//div[contains(text(),'Add New')]"));
            addNewButton.Click();
            if (string.IsNullOrEmpty(university) && string.IsNullOrEmpty(country) && string.IsNullOrEmpty(title) && string.IsNullOrEmpty(degree) && string.IsNullOrEmpty(graduationYear))
            {
                Thread.Sleep(2000);
                IWebElement addButton = driver.FindElement(By.XPath("//div[@data-tab='third']//input[1][@value='Add']"));
                addButton.Click();
                Thread.Sleep(1000);
                IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                String actualMessage = messageBox.Text;
                Console.WriteLine(actualMessage);
                String expectedMessage = "Please enter all the fields";
                Assert.That(actualMessage.Equals(expectedMessage), "The education record has not been added successfully");
            }
        }

        public void AddNewEducationwithNullDataInDropdownfields(string university, string country, string title, string degree, string graduationYear)

        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            //driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);
            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);
            Thread.Sleep(2000);
            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);
            Thread.Sleep(2000);
            IWebElement addButton = driver.FindElement(By.XPath("//div[@data-tab='third']//input[1][@value='Add']"));
            addButton.Click();
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            String actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            String expectedMessage = "Please enter all the fields";
            Assert.That(actualMessage.Equals(expectedMessage), "The education record has not been added successfully");

        }

        public void AddNewEducationwithNullDataInTextboxfields(string university, string country, string title, string degree, string graduationYear)

        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            //driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);

            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);
            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);
            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            String actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            String expectedMessage = "Please enter all the fields";
            Assert.That(actualMessage.Equals(expectedMessage), "The education record has not been added successfully");
        }


        public void AddingNewEducationRecordWithExistingValuesAsInputInTextboxFields(string university, string country, string title, string degree, string graduationYear)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);
            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);
            Thread.Sleep(2000);

            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);
            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);
            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string expectedMessage = "Education has been added";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been added");

        }

        public void AddingNewEducationRecordWithSpaceAsInput(string university, string country, string title, string degree, string graduationYear)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            //driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);
            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);
            Thread.Sleep(2000);

            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);
            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);
            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string expectedMessage = "Education information was invalid";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has been added");
        }


        public void CancelDataAddingNewEducationRecord(string university, string country, string title, string degree, string graduationYear)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);
            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);
            Thread.Sleep(2000);

            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);
            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);
            Thread.Sleep(2000);

            IWebElement cancelButton = driver.FindElement(By.XPath("//div[@data-tab='third']//input[@value='Cancel']"));
            cancelButton.Click();
            Thread.Sleep(2000);

            IWebElement lastRecordAdded = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            if (!lastRecordAdded.Text.Equals("Wollongong"))
            {
                Console.WriteLine("Education record cancelled");
                Assert.That(!lastRecordAdded.Text.Equals("Wollongong"), "The education record not cancelled successfully");
            }

        }

        public void AddingNewEducationRecordWithLongValuesAsInput(string university, string country, string title, string degree, string graduationYear)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);
            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);
            Thread.Sleep(2000);

            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);
            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);
            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string expectedMessage = "Education has been added";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been added");

        }

        public void UpdateEducationRecord(string university, string country, string title, string degree, string graduationYear)
        {
            Thread.Sleep(2000);
            IWebElement pencilIcon = driver.FindElement(By.XPath("//div[@data-tab='third']//tbody[1]//i[@class='outline write icon']"));
            pencilIcon.Click();
            IWebElement updateUniversityTextBox = driver.FindElement(By.Name("instituteName"));
            IWebElement updateDegreeTextBox = driver.FindElement(By.Name("degree"));
            IWebElement chooseCountryDropDown = driver.FindElement(By.Name("country"));
            IWebElement chooseTitleDropDown = driver.FindElement(By.Name("title"));
            IWebElement chooseYearDropDown = driver.FindElement(By.Name("yearOfGraduation"));

            if (string.IsNullOrEmpty(university))
            {
                var action = new OpenQA.Selenium.Interactions.Actions(driver);
                action.Click(updateUniversityTextBox);
                action.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).SendKeys(Keys.Delete);
                action.Perform();
                Thread.Sleep(2000);

            }

            else
            {
                updateUniversityTextBox.Clear();
                updateUniversityTextBox.SendKeys(university);
                Thread.Sleep(2000);
            }

            if (string.IsNullOrEmpty(degree))
            {
                var action = new OpenQA.Selenium.Interactions.Actions(driver);
                action.Click(updateDegreeTextBox);
                action.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).SendKeys(Keys.Delete);
                action.Perform();
                Thread.Sleep(2000);

            }
            else
            {
                updateDegreeTextBox.Clear();
                updateDegreeTextBox.SendKeys(degree);
                Thread.Sleep(2000);
            }

            if (!string.IsNullOrEmpty(country))
            {
                chooseCountryDropDown.Click();
                chooseCountryDropDown.SendKeys(country);
                Thread.Sleep(2000);
            }
            else
            {
                chooseCountryDropDown.Click();
                chooseCountryDropDown.SendKeys("Country of College/University");
                //chooseCountryDropDown.SendKeys("Country of College / University");
                Thread.Sleep(2000);
            }
            if (!string.IsNullOrEmpty(title))
            {
                chooseTitleDropDown.Click();
                chooseTitleDropDown.SendKeys(title);
                Thread.Sleep(2000);
            }
            else
            {
                chooseTitleDropDown.Click();
                chooseTitleDropDown.SendKeys("Title");
                Thread.Sleep(2000);
            }
            if (!string.IsNullOrEmpty(graduationYear))
            {
                chooseYearDropDown.Click();
                chooseYearDropDown.SendKeys(graduationYear);
                Thread.Sleep(2000);
            }
            else
            {
                chooseYearDropDown.Click();
                chooseYearDropDown.SendKeys("Year of graduation");
                chooseYearDropDown.Click();
                Thread.Sleep(2000);
            }
            Thread.Sleep(2000);
            if (cancelFlag != 1)
            {
                IWebElement updateButton = driver.FindElement(By.XPath("//div[@data-tab='third']//input[@value='Update']"));
                updateButton.Click();
                Thread.Sleep(2000);
            }
        }

        public void UpdateAllFieldWithNewValues(string university, string country, string title, string degree, string graduationYear)
        {
            UpdateEducationRecord(university, country, title, degree, graduationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Education as been updated";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been updated");
            Thread.Sleep(1000);

        }
        public void UpdateTextBoxFieldWithNewValues(string university, string country, string title, string degree, string graduationYear)
        {
            UpdateEducationRecord(university, country, title, degree, graduationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Education as been updated";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been updated");
            Thread.Sleep(1000);

        }

        public void UpdateDropdownFieldWIthNewValues(string country, string title, string graduationYear)
        {
            IWebElement pencilIcon = driver.FindElement(By.XPath("//div[@data-tab='third']//tbody[1]//i[@class='outline write icon']"));
            pencilIcon.Click();
            Thread.Sleep(2000);

            IWebElement chooseCountryDropDown = driver.FindElement(By.Name("country"));
            chooseCountryDropDown.Click();
            chooseCountryDropDown.SendKeys(country);
            Thread.Sleep(2000);

            IWebElement chooseTitleDropDown = driver.FindElement(By.Name("title"));
            chooseTitleDropDown.Click();
            chooseTitleDropDown.SendKeys(title);
            Thread.Sleep(2000);

            IWebElement chooseYearDropDown = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearDropDown.Click();
            chooseYearDropDown.SendKeys(graduationYear);
            Thread.Sleep(2000);

            IWebElement updateButton = driver.FindElement(By.XPath("//div[@data-tab='third']//input[@value='Update']"));
            updateButton.Click();

            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);

            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Education as been updated";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been updated");
            Thread.Sleep(1000);

        }

        public void UpdateEducationRecordWithNullValues(string university, string country, string title, string degree, string graduationYear)
        {
            UpdateEducationRecord(university, country, title, degree, graduationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Please enter all the fields";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has  been updated");
            Thread.Sleep(1000);

        }

       
        public void UpdateTextBoxFieldWithNullValues(string university, string country, string title, string degree, string graduationYear)
        {
            UpdateEducationRecord(university, country, title, degree, graduationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Please enter all the fields";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has been updated");
            Thread.Sleep(1000);

        }


        public void UpdateDropdownFieldWIthNullValues(string university, string country, string title, string degree, string graduationYear)
        {

            UpdateEducationRecord(university, country, title, degree, graduationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Please enter all the fields";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has been updated");
            Thread.Sleep(1000);

        }

        public void UpdateEducationRecordWithoutEditingAllFieldValues()
        {
            IWebElement pencilIcon = driver.FindElement(By.XPath("//div[@data-tab='third']//tbody[1]//i[@class='outline write icon']"));
            pencilIcon.Click();
            Thread.Sleep(2000);

            IWebElement updateButton = driver.FindElement(By.XPath("//div[@data-tab='third']//input[@value='Update']"));
            updateButton.Click();

            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "This information is already exist.";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has been updated");
            Thread.Sleep(1000);

        }

        public void UpdateTextboxFieldsWithSpecialCharactersAsValues(string university, string country, string title, string degree, string graduationYear)
        {
            UpdateEducationRecord(university, country, title, degree, graduationYear);
            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Education as been updated";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been updated");
            Thread.Sleep(1000);

        }

        public void UpdateTextboxFieldsWithNumbersAsValues(string university, string country, string title, string degree, string graduationYear)
        {
            UpdateEducationRecord(university, country, title, degree, graduationYear);
            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Education as been updated";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been updated");
            Thread.Sleep(1000);

        }

        public void UpdateTextboxFieldsWithSpacesAsValues(string university, string country, string title, string degree, string graduationYear)
        {
            UpdateEducationRecord(university, country, title, degree, graduationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Education information was invalid";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has been updated");
            Thread.Sleep(1000);

        }

        public void CancelUpdateEducationInputValues(string university, string country, string title, string degree, string graduationYear)
        {
            cancelFlag = 1;
            UpdateEducationRecord(university, country, title, degree, graduationYear);
            cancelFlag = 0;
            Thread.Sleep(2000);
            IWebElement CancelButton = driver.FindElement(By.XPath("//div[@data-tab='third']//input[@value='Cancel']"));
            CancelButton.Click();
            Thread.Sleep(2000);

            IWebElement editRecord = driver.FindElement(By.XPath("//div[@data-tab='third']//tbody[1]/tr/td[2]"));
            Assert.That(!editRecord.Text.Equals("Wyong"), "The education record has been added successfully");

            Thread.Sleep(1000);

        }

        public void UpdateTextboxFieldsWithExistingRecordsTextBoxFieldValues(string university, string country, string title, string degree, string graduationYear)
        {
            UpdateEducationRecord(university, country, title, degree, graduationYear);
            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Education as been updated";
            Assert.That(actualMessage.Equals(expectedMessage), "Education has not been updated");
            Thread.Sleep(1000);

        }

    }

}





