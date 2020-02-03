using System;
using TechTalk.SpecFlow;

namespace Project_2.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
      
        [Given(@"I Navigate to giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"And I click on Create Account")]
        public void GivenAndIClickOnCreateAccount()
        {
            //ScenarioContext.Current.Pending();
        }


        [When(@"I Enter my firstname")]
        public void WhenIEnterMyFirstname()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Lastname")]
        public void WhenIEnterLastname()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"Ienter my Email address")]
        public void WhenIenterMyEmailAddress()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I Enter my password")]
        public void WhenIEnterMyPassword()
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I confirm my Password")]
        public void WhenIConfirmMyPassword()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I Select Country")]
        public void WhenISelectCountry()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I Click Captcha")]
        public void WhenIClickCaptcha()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I Click register")]
        public void WhenIClickRegister()
        {
            //ScenarioContext.Current.Pending();
        }


        [Then(@"I am registered")]
        public void ThenIAmRegistered()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I Enter my firstname ""(.*)""")]
        public void WhenIEnterMyFirstname(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter Lastname ""(.*)""")]
        public void WhenIEnterLastname(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"Ienter my Email address ""(.*)""")]
        public void WhenIenterMyEmailAddress(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I Enter my password ""(.*)""")]
        public void WhenIEnterMyPassword(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I am not registered")]
        public void ThenIAmNotRegistered()
        {
            //ScenarioContext.Current.Pending();
        }

    }
}
