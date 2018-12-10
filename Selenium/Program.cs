using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;

namespace Selenium
{
    class Program
    {
        private static string Account = "314202050248";
        private static string Password = "123456";
        private static string path = AppDomain.CurrentDomain.BaseDirectory;
        private static string loginUrl = "http://ahpumec.rymooc.com/account/login";

        static void Main(string[] args)
        {
            ToStartSelenium();
        }

        public static void ToStartSelenium()
        {
            PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();
            var driver = new PhantomJSDriver(service);
            driver.Navigate().GoToUrl(loginUrl);
            driver.GetScreenshot().SaveAsFile(@"C:\Users\Administrator\Desktop\123.jpg", ScreenshotImageFormat.Jpeg);
            IWebElement emailInput = driver.FindElement(By.Id("Email"));
            emailInput.SendKeys(Account);
            IWebElement passwordInput = driver.FindElement(By.Id("Password"));
            passwordInput.SendKeys(Password);
            driver.GetScreenshot().SaveAsFile(@"C:\Users\Administrator\Desktop\32.jpg", ScreenshotImageFormat.Jpeg);
            IWebElement loginBtn = driver.FindElement(By.XPath(".//input[@class='btn btn-primary']"));
            loginBtn.Click();
            driver.GetScreenshot().SaveAsFile(@"C:\Users\Administrator\Desktop\34.jpg", ScreenshotImageFormat.Jpeg);
            driver.Close();
            driver.Dispose();
        }
    }
}
