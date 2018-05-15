namespace WildApricotTest.Pages.AdminViewPages
{
    using System;
    using System.IO;
    using System.Threading;

    using OpenQA.Selenium;

    using SeleniumExtras.PageObjects;

    using WildApricotTest.CustomMethodsForControls;

    class AdminViewPageObject
    {
        private readonly IWebDriver driver;

        public AdminViewPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"Events_Container\"]")]
        private IWebElement EventContainer { get; set; }

        [FindsBy(How = How.Id, Using = "WaAdminPanel_AdminMenu_AdminMenuEventsEventListEventListModule_addEventBtn_buttonName")]
        private IWebElement BtnAddEvent { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"idReactRouterApp\"]/div/div/div/div/div/div/div/div/div/div[1]/a")]
        private IWebElement BtnSimpleEvent { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"idReactRouterApp\"]/div/div/div/div/div/div/div/div/div/div[2]/a")]
        private IWebElement BtnAdvancedEvent { get; set; }

        public void OpenAdminMenuOption(AdminMenuOptions option)
        {
            switch (option)
            {
                case AdminMenuOptions.Events:
                    Helper.CheckIfElementIsClickable(this.driver, this.EventContainer);
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

        public void CreateNewEvent(string eventType)
        {
            Helper.CheckIfElementIsClickable(this.driver, this.BtnAddEvent);
            this.BtnAddEvent.Click();
            switch (eventType)
            {
                case "simple":
                    Helper.CheckIfElementIsClickable(this.driver, this.BtnSimpleEvent);
                    Thread.Sleep(2000);
                    this.BtnSimpleEvent.Click();
                    break;
                case "advanced":
                    Helper.CheckIfElementIsClickable(this.driver, this.BtnAdvancedEvent);
                    Thread.Sleep(2000);
                    this.BtnAdvancedEvent.Click();
                    break;
                default:
                    throw new InvalidDataException($"There is no event type {eventType}");
            }
        }
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
}

