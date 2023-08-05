using OpenQA.Selenium;

namespace TestTask.Core.UI.Pages
{
    public abstract class BasePageElementMap
    {
        protected IWebDriver Driver;

        protected BasePageElementMap(IWebDriver driver)
        {
            Driver = driver;
        }

        public void SwitchToDefault()
        {
            Driver.SwitchTo().DefaultContent();
        }
    }
}
