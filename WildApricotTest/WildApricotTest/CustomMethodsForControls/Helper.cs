namespace WildApricotTest.CustomMethodsForControls
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Support.UI;

    using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

    class Helper
    {
        //this will search for the element until a timeout is reached
        public static IWebElement CheckIfElementIsClickable(IWebDriver driver, IWebElement element, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + element + "' was not found in current context page.");
                throw;
            }
        }
    }
}
