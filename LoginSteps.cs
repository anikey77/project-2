using System;
using TechTalk.SpecFlow;

namespace Project_2.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [When(@"I enter valid email ""(.*)""")]
        public void WhenIEnterValidEmail(string p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I Enter valid password ""(.*)""")]
        public void WhenIEnterValidPassword(string p0)
        {
           // ScenarioContext.Current.Pending();
        }


        [Given(@"I click on login")]
        public void GivenIClickOnLogin()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter valid email")]
        public void WhenIEnterValidEmail()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I Enter valid password")]
        public void WhenIEnterValidPassword()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be logged in\.")]
        public void ThenIShouldBeLoggedIn_()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I leave both email and password blank")]
        public void WhenILeaveBothEmailAndPasswordBlank()
        {
            //ScenarioContext.Current.Pending();
        }
        [Then(@"I should not be logged in")]
        public void ThenIShouldNotBeLoggedIn()
        {
            //ScenarioContext.Current.Pending();
        }
        


        [When(@"I enter Wrong password")]
        public void WhenIEnterWrongPassword()
        {
         // ScenarioContext.Current.Pending();
        }


    }
}
