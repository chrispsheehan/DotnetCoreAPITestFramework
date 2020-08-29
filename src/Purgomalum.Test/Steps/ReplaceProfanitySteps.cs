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

        [When(@"I process the content")] 
        public void WhenIProcessTheContent()
        {
            _purgomalumReplaceAPI.ProcessText( _message.Text);
        }
    }
}
