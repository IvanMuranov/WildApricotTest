namespace WildApricotTest.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    using CustomMethodsForControls;

    class OrganizationHomePageObject
    {
        private readonly IWebDriver driver;

        public OrganizationHomePageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

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

        public void EnterUserNameAndPassword(string userName, string password)
        {
            Helper.CheckIfElementIsClickable(this.driver, this.LoginLink);

            //Click login link
            this.LoginLink.Click();

            //Enter user name
            this.TxtUserName.SendKeys(userName);
            //Enter password
            this.TxtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            Helper.CheckIfElementIsClickable(this.driver, this.BtnLogin);

            //Click login button
            this.BtnLogin.Click();
        }

        public void SwithToAdminViewPage()
        {
            Helper.CheckIfElementIsClickable(this.driver, this.SwtToAdminView);

            this.SwtToAdminView.Click();
        }
    }
}
