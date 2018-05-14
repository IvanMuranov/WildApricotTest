namespace WildApricotTest.Steps
{
    using System.Configuration;

    using NUnit.Framework;

    using OpenQA.Selenium;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    using WildApricotTest.Pages;

    [Binding]
    public class NavigationSteps
    {
        private readonly IWebDriver driver;

        public NavigationSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I navigate to application web page")]
        [When(@"I navigate to application web page")]
        public void GivenINavigateToApplicationWebPage()
        {
            this.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("OrganizationUrl"));
        }

        [Given(@"I enter username and password on application web page")]
        [When(@"I enter username and password on application web page")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            string userName = data.UserName;
            string password = data.Password;

            OrganizationHomePageObject page = new OrganizationHomePageObject(this.driver);

            page.EnterUserNameAndPassword(userName, password);
        }

        [Given(@"I click login on application web page")]
        [When(@"I click login on application web page")]
        public void GivenIClickLogin()
        {
            OrganizationHomePageObject page = new OrganizationHomePageObject(this.driver);

            page.ClickLogin();
        }

        [Given(@"I switch to admin view from application web page")]
        [When(@"I switch to admin view from application web page")]
        public void GivenISwitchToAdminView()
        {
            OrganizationHomePageObject page = new OrganizationHomePageObject(this.driver);

            page.SwithToAdminViewPage();
        }

        [Given(@"I navigate to Events menu on admin view page")]
        [When(@"I navigate to Events menu on admin view page")]
        public void GiventINavigateToEventsMenuOnAdminViewPage()
        {
            AdminViewPageObject page = new AdminViewPageObject(this.driver);

            page.OpenAdminMenuOption(AdminMenuOptions.Events);
        }
    }
}
