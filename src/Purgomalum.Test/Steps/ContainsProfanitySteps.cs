using TechTalk.SpecFlow;
using Drivers;
using Xunit;
using Object;

namespace StepDefinitions
{
    [Binding]
    public class ContainsProfanitySteps
    {
        private readonly Message _message;
        private readonly PurgomalumContainsAPI _purgomalumContainsAPI;

        public ContainsProfanitySteps(Message message, PurgomalumContainsAPI purgomalumContainsAPI)
        {
            _message = message;

            _purgomalumContainsAPI = purgomalumContainsAPI;
        }

        [Given(@"I am using the contains profanity service")]
        public void GivenIAmUsingTheContainsProfanityService()
        {
            _purgomalumContainsAPI.SetContainsService();
        }

        [When(@"I check the content for profanitys")]
        public void WhenICheckTheContentForProfanitys()
        {
            _purgomalumContainsAPI.ProcessText(_message.Text);
        }
    }
}
