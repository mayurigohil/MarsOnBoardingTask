using MarsOnboardingTask.Pages;
using MarsOnboardingTask.Utility;
using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinitions
{
    [Binding]
    class DeleteProfileSteps:CommonDriver
    {
        [Given(@"User logged in to Mars")]
        public void GivenUserLoggedInToMars()
        {
            Login Obj1 = new Login();
            Obj1.LoginPage(driver);
            
        }

        [Then(@"Deletes the Language")]
        public void ThenDeletesTheLanguage()
        {
            ProfilePage obj10 = new ProfilePage();
            obj10.DeleteLanguageDetails(driver);
        }

        [Then(@"Deletes the Skill")]
        public void ThenDeletesTheSkill()
        {
            ProfilePage obj11 = new ProfilePage();
            obj11.DeleteSkillDetails(driver);
        }


    }
}
