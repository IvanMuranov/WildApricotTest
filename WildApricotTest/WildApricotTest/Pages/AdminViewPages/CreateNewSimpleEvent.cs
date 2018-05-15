namespace WildApricotTest.Pages.AdminViewPages
{
    using System;

    using OpenQA.Selenium;

    using SeleniumExtras.PageObjects;

    using WildApricotTest.CustomMethods;

    class CreateNewSimpleEvent
    {
        private readonly IWebDriver driver;

        public CreateNewSimpleEvent(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        #region WebElements
        [FindsBy(How = How.XPath, Using = "//*[@id=\"accessControlLink\"]")]
        private IWebElement AccessControlLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"eventDetailsShowLink\"]/a")]
        private IWebElement EventDetailsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"eventEmailsShowLink\"]/a")]
        private IWebElement EmailsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#eventDetailsMain_editTitle")]
        private IWebElement TitleTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editTags")]
        private IWebElement TagsTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editLocation")]
        private IWebElement LocationTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editUseDefaultTimeZone")]
        private IWebElement UseDefaultTimeZoneCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editTimeZone")]
        private IWebElement TimeZoneBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editDate")]
        private IWebElement StartDateTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editEndDate")]
        private IWebElement EndDateTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editTime")]
        private IWebElement TimeTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editEndTime")]
        private IWebElement EndTimeTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_statusRadioButtonList_0")]
        private IWebElement EnabledStatusRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_statusRadioButtonList_1")]
        private IWebElement DisabledStatusRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_availablePeriodStartDate")]
        private IWebElement AvailablePeriodFromTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_availablePeriodEndDate")]
        private IWebElement AvailablePeriodThroughTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "allowCollectTotalNumberOfGuestRegistrationsCheckBox")]
        private IWebElement AllowGuestRegistrationsCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "guestRegistrationsMaxCountTextBox")]
        private IWebElement GuestRegistrationsMaxCountTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "cancellationDoNotAllowRadioButton")]
        private IWebElement DoNotAllowCancellationRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "cancellationAllowRadioButton")]
        private IWebElement AllowCancellationRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "cancellationDaysBeforeEventTextBox")]
        private IWebElement CancellationDaysBeforeEventTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editAttendeesSettings_showRegistrantsList")]
        private IWebElement ShowRegistrantsListCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editAttendeesSettings_visibilityAnyone")]
        private IWebElement ShowRegistrantsToEveryoneRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editAttendeesSettings_visibilityMembers")]
        private IWebElement ShowRegistrantsToMembersOnlyRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"idPrimaryContentBlock1Content\"]")]
        private IWebElement DescriptionTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "toolbarButtons_button_publishButton_buttonName")]
        private IWebElement SaveSimpleEventButton { get; set; }
        
        [FindsBy(How = How.Id, Using = "eventDetailsMain_registrationTypePeriodValidator")]
        private IWebElement RegistrationTypePeriodValidator { get; set; }

        [FindsBy(How = How.Id, Using = "eventDetailsMain_editEndDateCustom")]
        private IWebElement EndDateValidator { get; set; }
        #endregion

        #region Public Methods
        public void EnterTitle(string value)
        {
            this.EnterTextInElementOnContentFrame(value, this.TitleTextBox);
        }

        public void EnterTags(string value)
        {
            this.EnterTextInElementOnContentFrame(value, this.TagsTextBox);
        }

        public void EnterLocation(string value)
        {
            this.EnterTextInElementOnContentFrame(value, this.LocationTextBox);
        }

        public void UseDefaultOrganizationSettingsForTimeZone()
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementExists(this.driver, this.UseDefaultTimeZoneCheckBox);
            if (!this.UseDefaultTimeZoneCheckBox.Selected)
            {
                this.UseDefaultTimeZoneCheckBox.Submit();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterStartDate(string value)
        {
            this.EnterTextInElementOnContentFrame(value, this.StartDateTextBox);
        }

        public void EnterEndDate(string value)
        {
            this.EnterTextInElementOnContentFrame(value, this.EndDateTextBox);
        }

        public void EnterStartTime(string value)
        {
            this.EnterTextInElementOnContentFrame(value, this.TimeTextBox);
        }

        public void EnterEndTime(string value)
        {
            this.EnterTextInElementOnContentFrame(value, this.EndTimeTextBox);
        }

        public void ChooseStatus(bool enabled)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            if (enabled)
            {
                Helper.CheckIfElementExists(this.driver, this.EnabledStatusRadioButton);
                this.EnabledStatusRadioButton.Click();
            }
            else
            {
                Helper.CheckIfElementExists(this.driver, this.DisabledStatusRadioButton);
                this.DisabledStatusRadioButton.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterAvailableFromPeriod(string value)
        {
            this.EnterTextInElementOnContentFrame(value, this.AvailablePeriodFromTextBox);
        }

        public void EnterAvailableThroughPeriod(string value)
        {
            this.EnterTextInElementOnContentFrame(value, this.AvailablePeriodThroughTextBox);
        }

        public void AllowGuestRegistration()
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementExists(this.driver, this.AllowGuestRegistrationsCheckBox);
            if (!this.AllowGuestRegistrationsCheckBox.Selected)
            {
                this.AllowGuestRegistrationsCheckBox.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void DisallowGuestRegistration()
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementExists(this.driver, this.AllowGuestRegistrationsCheckBox);
            if (this.AllowGuestRegistrationsCheckBox.Selected)
            {
                this.AllowGuestRegistrationsCheckBox.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterGuestsLimit(int value)
        {
            this.EnterTextInElementOnContentFrame(value.ToString(), this.GuestRegistrationsMaxCountTextBox);
        }

        public void ChooseCancellationStatus(bool allowCancellation)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            if (allowCancellation)
            {
                Helper.CheckIfElementExists(this.driver, this.AllowCancellationRadioButton);
                this.AllowCancellationRadioButton.Click();
            }
            else
            {
                Helper.CheckIfElementExists(this.driver, this.DoNotAllowCancellationRadioButton);
                this.DoNotAllowCancellationRadioButton.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterCancellationsDaysBeforeEvent(int value)
        {
            this.EnterTextInElementOnContentFrame(value.ToString(), this.CancellationDaysBeforeEventTextBox);
        }

        public void DoNotShowRegistrants()
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementExists(this.driver, this.ShowRegistrantsListCheckBox);
            if (this.ShowRegistrantsListCheckBox.Selected)
            {
                this.ShowRegistrantsListCheckBox.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }
        public void ShowRegistrants(bool toEveryone)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementExists(this.driver, this.ShowRegistrantsListCheckBox);
            if (!this.ShowRegistrantsListCheckBox.Selected)
            {
                this.ShowRegistrantsListCheckBox.Click();
            }
            if (toEveryone)
            {
                Helper.CheckIfElementExists(this.driver, this.ShowRegistrantsToEveryoneRadioButton);
                this.ShowRegistrantsToEveryoneRadioButton.Click();
            }
            else
            {
                Helper.CheckIfElementExists(this.driver, this.ShowRegistrantsToMembersOnlyRadioButton);
                this.ShowRegistrantsToMembersOnlyRadioButton.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void SaveNewSimpleEvent()
        {
            Helper.CheckIfElementExists(this.driver, this.SaveSimpleEventButton);
            this.SaveSimpleEventButton.Click();
        }

        public bool IsRegistrationTypePeriodValidatorVisiable()
        {
            return this.IsElementOnContentFrameVisiable(this.RegistrationTypePeriodValidator);
        }
        
        public bool IsEndDateValidatorVisiable()
        {
            return this.IsElementOnContentFrameVisiable(this.EndDateValidator);
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

        private void EnterTextInElementOnContentFrame(string value, IWebElement element)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementExists(this.driver, element);
            element.SendKeys(value);
            this.driver.SwitchTo().DefaultContent();
        }

        #endregion
    }
}

