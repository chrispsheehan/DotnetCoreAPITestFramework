using TechTalk.SpecFlow;
using Object;
using Purgomalum.Service;

namespace StepDefinitions
{
    [Binding]
    public class ReceivedMessageSteps
    {
        private readonly Message _message;
        private readonly PurgomalumAPI _purgomalumAPI;

        public ReceivedMessageSteps(Message message, PurgomalumAPI purgomalumAPI)
        {
           _message = message;

           _purgomalumAPI = purgomalumAPI;
        }

        [When(@"I receive an incomming text of (.*)")]
        public void WhenIReceiveAnIncommingTextOf(string text)
        {
            _purgomalumAPI.SetTextToBeProcessed(text);

            _message.Text = text;
        }
    }
}
