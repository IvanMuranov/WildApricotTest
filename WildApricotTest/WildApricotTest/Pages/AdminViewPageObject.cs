namespace WildApricotTest.Pages
{
    using System;

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

        public void OpenAdminMenuOption(AdminMenuOptions option)
        {
            switch (option)
            {
                case AdminMenuOptions.Events:
                    Helper.CheckIfElementIsClickable(this.driver, this.EventContainer);
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

        public void ClickCreateNewEventBtn()
        {
            Helper.CheckIfElementIsClickable(this.driver, this.BtnAddEvent);
            this.BtnAddEvent.Click();
            
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

