using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinitions
{
    [Binding]
    public class DeleteProfileSteps
    {
        [Given(@"User logged in to Mars")]
        public void GivenUserLoggedInToMars()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Delete Language")]
        public void WhenDeleteLanguage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Delete skill")]
        public void WhenDeleteSkill()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Language is deleted")]
        public void ThenLanguageIsDeleted()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"skill is deleted")]
        public void ThenSkillIsDeleted()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
