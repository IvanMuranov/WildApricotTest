namespace WildApricotTest.Environment.Hooks
{
    using BoDi;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    using TechTalk.SpecFlow;

    [Binding]
    class InitializationHook
    {
        private readonly IObjectContainer objectContainer;

        private IWebDriver driver;

        public InitializationHook(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }
        
        //Initialization of browser before scenario
        [BeforeScenario]
        public void Initialize()
        {
            //TODO make configurable, for now it's only Chrome in testing purpose
            this.SelectBrowser(BrowserType.Chrome);
        }

        //CleanUp after every scenario
        [AfterScenario]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        //Select browser
        internal void SelectBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    ChromeOptions option = new ChromeOptions();
                    this.driver = new ChromeDriver(option);
                    this.objectContainer.RegisterInstanceAs<IWebDriver>(this.driver);
                    break;
                //For the test purpose only Chrome is supported for now
                case BrowserType.Firefox:
                    break;
                case BrowserType.Ie:
                    break;
                default:
                    break;
            }
        }
    }

    //Browsers
    internal enum BrowserType
    {
        Chrome,
        Firefox,
        Ie
    }
}

