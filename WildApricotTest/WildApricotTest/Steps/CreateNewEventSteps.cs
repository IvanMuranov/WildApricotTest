namespace WildApricotTest.Steps
{
    using OpenQA.Selenium;

    using TechTalk.SpecFlow;
    using Pages;

    [Binding]
    public class CreateNewEventSteps
    {
        private readonly IWebDriver driver;

        public CreateNewEventSteps(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Given(@"I create new event on Event list")]
        [When(@"I create new event on Event list")]
        public void GivenICreateNewEventOnEventList()
        {
            AdminViewPageObject page = new AdminViewPageObject(this.driver);

            page.ClickCreateNewEventBtn();
        }

        [Given(@"I create new (simple|advanced) event")]
        [When(@"I create new (simple|advanced) event")]
        public void GivenIHaveNavigatedToAdminInterfacePage(string eventType)
        {
            AdminViewPageObject page = new AdminViewPageObject(this.driver);

            page.ClickCreateNewEventBtn();
        }
    }
}
