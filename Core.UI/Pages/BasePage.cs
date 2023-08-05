using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace TestTask.Core.UI.Pages
{
    public abstract class BasePage<TMap>
        where TMap : BasePageElementMap
    {
        protected IWebDriver Driver;
        protected WebDriverWait DriverWait;

        protected BasePage(IWebDriver driver, TMap map)
        {
            Driver = driver;
            Map = map;
            DriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        }

        public abstract string Url { get; }

        internal TMap Map { get; private set; }

        public virtual void Open(string part = "")
        {
            Driver.Navigate().GoToUrl(string.Concat(Url, part));
        }
    }
}
