using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestTask.Core.UI.Pages.Home;

namespace TestTask.Core.UI.Steps
{
    [Binding]
    public sealed class HomeValidationSteps
    {
        private readonly IWebDriver driver;
        private readonly ScenarioContext scenarioContex;

        public HomeValidationSteps(IWebDriver driver, ScenarioContext scenarioContex)
        {
            this.driver = driver;
            this.scenarioContex = scenarioContex;
        }

        [Then(@"greeting message should be correct for different times of the day")]
        public void ThenGreetingMessageShoouldBeCorrectForDifferentTimesOfTheDay()
        {
            var homePage = new HomePage(driver);
            var hours = DateTime.Now.Hour;
            string? expectedGreeting;
            if (hours > 23 || hours < 12)
            {
                expectedGreeting = "утро";

            }
            else if (hours > 11 && hours < 18)
            {
                expectedGreeting = "день";
            }
            else
            {
                expectedGreeting = "вечер";
            }
            homePage.Map.GreetingMessage.Text.Should().Contain(expectedGreeting);
            Thread.Sleep(5000);
        }

        [Then(@"the Visitor should( | not )be logged in system")]
        public void ThenTheVisitorShouldBeLoggedInSystem(string condition)
        {
            Thread.Sleep(5000); //to test parralize
        }

        [Then(@"the '(.*)' (.*) should be on page")]
        public void ThenTheButtonShouldBeOnPage(string elementName, string element)
        {
            switch (element)
            {
                case "button": break;
            }
        }
    }
}
