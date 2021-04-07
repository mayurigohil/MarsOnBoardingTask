using MarsOnboardingTask.Pages;
using MarsOnboardingTask.Utility;
using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinitions
{
    [Binding]
     class EditProfileSteps : CommonDriver
    {
        [Given(@"User logs in")]
        public void GivenUserLogsIn()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
        }
        
        [When(@"Edit and save Language")]
        public void WhenEditAndSaveLanguage()
        {
            ProfilePage obj9 = new ProfilePage();
            obj9.EditLanguageDetails(driver);
        }
        
        [When(@"Edit and save skill")]
        public void WhenEditAndSaveSkill()
        {
            ProfilePage obj11 = new ProfilePage();
            obj11.EditSkillDetails(driver);
        }
        
        //[When(@"Edit and save Education")]
        //public void WhenEditAndSaveEducation()
        //{
            
        //}
        
        //[When(@"Edit and save Certification")]
        //public void WhenEditAndSaveCertification()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        [Then(@"Updated Language is saved")]
        public void ThenUpdatedLanguageIsSaved()
        {
            ProfilePage obj9 = new ProfilePage();
            obj9.ValidateEditLanguageDetails(driver);
        }
        
        [Then(@"Updated skill is saved")]
        public void ThenUpdatedSkillIsSaved()
        {
            ProfilePage obj11 = new ProfilePage();
            obj11.ValidateEditSkillDetails(driver);
        }
        
        //[Then(@"Updated Education is saved")]
        //public void ThenUpdatedEducationIsSaved()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"Updated Certification is saved")]
        //public void ThenUpdatedCertificationIsSaved()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
