using TechTalk.SpecFlow;
using Drivers;
using System;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class APIServiceSteps
    {
        private readonly APIDriver _driver;

        public APIServiceSteps(APIDriver driver)
        {
            _driver = driver;
        }

        [Given(@"The profanity removing API is available")]
        public void GivenTheProfanityRemovingAPIIsAvailable()
        {
            var isAvailable = _driver.IsAPIAvailable();

            Assert.True(isAvailable);
        }

        [Given(@"I am using the contains profanity service")]
        public void GivenIAmUsingTheContainsProfanityService()
        {
            _driver.SetService("");
        }

        [Given(@"I am using the profanity character replacement service")]
        public void GivenIAmUsingTheProfanityCharacterReplacementService()
        {
            _driver.SetService("");
        }

        [Given(@"I am using the profanity string replacement service")]
        public void GivenIAmUsingTheProfanityStringReplacementService()
        {
            _driver.SetService("");
        }

        [When(@"I process the content")]
        public void WhenIProcessTheContent()
        {

        }

        [When(@"I receive an incomming text of (.*)")]
        public void WhenIReceiveAnIncommingTextOf(string text)
        {
            Console.WriteLine(text);
        }
    }
}
