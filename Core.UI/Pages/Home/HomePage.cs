using OpenQA.Selenium;
using TestTask.Core.Configuration;

namespace TestTask.Core.UI.Pages.Home
{
    public class HomePage : BasePage<HomeElementMap>, IHomePage
    {
        public HomePage(IWebDriver driver) : base(driver, new HomeElementMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return TestRunningSettings.Get("BaseUiUrl");
            }
        }

        public bool IsLogoPresent()
        {
            return Map.Logo.Displayed;
        }
    }
}
