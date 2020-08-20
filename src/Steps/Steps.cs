using TechTalk.SpecFlow;
using src.Drivers;

namespace src.StepDefinitions
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
        
        [When(@"I receive an incomming text of hallow")]
        public void WhenIReceiveAnIncommingTextOfHallow()
        {

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

        [When(@"I receive an incomming text of fuck")]
        public void WhenIReceiveAnIncommingTextOfFuck()
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
    }
}
