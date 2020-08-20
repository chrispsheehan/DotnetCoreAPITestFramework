using TechTalk.SpecFlow;
using Drivers;
using System;

namespace StepDefinitions
{
    [Binding]
    public class AssertContentSteps
    {
        private readonly Driver _driver;

        public AssertContentSteps(Driver driver)
        {
            _driver = driver;
        }

        [Then(@"no asterisks are added")]
        public void ThenNoAsterisksAreAdded()
        {

        }

        [Then(@"replaced with the corresponding amount of asterisks")]
        public void ThenReplacedWithTheCorrespondingAmountOfAsterisks()
        {

        }        

        [Then(@"replaced profanity with the corresponding amount of (.*)")]
        public void ThenReplacedProfanityWithTheCorrespondingAmountOf(string character)
        {
            Console.WriteLine(character);
        }

        [Then(@"the string of (.*) is added")]
        public void ThenTheStringOfIsAdded(string replacementString)
        {
            Console.WriteLine(replacementString);
        }

        [Then(@"the (.*) remains unchanged")]
        public void ThenTheTextRemainsUnchanged(string text)
        {
            Console.WriteLine(text);
        }        

        [Then(@"profanitys are found")]
        public void ThenProfanitysAreFound()
        {

        }

        [Then(@"no profanitys are found")]
        public void ThenNoProfanitysAreFound()
        {

        }        
    }
}
