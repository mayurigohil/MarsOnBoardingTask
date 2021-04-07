using MarsOnboardingTask.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsOnboardingTask.Pages
{
    class Login
    {
        private IWebDriver driver;

        public IWebElement SignIn => driver.FindElement(By.XPath("//a[normalize-space()='Sign In']"));
        public IWebElement EmailAddress => driver.FindElement(By.Name("email"));
        public IWebElement Password => driver.FindElement(By.Name("password"));
        public IWebElement LoginBtn => driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
        public IWebElement ProfileName => driver.FindElement(By.XPath("//*[@class='item ui dropdown link'][text()='Hi ']"));

        public void LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();
            WaitClass.ElementPresent(driver, "XPath", "//a[normalize-space()='Sign In']");
            SignIn.Click();
            EmailAddress.SendKeys("Mayuri00gohil@gmail.com");
            Password.SendKeys("Mayuri@123");
            LoginBtn.Click();
            Thread.Sleep(2000);
           // WaitClass.ElementPresent(driver, "XPath", "//a[normalize-space()='Share Skill']");
        }
    }
}
