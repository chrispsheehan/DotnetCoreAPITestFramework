using TechTalk.SpecFlow;
using Object;
using Purgomalum.Service;

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

        [When(@"I check the content for profanitys")]
        public void WhenICheckTheContentForProfanitys()
        {
            _purgomalumContainsAPI.ProcessText(_message.Text);
        }
    }
}
