using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestTask.Core.Configuration;
using TestTask.Core.UI.Pages.Home;

namespace TestTask.Core.UI.Steps
{
    [Binding]
    public sealed class NavigationSteps
    {
        private readonly IWebDriver driver;
        private readonly ScenarioContext scenarioContex;

        public NavigationSteps(IWebDriver driver, ScenarioContext scenarioContex)
        {
            this.driver = driver;
            this.scenarioContex = scenarioContex;
        }

        [Given(@"the Vsitor opens '(.*)' page")]
        public void GivenTheVsitorOpensPage(string page)
        {
            var homePage = new HomePage(driver);
            if (page.Contains("Home"))
                homePage.Open();
        }

        [Then(@"'(.*)' logo is displayed to The Visitor")]
        public void ThenLogoIsDisplayedToTheVisitor(string p0)
        {
            var homePage = new HomePage(driver);
            homePage.IsLogoPresent();
        }

        [When(@"User should scroll to element named '(.*)'")]
        public void WhenUserShouldScrollToElementNamed(string p0)
        {
            var homePage = new HomePage(driver);
        }

        [When(@"'(.*)' should( |not )be present on page")]
        public void WhenShouldBePresentOnPage(string p0)
        {
            var homePage = new HomePage(driver);
        }

        [Given(@"The Visitor clicks on '(.*)' button")]
        public void GivenTheVisitorClicksOnButton(string buttonName)
        {
        }
    }
}
