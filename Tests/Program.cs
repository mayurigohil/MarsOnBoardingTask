using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using NUnit.Framework;
using System.IO;
//using LumenWorks.Framework.IO.Csv;
using System.Collections;
using System.Threading;
using MarsOnboardingTask.Pages;
using MarsOnboardingTask.Utility;
using MarsOnboardingTask.Hooks;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;

namespace MarsOnboardingTask.Tests
{
   
    class Program: CommonDriver
    {
        protected ExtentTest _test;
        protected ExtentReports _extent;
        public IWebDriver _driver;
       // [OneTimeSetUp]
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
        //[OneTimeTearDown]
        protected void TearDown()
        {
            _extent.Flush();
        }
        [SetUp]
        public void SetUpBrowser()
        {
           
            //Setup Obj3 = new Setup();
            //Obj3.OpenBrowser(driver);
            _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
            
        }

        [Test]
        [Category("Login")]
        public void AddDescription()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
            ProfilePage obj5 = new ProfilePage();
            obj5.AddDesCriptionDetails(driver);
            obj5.ValidateAddDesCriptionDetails(driver);
            
        }

        [Test]
        public void AddLanguages()
        {

            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
            ProfilePage obj6 = new ProfilePage();
            obj6.AddLanguageDetails(driver);
            obj6.ValidateAddLanguageDetails(driver);
        }

        [Test]
        public void EditLanguages()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
            ProfilePage obj9 = new ProfilePage();
            obj9.EditLanguageDetails(driver);
            obj9.ValidateEditLanguageDetails(driver);
        }
        [Test]
        public void DeleteLanguages()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
            ProfilePage obj10 = new ProfilePage();
            obj10.DeleteLanguageDetails(driver);

        }
        [Test]

        public void AddSkills()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
            ProfilePage obj7 = new ProfilePage();
            obj7.AddSkillDetails(driver);
            obj7.ValidateAddSkillDetails(driver);
        }
        [Test]
        public void EditSkills()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
            ProfilePage obj11 = new ProfilePage();
            obj11.EditSkillDetails(driver);
            obj11.ValidateEditSkillDetails(driver);
        }
        [Test]
        public void DeleteSkills()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
            ProfilePage obj11 = new ProfilePage();
            obj11.DeleteSkillDetails(driver);
        }
        [Test]
        public void AddEducation()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
            ProfilePage obj8 = new ProfilePage();
            obj8.EducationDetails(driver);
            obj8.ValidateEducationDetails(driver);
        }
        [Test]
        public void AddCerticate()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
            ProfilePage obj7 = new ProfilePage();
            obj7.CertificationDetails(driver);
            obj7.ValidateCertificationDetails(driver);
        }


        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
           // var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace) ? "": string.Format("{ 0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;
            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    DateTime time = DateTime.Now;
                    String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
                    String screenShotPath = Capture(_driver, fileName);
                    _test.Log(Status.Fail, "Fail");
                    _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }
          //  _test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            _extent.Flush();
            driver.Quit();
        }
        public IWebDriver GetDriver()
        {
            return _driver;
        }
        public static string Capture(IWebDriver driver, String screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            var reportPath = new Uri(actualPath).LocalPath;
            Directory.CreateDirectory(reportPath + "Reports\\" + "Screenshots");
            var finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "Reports\\Screenshots\\" + screenShotName;
            var localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
            return reportPath;
        }
    }

    //[OneTimeTearDown]
    //public void ExtentClose()
    //{
    //    extent.Flush();

    //    extent.Close();
    //}
}
