using CompetetiveTaskEducationaAndCertificationAutomation.Utilities;
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
       
        public void AddNewEducation(string university, string country, string title, string degree, string graduationYear)
        {
            //Click on AddNew button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            //driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);
            //Enter the university name  that needs to be added
            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);
            //Choose the country 
            Thread.Sleep(2000);

            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);
            //Choose the title 
            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            //Enter the Degree that needs to be added
            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            //Choose the year of Graduation
            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);
            //Click on Add button
            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            //get the text of the message element
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            //verify the expected message text
            string expectedMessage1 = "Education has been added";
            //string expectedMessage2 = "Please enter language and level";
            //string expectedMessage3 = "This language is already exist in your language list.";
            //string expectedMessage4 = "Duplicated data";
            //Assert.That(actualMessage.Equals(expectedMessage1), Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage4));
            Assert.That(actualMessage.Equals(expectedMessage1), "Education has not been added");
            
        }
        //public string GetEducation()
        //{

        //    IWebElement newEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        //    return newEducation.Text;
        //    //Assert.That(addLanguage.Text.Equals(language), "Language Not Added Successfully");
        //}
        //public string GetCountry()
        //{
        //    IWebElement newCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        //    return newCountry.Text;

        //}

        //public string GetTitle()
        //{
        //    IWebElement newTitle = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
        //    return newTitle.Text;

        //}

        //public string GetDegree()
        //{
        //    IWebElement newDegree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
        //    return newDegree.Text;

        //}

        //public string GetYear()
        //{
        //    IWebElement newYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]"));
        //    return newYear.Text;

        //}


        public void AddingDuplicateEducationRecord(string university, string country, string title, string degree, string graduationYear)
        {
            //Click on AddNew button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            //driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);
            //Enter the university name  that needs to be added
            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);
            //Choose the country 
            Thread.Sleep(2000);

            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);
            //Choose the title 
            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            //Enter the Degree that needs to be added
            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            //Choose the year of Graduation
            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);
            //Click on Add button
            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);
            
            //IWebElement messageBox1 = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            //Thread.Sleep(1000);
            ////get the text of the message element
            //string popUpMessage = messageBox1.Text;
            //Console.WriteLine(popUpMessage);
            //verify the expected message text
            //string expectedMessage2 = "This information is already exist";
            //string expectedMessage2 = "Please enter language and level";
            //string expectedMessage3 = "This language is already exist in your language list.";
            //string expectedMessage4 = "Duplicated data";
            //Assert.That(actualMessage.Equals(expectedMessage1), Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage4));
            //Assert.That(popUpMessage.Equals(expectedMessage2), "Education has not been added");




        }


        public void AddingNewEducationRecordWithSpecialCharacters(string university, string country, string title, string degree, string graduationYear)
        {
            //Click on AddNew button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            //driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            Thread.Sleep(2000);
            addNewButton.Click();
            Thread.Sleep(2000);
            //Enter the university name  that needs to be added
            IWebElement universityName = driver.FindElement(By.Name("instituteName"));
            universityName.Click();
            universityName.SendKeys(university);
            //Choose the country 
            Thread.Sleep(2000);

            IWebElement chooseCountry = driver.FindElement(By.Name("country"));
            chooseCountry.Click();
            chooseCountry.SendKeys(country);
            //Choose the title 
            Thread.Sleep(2000);
            IWebElement chooseTitle = driver.FindElement(By.Name("title"));
            chooseTitle.Click();
            chooseTitle.SendKeys(title);

            //Enter the Degree that needs to be added
            Thread.Sleep(2000);
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.Click();
            DegreeTextBox.SendKeys(degree);

            //Choose the year of Graduation
            Thread.Sleep(2000);
            IWebElement chooseYearOfGraduation = driver.FindElement(By.Name("yearOfGraduation"));
            chooseYearOfGraduation.Click();
            chooseYearOfGraduation.SendKeys(graduationYear);
            //Click on Add button
            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);

             Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(1000);
            //get the text of the message element
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            //verify the expected message text
            string expectedMessage1 = "Education has been added";
            //string expectedMessage2 = "Please enter language and level";
            //string expectedMessage3 = "This language is already exist in your language list.";
            //string expectedMessage4 = "Duplicated data";
            //Assert.That(actualMessage.Equals(expectedMessage1), Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage4));
            Assert.That(actualMessage.Equals(expectedMessage1), "Education has not been added");




        }
    }
}