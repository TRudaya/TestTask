using OpenQA.Selenium;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace TestTask.Core.UI.Hooks
{
    [Binding]
    public class Hooks
    {
        public IWebDriver Driver;

        public Hooks(IWebDriver driver)
        {
            Driver = driver;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Process.GetProcessesByName("chromedriver").ToList().ForEach(x => x.Kill());
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
