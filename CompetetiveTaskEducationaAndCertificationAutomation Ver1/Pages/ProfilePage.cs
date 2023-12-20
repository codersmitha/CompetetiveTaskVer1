using CompetetiveTaskEducationaAndCertificationAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetetiveTaskEducationaAndCertificationAutomation.Pages
{
    public class ProfilePage : CommonDriver
    {
        public void ClickEducationTab()
        {
            Thread.Sleep(3000);
            IWebElement educationTab = driver.FindElement(By.XPath("//a[@data-tab='third']"));
            educationTab.Click();
        }


        public void ClickCertificationsTab()
        {
            Thread.Sleep(3000);
            IWebElement clickSkillsTab = driver.FindElement(By.XPath("//a[@data-tab='fourth']"));
            clickSkillsTab.Click();

        }
    }

}
