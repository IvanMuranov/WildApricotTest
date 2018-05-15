namespace WildApricotTest.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    using CustomMethods;

    class OrganizationHomePageObject
    {
        private readonly IWebDriver driver;

        public OrganizationHomePageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        #region WebElements
        [FindsBy(How = How.Id, Using = "id_Y3YQQ4g_loginLink")]
        private IWebElement LoginLink { get; set; }

        [FindsBy(How = How.Id, Using = "id_Y3YQQ4g_userName")]
        private IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "id_Y3YQQ4g_password")]
        private IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "id_Y3YQQ4g_loginAction")]
        private IWebElement BtnLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"WA_switchToAdmin\"]/a[1]")]
        private IWebElement SwtToAdminView { get; set; }
        #endregion

        #region Public Methods
        public void EnterUserNameAndPassword(string userName, string password)
        {
            Helper.CheckIfElementExists(this.driver, this.LoginLink);

            this.LoginLink.Click();

            this.TxtUserName.SendKeys(userName);
            
            this.TxtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            Helper.CheckIfElementExists(this.driver, this.BtnLogin);

            this.BtnLogin.Click();
        }

        public void SwithToAdminViewPage()
        {
            Helper.CheckIfElementExists(this.driver, this.SwtToAdminView);

            this.SwtToAdminView.Click();
        }
        #endregion
    }
}
