using TechTalk.SpecFlow;
using Drivers;
using Xunit;
using Object;

namespace StepDefinitions
{
    [Binding]
    public class MessageSteps
    {
        private readonly Message _message;

        public MessageSteps(Message message)
        {
           _message = message;
        }

        [When(@"I receive an incomming text of (.*)")]
        public void WhenIReceiveAnIncommingTextOf(string text)
        {
            _message.Text = text;
        }
    }
}
