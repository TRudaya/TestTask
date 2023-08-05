using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestTask.Core.UI.Steps
{
    [Binding]
    public sealed class RegisterValidationSteps
    {
        private readonly IWebDriver driver;
        private readonly ScenarioContext scenarioContex;

        public RegisterValidationSteps(IWebDriver driver, ScenarioContext scenarioContex)
        {
            this.driver = driver;
            this.scenarioContex = scenarioContex;
        }

        [Then(@"the Visitor should be on Register page")]
        public void ThenTheVisitorShouldBeOnRegisterPage()
        {
        }
    }
}
