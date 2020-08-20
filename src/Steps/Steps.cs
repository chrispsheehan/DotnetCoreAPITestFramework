using TechTalk.SpecFlow;
using Drivers;
using System;

namespace StepDefinitions
{
    [Binding]
    public class Steps
    {
        private readonly Driver _driver;

        public Steps(Driver driver)
        {
            _driver = driver;
        }

        [Given(@"The profanity removing API is available")]
        public void GivenTheProfanityRemovingAPIIsAvailable()
        {

        }
        
        [When(@"I receive an incomming text of (.*)")]
        public void WhenIReceiveAnIncommingTextOf(string text)
        {
            Console.WriteLine(text);
        }
        
        [When(@"run it through the profanity API")]
        public void WhenRunItThroughTheProfanityAPI()
        {

        }
        
        [Then(@"no profanitys are removed")]
        public void ThenNoProfanitysAreRemoved()
        {

        }
        
        [Then(@"no asterisks are added")]
        public void ThenNoAsterisksAreAdded()
        {

        }
        
        [Then(@"profanitys are removed")]
        public void ThenProfanitysAreRemoved()
        {

        }
        
        [Then(@"replaced with the corresponding amount of asterisks")]
        public void ThenReplacedWithTheCorrespondingAmountOfAsterisks()
        {

        }

        [Then(@"profanitys are found")]
        public void ThenProfanitysAreFound()
        {

        }

        [Then(@"no profanitys are found")]
        public void ThenNoProfanitysAreFound()
        {

        }                                
    }
}
