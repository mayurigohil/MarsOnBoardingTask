using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MarsOnboardingTask.Utility
{
    class CommonDriver
    {
        public static IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
       
    }
}
