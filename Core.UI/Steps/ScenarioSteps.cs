using TechTalk.SpecFlow;

namespace TestTask.Core.UI.Steps
{
    [Binding]
    public abstract class ScenarioSteps
    {
        protected ScenarioSteps(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            FeatureContext = featureContext;
            ScenarioContext = scenarioContext;
        }

        public FeatureContext FeatureContext { get; }
        public ScenarioContext ScenarioContext { get; }
    }
}
