using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestTask.Core.UI.Extensions;

namespace TestTask.Core.UI.Steps
{
    [Binding]
    public sealed class AuthorizationSteps
    {
        private readonly IWebDriver driver;
        private readonly ScenarioContext scenarioContex;

        public AuthorizationSteps(IWebDriver driver, ScenarioContext scenarioContex)
        {
            this.driver = driver;
            this.scenarioContex = scenarioContex;
        }

        [When(@"the Visitor has logged in with credentials")]
        public void WhenTheVisitorHasLoggedInWithCredentials(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
        }
    }
}
