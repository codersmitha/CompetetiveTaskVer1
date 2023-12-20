using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetetiveTaskEducationaAndCertificationAutomation.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public  String GetScreenShot()
        {
            var file = ((ITakesScreenshot)driver).GetScreenshot();
            var img = file.AsBase64EncodedString;
            return img;
        }
        public void Close()
        {
            driver.Close();
        }
    }
}
