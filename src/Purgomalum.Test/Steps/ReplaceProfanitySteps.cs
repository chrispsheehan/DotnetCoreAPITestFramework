using TechTalk.SpecFlow;
using Drivers;
using Object;

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

        [When(@"I process the content")] ///////////////////////////////////////////////////////////////
        public void WhenIProcessTheContent()
        {
            _purgomalumReplaceAPI.ProcessText( _message.Text);
        }

        [Given(@"I am using the profanity character replacement service with (.*)")]
        public void GivenIAmUsingTheProfanityCharacterReplacementServiceWith(string replacementCharacter)
        {
            _purgomalumReplaceAPI.SetCharacterReplacementService(replacementCharacter);
        }

        [Given(@"I am using the profanity string replacement service with (.*)")]
        public void GivenIAmUsingTheProfanityStringReplacementServiceWith(string replacementString)
        {
            _purgomalumReplaceAPI.SetStringReplacementService(replacementString);
        }        
    }
}
