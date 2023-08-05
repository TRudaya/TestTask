using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestTask.Core.UI.Hooks
{
    [Binding]
    public class DriverSetup
    {
        private readonly ScenarioContext ScenarioContext;

        private readonly IObjectContainer ObjectContainer;

        public IWebDriver Driver;

        public DriverSetup(IObjectContainer objectContainer) => this.ObjectContainer = objectContainer;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new DriverManager().Browser;
            ObjectContainer.RegisterInstanceAs(Driver);
        }
    }
}
