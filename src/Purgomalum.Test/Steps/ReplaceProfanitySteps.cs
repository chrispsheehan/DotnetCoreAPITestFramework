using TechTalk.SpecFlow;
using Object;
using Purgomalum.Service;

namespace StepDefinitions
{
    [Binding]
    public class ReplaceProfanitySteps
    {
        private readonly Message _message;
        private readonly PurgomalumReplaceAPI _purgomalumReplaceAPI;

        public ReplaceProfanitySteps(Message message, PurgomalumReplaceAPI purgomalumReplaceAPI)
        {
            _message = message;

            _purgomalumReplaceAPI = purgomalumReplaceAPI;
        }

        [When(@"I replace profanitys in the content")] 
        public void WhenIReplaceProfanitysInTheContent()
        {
            _purgomalumReplaceAPI.ProcessText(_message.Text);
        }
    }
}
