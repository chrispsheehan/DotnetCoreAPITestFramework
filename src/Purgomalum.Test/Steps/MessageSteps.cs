using TechTalk.SpecFlow;
using Object;
using Purgomalum.Service;

namespace StepDefinitions
{
    [Binding]
    public class MessageSteps
    {
        private readonly Message _message;
        private readonly PurgomalumAPI _purgomalumAPI;

        public MessageSteps(Message message, PurgomalumAPI purgomalumAPI)
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
