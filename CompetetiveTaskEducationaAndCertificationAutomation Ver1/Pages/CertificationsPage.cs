using CompetetiveTaskEducationaAndCertificationAutomation.DataModel;
using CompetetiveTaskEducationaAndCertificationAutomation.Utilities;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CompetetiveTaskEducationaAndCertificationAutomation.Pages
{
    public class CertificationsPage : CommonDriver
    {
        int cancelFlag = 0;
        String actualMessage = "";
        String expectedMessage = "";
        ProfilePage profilePageobj = new ProfilePage();

        public void DeleteCertificationRecords()
        {
            int rowCount = driver.FindElements(By.XPath("//div[@data-tab='fourth']//tbody")).Count;
            for (int i = 1; i <= rowCount;)
            {

                IWebElement certificationNameTextBox = driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[1]//td[1]"));
                string certificationName = certificationNameTextBox.Text;

                Thread.Sleep(2000);
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
                deleteButton.Click();
                rowCount--;
                Thread.Sleep(2000);

                IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                Thread.Sleep(2000);

                string actualMessage = messageBox.Text;
                Console.WriteLine(actualMessage);
                Thread.Sleep(1000);
            }
            Assert.That(rowCount == 0, "Certification record has not been deleted");

        }

        public void AddCertification(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//div[@data-tab='fourth']//div[contains(text(),'Add New')]"));
            addNewButton.Click();
            if (!string.IsNullOrEmpty(certificationName))
            {
                IWebElement addCertificationTextBox = driver.FindElement(By.Name("certificationName"));
                addCertificationTextBox.Click();
                addCertificationTextBox.SendKeys(certificationName);
            }
            if (!string.IsNullOrEmpty(certificationRecivedFrom))
            {
                IWebElement addCertificationFromTextbox = driver.FindElement(By.Name("certificationFrom"));
                addCertificationFromTextbox.Click();
                addCertificationFromTextbox.SendKeys(certificationRecivedFrom);
            }
            if (!string.IsNullOrEmpty(certificationYear))
            {
                IWebElement chooseCertificationYear = driver.FindElement(By.Name("certificationYear"));
                chooseCertificationYear.Click();
                chooseCertificationYear.SendKeys(certificationYear);
            }


            Thread.Sleep(2000);
            if (cancelFlag != 1)
            {
                IWebElement addButton = driver.FindElement(By.XPath("//div[@data-tab='fourth']//input[1][@value='Add']"));
                addButton.Click();
            }
        }
        public void AddNewCertificationRecord(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            actualMessage = messageBox.Text;
            expectedMessage = certificationName + " has been added to your certification";
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage.Equals(expectedMessage), "Certification  record has not been added successfully");
        }

        public void AddDuplicateCertificationRecord(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            actualMessage = messageBox.Text;
            expectedMessage = "This information is already exist.";
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage.Equals(expectedMessage), "Certification  record has been added successfully");
        }

        public void AddCertificationRecordWIthNullValueInDropdownField(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            actualMessage = messageBox.Text;
            expectedMessage = "Please enter Certification Name, Certification From and Certification Year";
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage.Equals(expectedMessage), "Certification  record has been added successfully");
        }

        public void AddCertificationRecordWIthNullValueInTextboxFields(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            actualMessage = messageBox.Text;
            expectedMessage = "Please enter Certification Name, Certification From and Certification Year";
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage.Equals(expectedMessage), "Certification  record has been added successfully");
        }

        public void AddCertificationRecordWIthNullValueInAllFields(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            actualMessage = messageBox.Text;
            expectedMessage = "Please enter Certification Name, Certification From and Certification Year";
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage.Equals(expectedMessage), "Certification  record has been added successfully");
        }

        public void AddCertificationRecordWithspecialcharacters(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            actualMessage = messageBox.Text;
            expectedMessage = certificationName + " has been added to your certification";
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage.Equals(expectedMessage), "Certification  record has not been added successfully");
        }

        public void AddCertificationRecordWithnumbersAsInput(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            actualMessage = messageBox.Text;
            expectedMessage = certificationName + " has been added to your certification";
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage.Equals(expectedMessage), "Certification  record has not been added successfully");
        }

        public void AddCertificationRecordWithSpacesAsInput(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            actualMessage = messageBox.Text;
            expectedMessage = "has been added to your certification";
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage.Equals(expectedMessage), "Certification  record has not been added successfully");
        }


        public void AddExistingRecordValuesForTextBoxFields(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            actualMessage = messageBox.Text;
            expectedMessage = "Duplicated data";
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage.Equals(expectedMessage), "Certification  record has been added successfully");
        }

        public void CancelAddCertificationData(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            cancelFlag = 1;
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            cancelFlag = 0;
            IWebElement CancelButton = driver.FindElement(By.XPath("//div[@data-tab='fourth']//input[@value='Cancel']"));
            CancelButton.Click();
            Thread.Sleep(1000);
            IWebElement lastRecord = driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[last()]/tr/td[2]"));
            Assert.That(!lastRecord.Text.Equals("QUT"), "The education record has been added successfully");

        }
        public void AddVeryLongValuesForTextBoxFields(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            AddCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            actualMessage = messageBox.Text;
            expectedMessage = certificationName + " has been added to your certification";
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage.Equals(expectedMessage), "Certification  record has not been added successfully");
        }

        public void UpdateCertification(string CertificationName, string CertificationReceivedFrom, string CertificationYear)
        {

            Thread.Sleep(3000);
            IWebElement pencilIcon = driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[1]//i[@class='outline write icon']"));
            pencilIcon.Click();
            IWebElement updateCertificationNameTextBox = driver.FindElement(By.Name("certificationName"));
            IWebElement updateCertificationFromTextbox = driver.FindElement(By.Name("certificationFrom"));
            IWebElement chooseCertificationYear = driver.FindElement(By.Name("certificationYear"));
            if (string.IsNullOrEmpty(CertificationName))
            {
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.Click(updateCertificationNameTextBox);
                actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).SendKeys(Keys.Delete);
                actions.Perform();
            }
            else
            {
                updateCertificationNameTextBox.Clear();
                updateCertificationNameTextBox.SendKeys(CertificationName);
            }
            if (string.IsNullOrEmpty(CertificationReceivedFrom))
            {
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.Click(updateCertificationFromTextbox);
                actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).SendKeys(Keys.Delete);
                actions.Perform();
            }
            else
            {
                updateCertificationFromTextbox.Clear();
                updateCertificationFromTextbox.SendKeys(CertificationReceivedFrom);
            }
            chooseCertificationYear.Click();
            if (!string.IsNullOrEmpty(CertificationYear))
                chooseCertificationYear.SendKeys(CertificationYear);
            else
                chooseCertificationYear.SendKeys("Year");
            chooseCertificationYear.Click();
            Thread.Sleep(2000);
            if (cancelFlag != 1)
            {
                IWebElement updateButton = driver.FindElement(By.XPath("//div[@data-tab='fourth']//input[@value='Update']"));
                updateButton.Click();
                Thread.Sleep(2000);
            }
        }


        public void UpdateAllFieldWithNewValues(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            //verify the expected message text
            string expectedMessage = certificationName + " has been updated to your certification";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has not been updated");
            Thread.Sleep(1000);

        }

        public void UpdateCertificationTextboxFeldWithNewValues(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = certificationName + " has been updated to your certification";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has not been updated");
            Thread.Sleep(1000);

        }

        public void UpdateCertificationDropdownFeldWithNewValues(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = certificationName + " has been updated to your certification";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has not been updated");
            Thread.Sleep(1000);

        }

        public void UpdatCertificationAllFeldWithNullValues(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(2000);

            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "Please enter Certification Name, Certification From and Certification Year";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has  been updated");
            Thread.Sleep(2000);

        }

        public void UpdatCertificationDropdownFieldWithNullValue(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);


            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);

            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Thread.Sleep(2000);

            string expectedMessage = "Please enter Certification Name, Certification From and Certification Year";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has been updated");
            Thread.Sleep(2000);

        }


        public void UpdatCertificationTextboxFieldWithNullValue(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);


            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Thread.Sleep(2000);
            string expectedMessage = "Please enter Certification Name, Certification From and Certification Year";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has been updated");
            Thread.Sleep(2000);

        }

        public void UpdatCertificationWithouteditFieldValues()
        {
            IWebElement pencilIcon = driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[1]//i[@class='outline write icon']"));
            pencilIcon.Click();

            IWebElement updateButton = driver.FindElement(By.XPath("//div[@data-tab='fourth']//input[@value='Update']"));
            updateButton.Click();
            Thread.Sleep(2000);

            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Thread.Sleep(2000);

            string expectedMessage = "This information is already exist.";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has been updated");
            Thread.Sleep(2000);

        }

        public void UpdateCertificationTextboxFeldWithSpecialCharacters(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = certificationName + " has been updated to your certification";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has not been updated");
            Thread.Sleep(1000);

        }

        public void UpdateCertificationTextboxFeldWithnumbersAsInput(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = certificationName + " has been updated to your certification";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has not been updated");
            Thread.Sleep(1000);

        }

        public void UpdateCertificationTextboxFeldWithSpacesAsInput(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = "has been updated to your certification";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has not been updated");
            Thread.Sleep(1000);

        }

        public void CancelUpdateCertificationData(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            cancelFlag = 1;
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);
            cancelFlag = 0;
            IWebElement CancelButton = driver.FindElement(By.XPath("//div[@data-tab='fourth']//input[@value='Cancel']"));
            CancelButton.Click();
            Thread.Sleep(1000);
            IWebElement lastRecordUpdate = driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[last()]/tr/td[2]"));
            Assert.That(!lastRecordUpdate.Text.Equals("NSW HEALTH"), "The certification  record has been updated successfully");

        }


        public void UpdateCertificationTextboxFeldWithVeryLongValueAsInput(string certificationName, string certificationRecivedFrom, string certificationYear)
        {
            UpdateCertification(certificationName, certificationRecivedFrom, certificationYear);
            Thread.Sleep(1000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            string expectedMessage = certificationName + " has been updated to your certification";
            Assert.That(actualMessage.Equals(expectedMessage), "Certification has not been updated");
            Thread.Sleep(1000);

        }

    }

}
