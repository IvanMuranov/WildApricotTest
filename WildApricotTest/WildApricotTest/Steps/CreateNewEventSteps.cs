namespace WildApricotTest.Steps
{
    using OpenQA.Selenium;

    using TechTalk.SpecFlow;
    using Pages;

    using WildApricotTest.Pages.AdminViewPages;

    [Binding]
    public class CreateNewEventSteps
    {
        private readonly IWebDriver driver;

        private readonly CreateNewSimpleEvent createNewSimpleEventFrame;

        private readonly AdminViewPageObject adminViewPageObject;

        public CreateNewEventSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.createNewSimpleEventFrame = new CreateNewSimpleEvent(this.driver);
            this.adminViewPageObject = new AdminViewPageObject(this.driver);
        }

        [Given(@"I create new (simple|advanced) event on Event list")]
        [When(@"I create new (simple|advanced) event on Event list")]
        public void GivenICreateNewEventOnEventList(string eventType)
        {
            this.adminViewPageObject.CreateNewEvent(eventType);
        }

        [Given(@"I enter title '([^']+)' for new simple event")]
        [When(@"I enter title '([^']+)' for new simple event")]
        public void GivenIEnterTitleForNewSimpleEvent(string title)
        {
            this.createNewSimpleEventFrame.EnterTitle(title);
        }

        [Given(@"I enter tags '([^']+)' for new simple event")]
        [When(@"I enter tags '([^']+)' for new simple event")]
        public void GivenIEnterTagsForNewSimpleEvent(string tags)
        {
            this.createNewSimpleEventFrame.EnterTags(tags);
        }

        [Given(@"I enter location '([^']+)' for new simple event")]
        [When(@"I enter location '([^']+)' for new simple event")]
        public void GivenIEnterLocationForNewSimpleEvent(string location)
        {
            this.createNewSimpleEventFrame.EnterLocation(location);
        }

        [Given(@"I use time zone default organization settings for new simple event")]
        [When(@"I use time zone default organization settings for new simple event")]
        public void GivenIUseDefaultSettingsForTomeZoneForNewSimpleEvent()
        {
            this.createNewSimpleEventFrame.UseDefaultOrganizationSettingsForTimeZone();
        }

        [Given(@"I enter start date '([^']+)' for new simple event")]
        [When(@"I enter start date '([^']+)' for new simple event")]
        public void GivenIEnterStartDateForNewSimpleEvent(string startDate)
        {
            this.createNewSimpleEventFrame.EnterStartDate(startDate);
        }

        [Given(@"I enter end date '([^']+)' for new simple event")]
        [When(@"I enter end date '([^']+)' for new simple event")]
        public void GivenIEnterEndtDateForNewSimpleEvent(string endDate)
        {
            this.createNewSimpleEventFrame.EnterEndDate(endDate);
        }

        [Given(@"I enter start time '(\d+)' for new simple event")]
        [When(@"I enter start time '(\d+)' for new simple event")]
        public void GivenIEnterStartTimeForNewSimpleEvent(int startTime)
        {
            this.createNewSimpleEventFrame.EnterStartTime(startTime);
        }

        [Given(@"I enter end time '(\d+)' for new simple event")]
        [When(@"I enter end time '(\d+)' for new simple event")]
        public void GivenIEnterEndTimeForNewSimpleEvent(int endTime)
        {
            this.createNewSimpleEventFrame.EnterEndTime(endTime);
        }

        [Given(@"I choose (enabled|disabled) status for new simple event")]
        [When(@"I choose (enabled|disabled) status for new simple event")]
        public void GivenIChooseStatusForNewSimpleEvent(string status)
        {
            switch (status)
            {
                case "enabled":
                    this.createNewSimpleEventFrame.ChooseStatus(enabled: true);
                    break;
                case "disabled":
                    this.createNewSimpleEventFrame.ChooseStatus(enabled: false);
                    break;
                default:
                    break;
            }
        }

        [Given(@"I enter available period from '([^']+)' for new simple event")]
        [When(@"I enter available period from '([^']+)' for new simple event")]
        public void GivenIEnterAvailablePeriodFromForNewSimpleEvent(string from)
        {
            this.createNewSimpleEventFrame.EnterAvailableFromPeriod(from);
        }

        [Given(@"I enter available period through '([^']+)' for new simple event")]
        [When(@"I enter available period through '([^']+)' for new simple event")]
        public void GivenIEnterAvailablePeriodThroughForNewSimpleEvent(string through)
        {
            this.createNewSimpleEventFrame.EnterAvailableThroughPeriod(through);
        }

        [Given(@"I allow guest registrations for new simple event")]
        [When(@"I allow guest registrations for new simple event")]
        public void GivenIAllowGuestRegistrationsForNewSimpleEvent()
        {
            this.createNewSimpleEventFrame.AllowGuestRegistration();
        }

        [Given(@"I disallow guest registrations for new simple event")]
        [When(@"I disallow guest registrations for new simple event")]
        public void GivenIDisallowGuestRegistrationsForNewSimpleEvent()
        {
            this.createNewSimpleEventFrame.DisallowGuestRegistration();
        }

        [Given(@"I limit guests to '(\d+)' for new simple event")]
        [When(@"I limit guests to '(\d+)' for new simple event")]
        public void GivenILimitGuestsToForNewSimpleEvent(int guestsCount)
        {
            this.createNewSimpleEventFrame.EnterGuestsLimit(guestsCount);
        }

        [Given(@"I (do not |)allow cancellation by registrants for new simple event")]
        [When(@"I (do not |)allow cancellation by registrants for new simple event")]
        public void GivenIAllowCancellationByRegistrantsForNewSimpleEvent(string doNotAllow)
        {
            this.createNewSimpleEventFrame.ChooseCancellationStatus(string.IsNullOrEmpty(doNotAllow));
        }

        [Given(@"I choose (not |)to show registrations who want to be listed to (everyone|members only) for new simple event")]
        [When(@"I choose (not |)to show registrations who want to be listed to (everyone|members only) for new simple event")]
        public void GivenIChooseToShowRegistrantsWhoWantToBeListedForNewSimpleEvent(string notToShow, string whom)
        {
            if (string.IsNullOrEmpty(notToShow))
            {
                switch (whom)
                {
                    case "everyone":
                        this.createNewSimpleEventFrame.ShowRegistrants(toEveryone: true);
                        break;
                    case "members only":
                        this.createNewSimpleEventFrame.ShowRegistrants(toEveryone: false);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                this.createNewSimpleEventFrame.DoNotShowRegistrants();
            }
        }

        [Given(@"I enter description '([^']+)' for new simple event")]
        [When(@"I enter description '([^']+)' for new simple event")]
        public void GivenIEntedDescriptionForNewSimpleEvent(string description)
        {
            this.createNewSimpleEventFrame.EnterDescription(description);
        }
    }
}
