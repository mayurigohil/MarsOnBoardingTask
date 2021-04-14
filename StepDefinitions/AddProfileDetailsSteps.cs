using MarsOnboardingTask.Pages;
using MarsOnboardingTask.Utility;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinitions
{
    [Binding]
    class AddProfileDetailsSteps : CommonDriver

    {
       
        [Given(@"User is logged in to Mars")]
        public void GivenUserIsLoggedInToMars()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
        }


        [When(@"Add Profile description")]
        public void WhenAddProfileDescription()
        {
            ProfilePage obj5 = new ProfilePage();
            obj5.AddDesCriptionDetails(driver);

        }

        [When(@"Add New Language")]
        public void WhenAddNewLanguage()
        {
            ProfilePage obj6 = new ProfilePage();
            obj6.AddLanguageDetails(driver);
        }

        [When(@"Add New skill")]
        public void WhenAddNewSkill()
        {
            ProfilePage obj7 = new ProfilePage();
            obj7.AddSkillDetails(driver);
        }

        [When(@"Add New Education")]
        public void WhenAddNewEducation()
        {
            ProfilePage obj8 = new ProfilePage();
            obj8.EducationDetails(driver);
        }

        [When(@"Add New Certification")]
        public void WhenAddNewCertification()
        {
            ProfilePage obj7 = new ProfilePage();
            obj7.CertificationDetails(driver);
        }

        [Then(@"The details should be saved")]
        public void ThenTheDetailsShouldBeSaved()
        {
            ProfilePage obj7 = new ProfilePage();
            obj7.ValidateAddDesCriptionDetails(driver);

        }

        [Then(@"New Language is saved")]
        public void ThenNewLanguageIsSaved()
        {
            ProfilePage obj7 = new ProfilePage();
            obj7.ValidateAddLanguageDetails(driver);
        }

        [Then(@"New skill is saved")]
        public void ThenNewSkillIsSaved()
        {
            ProfilePage obj7 = new ProfilePage();
            obj7.ValidateAddSkillDetails(driver);
        }

        [Then(@"New Education is saved")]
        public void ThenNewEducationIsSaved()
        {
            ProfilePage obj7 = new ProfilePage();
            obj7.ValidateEducationDetails(driver);
        }

        [Then(@"New Certification is saved")]
        public void ThenNewCertificationIsSaved()
        {
            ProfilePage obj7 = new ProfilePage();
            obj7.ValidateCertificationDetails(driver);
        }

        [AfterScenario]
        public void ClosseBrowser()

        {
            driver.Quit();
        }
    }
}
