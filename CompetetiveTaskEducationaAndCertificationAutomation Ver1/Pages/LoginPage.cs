using CompetetiveTaskEducationaAndCertificationAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetetiveTaskEducationaAndCertificationAutomation.Pages
{
    public class LoginPage : CommonDriver
    {
        public void LoginActions()
        {
            Thread.Sleep(3000);
            IWebElement EmailAdress = driver.FindElement(By.XPath("//input[@name='email']"));
            EmailAdress.Click();
            EmailAdress.Clear();
            EmailAdress.SendKeys("smithajohnson11@gmail.com");

            IWebElement PasswordTextBox = driver.FindElement(By.XPath("//input[@name='password']"));
            PasswordTextBox.Click();
            PasswordTextBox.Clear();
            PasswordTextBox.SendKeys("PraiseLord");
            Thread.Sleep(2000);

            IWebElement LogInButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            LogInButton.Click();

        }
    }
}
