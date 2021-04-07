using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.Hooks
{
   
    class Setup
    {
         public IWebDriver driver;
        
        public void OpenBrowser(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
       
        public void CloseBrowser(IWebDriver driver)
        {
            this.driver = driver;
            driver.Quit();
        }
    }
}
