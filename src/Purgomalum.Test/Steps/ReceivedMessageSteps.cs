using TechTalk.SpecFlow;
using Purgomalum.Service;
using Purgomulum.Service.Object;

namespace StepDefinitions
{
    [Binding]
    public class ReceivedMessageSteps
    {
        private readonly Message _message;
        private readonly PurgomalumServiceBase _purgomalumServiceBase;

        public ReceivedMessageSteps(Message message, PurgomalumServiceBase purgomalumServiceBase)
        {
           _message = message;

           _purgomalumServiceBase = purgomalumServiceBase;
        }

        [When(@"I receive an incomming text of (.*)")]
        public void WhenIReceiveAnIncommingTextOf(string text)
        {
            _purgomalumServiceBase.SetTextToBeProcessed(text);

            _message.Text = text;
        }
    }
}
