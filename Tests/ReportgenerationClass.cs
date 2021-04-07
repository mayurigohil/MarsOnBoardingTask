using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using MarsOnboardingTask.Hooks;
using MarsOnboardingTask.Utility;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MarsOnboardingTask.Tests
{
    [SetUpFixture]
    class ReportgenerationClass : CommonDriver
    {
        protected ExtentReports _extent;
        protected ExtentTest _test;
        public IWebDriver _driver;

        [OneTimeSetUp]
        protected void Setup()
        {
            var path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = path.Substring(0, path.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            Directory.CreateDirectory(projectPath.ToString() + "Reports");
            var reportPath = (projectPath + "Reports\\ExtentReport.html");
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);
            _extent.AddSystemInfo("Host Name", "LocalHost");
            _extent.AddSystemInfo("Environment", "QA");
            _extent.AddSystemInfo("UserName", "TestUser");
        }
        [OneTimeTearDown]
        protected void TearDown()
        {
            _extent.Flush();
        }

    }
}
    

