using TechTalk.SpecFlow;
using Drivers;
using System;

namespace StepDefinitions
{
    [Binding]
    public class Steps
    {
        private readonly Driver _driver;

        public Steps(Driver driver)
        {
            _driver = driver;
        }
                               
    }
}
