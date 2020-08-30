using TechTalk.SpecFlow;
using BoDi;
using NLog;

namespace Hooks
{
    [Binding]
    public class LogHooks
    {
        private const string nlogConfigPath = "nlog.config";

        [BeforeTestRun]
        public static void BeforeTestRun(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(LogManager.LoadConfiguration(nlogConfigPath).GetCurrentClassLogger());
        }

        [BeforeFeature]
        public static void BeforeFeature(Logger log, FeatureContext featureContext)
        {
            log.Info($"Starting Feature: {featureContext.FeatureInfo.Title}");
        }

        [BeforeScenario]
        public void BeforeScenario(Logger log, ScenarioContext scenarioContext)
        {
            log.Info($"Starting Scenario: {scenarioContext.ScenarioInfo.Title}");
        }

        [AfterScenario]
        public void AfterScenario(Logger log, ScenarioContext scenarioContext)
        {
            log.Info($"Finishing Scenario: {scenarioContext.ScenarioInfo.Title}");
        }

        [AfterFeature]
        public static void AfterFeature(Logger log, FeatureContext featureContext)
        {
            log.Info($"Finishing Feature: {featureContext.FeatureInfo.Title}");
        }
    }
}