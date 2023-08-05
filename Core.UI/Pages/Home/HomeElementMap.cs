using OpenQA.Selenium;

namespace TestTask.Core.UI.Pages.Home
{
    public class HomeElementMap : BasePageElementMap
    {
        private readonly IWebDriver _driver;

        public HomeElementMap(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public IWebElement Logo
        {
            get
            {
                return Driver.FindElement(By.ClassName("logo-bar"));
            }
        }

        public IWebElement GreetingMessage
        {
            get
            {
                return Driver.FindElement(By.ClassName("title"));
            }
        }
    }
}
