using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TestTask.Core.Configuration;

namespace TestTask.Core.UI.Hooks
{
    public class DriverManager
    {
        private WebDriverWait _browserWait;

        private readonly string _mainWindowHandler;

        public IWebDriver Driver;

        public IWebDriver Browser
        {
            get
            {
                if (Driver == null)
                {
                    StartBrowser(BrowserTypes.Chrome);
                }
                return Driver;
            }
            private set
            {
                Driver = value;
            }
        }

        public WebDriverWait BrowserWait
        {
            get
            {
                if (_browserWait == null || Driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }

                return _browserWait;
            }
            private set
            {
                _browserWait = value;
            }
        }

        public IWebDriver StartBrowser(BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeOut = 30)
        {
            switch (browserType)
            {
                case BrowserTypes.Firefox:
                    Browser = new FirefoxDriver();
                    break;
                case BrowserTypes.Chrome:
                    Browser = new ChromeDriver();
                    break;
                default:
                    break;
            }
            Browser.Manage().Cookies.DeleteAllCookies();
            Browser.Manage().Window.Maximize();
            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(defaultTimeOut));
            return Browser;
        }

        public void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }

        public void WaitReadyState()
        {
            var ready = new Func<bool>(() => (bool)ExecuteJavaScript("return document.readyState == 'complete'"));
        }

        public void SwitchToFrame(IWebElement inlineFrame)
        {
            Browser.SwitchTo().Frame(inlineFrame);
        }

        public void SwitchToMainWindow()
        {
            Browser.SwitchTo().Window(_mainWindowHandler);
        }

        public void SwitchToDefaultContent()
        {
            Browser.SwitchTo().DefaultContent();
        }

        public IEnumerable<IWebElement> FindElements(By selector)
        {
            return Browser.FindElements(selector);
        }

        public Screenshot GetScreenshot()
        {
            WaitReadyState();

            return ((ITakesScreenshot)Browser).GetScreenshot();
        }

        public void ResizeWindow(int width, int height)
        {
            ExecuteJavaScript(string.Format("window.resizeTo({0}, {1});", width, height));
        }

        public void NavigateBack()
        {
            Browser.Navigate().Back();
        }

        public void Refresh()
        {
            Browser.Navigate().Refresh();
        }

        public object ExecuteJavaScript(string javaScript, params object[] args)
        {
            var javaScriptExecutor = (IJavaScriptExecutor)Browser;

            return javaScriptExecutor.ExecuteScript(javaScript, args);
        }

        public void KeyDown(string key)
        {
            new Actions(Browser).KeyDown(key);
        }

        public void KeyUp(string key)
        {
            new Actions(Browser).KeyUp(key);
        }

        public void AlertAccept()
        {
            Thread.Sleep(2000);
            Browser.SwitchTo().Alert().Accept();
            Browser.SwitchTo().DefaultContent();
        }
    }
}