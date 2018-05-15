namespace WildApricotTest.Steps
{
    using NUnit.Framework;

    using OpenQA.Selenium;

    using TechTalk.SpecFlow;

    using WildApricotTest.Pages.AdminViewPages;

    [Binding]
    public class CheckNewCreatedSimpleEventInformation
    {
        private readonly IWebDriver driver;

        private readonly CreateNewSimpleEvent createNewSimpleEventFrame;

        private readonly AdminViewPageObject adminViewPageObject;

        public CheckNewCreatedSimpleEventInformation(IWebDriver driver)
        {
            this.driver = driver;
            this.createNewSimpleEventFrame = new CreateNewSimpleEvent(this.driver);
            this.adminViewPageObject = new AdminViewPageObject(this.driver);
        }

        [Then(@"I check that created simple event have title '([^']+)'")]
        public void ThenICheckThatCreatedEventHaveTitle(string title)
        {
            Assert.AreEqual(title, this.adminViewPageObject.GetNewEventDetailsText(EventDetails.Title));
        }

        [Then(@"I check that created simple event have tags '([^']+)'")]
        public void ThenICheckThatCreatedEventHaveTags(string tags)
        {
            Assert.AreEqual(tags, this.adminViewPageObject.GetNewEventDetailsText(EventDetails.Tags));
        }

        [Then(@"I check that created simple event have location '([^']+)'")]
        public void ThenICheckThatCreatedEventHaveLocation(string location)
        {
            Assert.AreEqual(location, this.adminViewPageObject.GetNewEventDetailsText(EventDetails.Location));
        }

        [Then(@"I check that created simple event have time zone '([^']+)'")]
        public void ThenICheckThatCreatedEventHaveTimeZone(string timeZone)
        {
            Assert.AreEqual(timeZone, this.adminViewPageObject.GetNewEventDetailsText(EventDetails.TimeZone));
        }

        [Then(@"I check that created simple event have date and time '([^']+)'")]
        public void ThenICheckThatCreatedEventHaveDateAndTime(string dateTime)
        {
            Assert.AreEqual(dateTime, this.adminViewPageObject.GetNewEventDetailsText(EventDetails.DateTime));
        }

        [Then(@"I check that created simple event have (Enabled|Disable) status")]
        public void ThenICheckThatCreatedEventHaveStatus(string status)
        {
            Assert.AreEqual(status, this.adminViewPageObject.GetNewEventDetailsText(EventDetails.Status));
        }

        [Then(@"I check that created simple event have available period '([^']+)'")]
        public void ThenICheckThatCreatedEventHaveAvailablePeriod(string availablePeriod)
        {
            Assert.AreEqual(availablePeriod, this.adminViewPageObject.GetNewEventDetailsText(EventDetails.AvailablePeriod));
        }

        [Then(@"I check that created simple event have allowed guests")]
        public void ThenICheckThatCreatedEventHaveGuests()
        {
            Assert.AreEqual("Allow guest registrations", this.adminViewPageObject.GetNewEventDetailsText(EventDetails.Guests));
        }

        [Then(@"I check that created simple event have no allowed guests")]
        public void ThenICheckThatCreatedEventHaveNoGuests()
        {
            Assert.AreEqual("Not allowed", this.adminViewPageObject.GetNewEventDetailsText(EventDetails.AvailablePeriod));
        }

        [Then(@"I check that created simple event have guests limit as '([^']+)'")]
        public void ThenICheckThatCreatedEventHaveLimitGuestsTo(string guestsPerRegistrant)
        {
            Assert.AreEqual(guestsPerRegistrant, this.adminViewPageObject.GetNewEventDetailsText(EventDetails.LimitGuestsTo));
        }

        [Then(@"I check that created simple event do not allow cancellation")]
        public void ThenICheckThatCreatedEventDoNotAllowCancellation()
        {
            Assert.AreEqual("Do not allow cancellation by registrants", this.adminViewPageObject.GetNewEventDetailsText(EventDetails.Cancellation));
        }

        [Then(@"I check that created simple event will not show registrations who want to be listed")]
        public void ThenICheckThatCreatedEventWillNotBeShownToRegistrants()
        {
            Assert.IsTrue(this.adminViewPageObject.AreRegistrantsNotShown());
        }

        [Then(@"I check that error 'From and Through dates must be earlier than event end date' is displayed during the simple event creation")]
        public void ThenICheckThatThereIsAnErrorWithAvailablePeriod()
        {
            Assert.IsTrue(this.createNewSimpleEventFrame.IsRegistrationTypePeriodValidatorVisiable());
        }

        [Then(@"I check that error 'End date and time can not be earlier than start date and time' is displayed during the simple event creation")]
        public void ThenICheckThatThereIsAnErrorWithEndDate()
        {
            Assert.IsTrue(this.createNewSimpleEventFrame.IsEndDateValidatorVisiable());
        }
    }
}
