using TechTalk.SpecFlow;
using Drivers;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class APIServiceSteps
    {
        private readonly APIDriver _driver;

        private string _text;

        public APIServiceSteps(APIDriver driver)
        {
            _driver = driver;
        }

        [Given(@"The profanity removing API is available")]
        public void GivenTheProfanityRemovingAPIIsAvailable()
        {
            var isAvailable = _driver.IsUrlAvailable();

            Assert.True(isAvailable);
        }

        [Given(@"I am using the contains profanity service")]
        public void GivenIAmUsingTheContainsProfanityService()
        {
            _driver.SetService("containsprofanity");
        }

        [Given(@"I am using the profanity character replacement service")]
        public void GivenIAmUsingTheProfanityCharacterReplacementService()
        {
            _driver.SetService("json");
        }

        [Given(@"I am using the profanity character replacement service with (.*)")]
        public void GivenIAmUsingTheProfanityCharacterReplacementServiceWith(string replacementCharacter)
        {
            _driver.SetService("json");

            _driver.AddParam("fill_char", replacementCharacter);
        }

        [Given(@"I am using the profanity string replacement service with (.*)")]
        public void GivenIAmUsingTheProfanityStringReplacementServiceWith(string replacementString)
        {
            _driver.SetService("json");

            _driver.AddParam("fill_text", replacementString);
        }

        [When(@"I process the content")]
        public void WhenIProcessTheContent()
        {
            bool hasProcessed = _driver.ProcessText(_text);

            Assert.True(hasProcessed);
        }

        [When(@"I receive an incomming text of (.*)")]
        public void WhenIReceiveAnIncommingTextOf(string text)
        {
            _text = text;
        }
    }
}
