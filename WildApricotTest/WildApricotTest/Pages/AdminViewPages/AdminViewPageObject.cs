namespace WildApricotTest.Pages.AdminViewPages
{
    using System;
    using System.IO;
    using System.Threading;

    using OpenQA.Selenium;

    using SeleniumExtras.PageObjects;

    using WildApricotTest.CustomMethods;

    class AdminViewPageObject
    {
        private readonly IWebDriver driver;

        public AdminViewPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        #region Admin Menu Containers Elements
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Events_Container\"]")]
        private IWebElement EventContainer { get; set; }
        #endregion

        #region Event Container Elements
        [FindsBy(How = How.Id, Using = "WaAdminPanel_AdminMenu_AdminMenuEventsEventListEventListModule_addEventBtn_buttonName")]
        private IWebElement BtnAddEvent { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"idReactRouterApp\"]/div/div/div/div/div/div/div/div/div/div[1]/a")]
        private IWebElement BtnSimpleEvent { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"idReactRouterApp\"]/div/div/div/div/div/div/div/div/div/div[2]/a")]
        private IWebElement BtnAdvancedEvent { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_viewTitle")]
        private IWebElement EventTitle { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_viewTags")]
        private IWebElement EventTags { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_viewLocation")]
        private IWebElement EventLocation { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_viewAccountTimeZone")]
        private IWebElement EventTimeZone { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_viewDateAndTimeLabel")]
        private IWebElement EventDateTime { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_viewStatusLabel")]
        private IWebElement EventStatus { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_viewAvailablePeriodLabel")]
        private IWebElement EventAvailablePeriod { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_allowGuestRegistrationsLabel")]
        private IWebElement EventGuests { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_guestRegistrationsMaxCountLabel")]
        private IWebElement EventGuestsLimit { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_cancellationBehaviorLabel")]
        private IWebElement EventCancellation { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_viewAttendeesSettings_showRegistrantsListImage")]
        private IWebElement EventShowRegistrantsListImage { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_viewAttendeesSettings_showRegistrantsListImage")]
        private IWebElement EventDoNotShowRegistrantsListImage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"eventDetailsMain_viewAttendeesSettings_trRegistrantsListVisibility\"]/td/div/span")]
        private IWebElement EventShowRegistrants { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_viewAttendeesSettings_visibilityAnyone")]
        private IWebElement EventVisibility { get; set; }
        #endregion

        #region Admin Menu Public Methods
        public void OpenAdminMenuOption(AdminMenuOptions option)
        {
            switch (option)
            {
                case AdminMenuOptions.Events:
                    Helper.CheckIfElementExists(this.driver, this.EventContainer);
                    //TODO for some reason we cant click to EventContainer when it already clickable, need deeper investigation
                    Thread.Sleep(2000);
                    this.EventContainer.Click();
                    break;
                case AdminMenuOptions.Dashboard:
                case AdminMenuOptions.Contacts:
                case AdminMenuOptions.Website:
                case AdminMenuOptions.Members:
                case AdminMenuOptions.Store:
                case AdminMenuOptions.Donations:
                case AdminMenuOptions.Finances:
                case AdminMenuOptions.Email:
                case AdminMenuOptions.Settings:
                    throw new NotImplementedException();
                default:
                    break;
            }
        }
        #endregion

        #region Event Container Public Methods
        public void CreateNewEvent(string eventType)
        {
            Helper.CheckIfElementExists(this.driver, this.BtnAddEvent);
            this.BtnAddEvent.Click();
            switch (eventType)
            {
                case "simple":
                    Helper.CheckIfElementExists(this.driver, this.BtnSimpleEvent);
                    Thread.Sleep(2000);
                    this.BtnSimpleEvent.Click();
                    break;
                case "advanced":
                    Helper.CheckIfElementExists(this.driver, this.BtnAdvancedEvent);
                    Thread.Sleep(2000);
                    this.BtnAdvancedEvent.Click();
                    break;
                default:
                    throw new InvalidDataException($"There is no event type {eventType}");
            }
        }

        public string GetNewEventDetailsText(EventDetails detailName)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            IWebElement element;
            switch (detailName)
            {
                case EventDetails.Title:
                    element = this.EventTitle;
                    break;
                case EventDetails.Tags:
                    element = this.EventTags;
                    break;
                case EventDetails.Location:
                    element = this.EventLocation;
                    break;
                case EventDetails.TimeZone:
                    element = this.EventTimeZone;
                    break;
                case EventDetails.DateTime:
                    element = this.EventDateTime;
                    break;
                case EventDetails.Status:
                    element = this.EventStatus;
                    break;
                case EventDetails.AvailablePeriod:
                    element = this.EventAvailablePeriod;
                    break;
                case EventDetails.Guests:
                    element = this.EventGuests;
                    break;
                case EventDetails.LimitGuestsTo:
                    element = this.EventGuestsLimit;
                    break;
                case EventDetails.Cancellation:
                    element = this.EventCancellation;
                    break;
                default:
                    throw new InvalidDataException($"There is no property {detailName} in simple event details");
            }
            Helper.CheckIfElementExists(this.driver, element);
            string detailText = element.Text;
            this.driver.SwitchTo().DefaultContent();
            return detailText;
        }

        public bool AreRegistrantsNotShown()
        {
            return this.IsElementOnContentFrameVisiable(this.EventDoNotShowRegistrantsListImage);
        }

        #endregion

        #region Private Methods
        //TODO move this methods to base class or to helper
        private bool IsElementOnContentFrameVisiable(IWebElement element)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementExists(this.driver, element);
            bool isVisiable = element.Displayed;
            this.driver.SwitchTo().DefaultContent();
            return isVisiable;
        }
    }
    #endregion

    #region Enums
    public enum EventDetails
    {
        Title,
        Tags,
        Location,
        TimeZone,
        DateTime,
        Status,
        AvailablePeriod,
        Guests,
        LimitGuestsTo,
        Cancellation
    }

    public enum AdminMenuOptions
    {
        Dashboard,
        Contacts,
        Website,
        Events,
        Members,
        Store,
        Donations,
        Finances,
        Email,
        Settings
    }
    #endregion
}

