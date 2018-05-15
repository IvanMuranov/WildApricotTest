namespace WildApricotTest.Steps
{
    using System.Configuration;

    using NUnit.Framework;

    using OpenQA.Selenium;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    using WildApricotTest.Pages;
    using WildApricotTest.Pages.AdminViewPages;

    [Binding]
    public class NavigationSteps
    {
        private readonly IWebDriver driver;

        private readonly AdminViewPageObject adminViewPageObject;

        private readonly OrganizationHomePageObject organizationHomePageObject;

        public NavigationSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.organizationHomePageObject = new OrganizationHomePageObject(this.driver);
            this.adminViewPageObject = new AdminViewPageObject(this.driver);
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

            this.organizationHomePageObject.EnterUserNameAndPassword(userName, password);
        }

        [Given(@"I click login on application web page")]
        [When(@"I click login on application web page")]
        public void GivenIClickLogin()
        {
            this.organizationHomePageObject.ClickLogin();
        }

        [Given(@"I switch to admin view from application web page")]
        [When(@"I switch to admin view from application web page")]
        public void GivenISwitchToAdminView()
        {
            this.organizationHomePageObject.SwithToAdminViewPage();
        }

        [Given(@"I navigate to Events menu on admin view page")]
        [When(@"I navigate to Events menu on admin view page")]
        public void GiventINavigateToEventsMenuOnAdminViewPage()
        {
            this.adminViewPageObject.OpenAdminMenuOption(AdminMenuOptions.Events);
        }
    }
}
