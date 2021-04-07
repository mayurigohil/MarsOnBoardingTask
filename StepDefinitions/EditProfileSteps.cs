using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinitions
{
    [Binding]
    public class EditProfileSteps
    {
        [Given(@"User logs in")]
        public void GivenUserLogsIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Edit and save Language")]
        public void WhenEditAndSaveLanguage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Edit and save skill")]
        public void WhenEditAndSaveSkill()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Updated Language is saved")]
        public void ThenUpdatedLanguageIsSaved()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Updated skill is saved")]
        public void ThenUpdatedSkillIsSaved()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
