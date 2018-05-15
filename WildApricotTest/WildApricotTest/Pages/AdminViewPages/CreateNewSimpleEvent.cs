namespace WildApricotTest.Pages.AdminViewPages
{
    using System;

    using OpenQA.Selenium;

    using SeleniumExtras.PageObjects;

    using WildApricotTest.CustomMethodsForControls;

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
        #endregion

        #region PublicMethods
        public void EnterTitle(string value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.TitleTextBox);
            this.TitleTextBox.SendKeys(value);
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterTags(string value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.TagsTextBox);
            this.TagsTextBox.SendKeys(value);
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterLocation(string value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.LocationTextBox);
            this.LocationTextBox.SendKeys(value);
            this.driver.SwitchTo().DefaultContent();
        }

        public void UseDefaultOrganizationSettingsForTimeZone()
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.UseDefaultTimeZoneCheckBox);
            if (!this.UseDefaultTimeZoneCheckBox.Selected)
            {
                this.UseDefaultTimeZoneCheckBox.Submit();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        //public void UseDefaultOrganizationSettingsForTimeZone(string value)
        //{
        //    Helper.CheckIfElementIsClickable(this.driver, this.LocationTextBox);
        //    this.LocationTextBox.SendKeys(value);
        //}

        public void EnterStartDate(string value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            this.StartDateTextBox.SendKeys(value);
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterEndDate(string value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.EndDateTextBox);
            this.EndDateTextBox.SendKeys(value);
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterStartTime(int value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.TimeTextBox);
            this.TimeTextBox.SendKeys(value.ToString());
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterEndTime(int value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.EndTimeTextBox);
            this.EndTimeTextBox.SendKeys(value.ToString());
            this.driver.SwitchTo().DefaultContent();
        }

        public void ChooseStatus(bool enabled)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            if (enabled)
            {
                Helper.CheckIfElementIsClickable(this.driver, this.EnabledStatusRadioButton);
                this.EnabledStatusRadioButton.Click();
            }
            else
            {
                Helper.CheckIfElementIsClickable(this.driver, this.DisabledStatusRadioButton);
                this.DisabledStatusRadioButton.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterAvailableFromPeriod(string value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.AvailablePeriodFromTextBox);
            this.AvailablePeriodFromTextBox.SendKeys(value);
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterAvailableThroughPeriod(string value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.AvailablePeriodThroughTextBox);
            this.AvailablePeriodThroughTextBox.SendKeys(value);
            this.driver.SwitchTo().DefaultContent();
        }

        public void AllowGuestRegistration()
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.AllowGuestRegistrationsCheckBox);
            if (!this.AllowGuestRegistrationsCheckBox.Selected)
            {
                this.AllowGuestRegistrationsCheckBox.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void DisallowGuestRegistration()
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.AllowGuestRegistrationsCheckBox);
            if (this.AllowGuestRegistrationsCheckBox.Selected)
            {
                this.AllowGuestRegistrationsCheckBox.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterGuestsLimit(int value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.GuestRegistrationsMaxCountTextBox);
            this.GuestRegistrationsMaxCountTextBox.SendKeys(value.ToString());
            this.driver.SwitchTo().DefaultContent();
        }

        public void ChooseCancellationStatus(bool allowCancellation)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            if (allowCancellation)
            {
                Helper.CheckIfElementIsClickable(this.driver, this.AllowCancellationRadioButton);
                this.AllowCancellationRadioButton.Click();
            }
            else
            {
                Helper.CheckIfElementIsClickable(this.driver, this.DoNotAllowCancellationRadioButton);
                this.DoNotAllowCancellationRadioButton.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterCancellationsDaysBeforeEvent(int value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.CancellationDaysBeforeEventTextBox);
            this.CancellationDaysBeforeEventTextBox.SendKeys(value.ToString());
            this.driver.SwitchTo().DefaultContent();
        }

        public void DoNotShowRegistrants()
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.ShowRegistrantsListCheckBox);
            if (this.ShowRegistrantsListCheckBox.Selected)
            {
                this.ShowRegistrantsListCheckBox.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }
        public void ShowRegistrants(bool toEveryone)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.ShowRegistrantsListCheckBox);
            if (!this.ShowRegistrantsListCheckBox.Selected)
            {
                this.ShowRegistrantsListCheckBox.Click();
            }
            if (toEveryone)
            {
                Helper.CheckIfElementIsClickable(this.driver, this.ShowRegistrantsToEveryoneRadioButton);
                this.ShowRegistrantsToEveryoneRadioButton.Click();
            }
            else
            {
                Helper.CheckIfElementIsClickable(this.driver, this.ShowRegistrantsToMembersOnlyRadioButton);
                this.ShowRegistrantsToMembersOnlyRadioButton.Click();
            }
            this.driver.SwitchTo().DefaultContent();
        }

        public void EnterDescription(string value)
        {
            this.driver.SwitchTo().Frame("contentFrame");
            Helper.CheckIfElementIsClickable(this.driver, this.DescriptionTextBox);
            this.DescriptionTextBox.SendKeys(value);
            this.driver.SwitchTo().DefaultContent();
        }

        #endregion

    }
}

