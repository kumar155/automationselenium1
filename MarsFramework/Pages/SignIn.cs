using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MarsFramework.Pages
{
    class SignIn
    {
        IWebDriver driver;
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
            driver = Global.GlobalDefinitions.driver;
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            // driver.Navigate().GoToUrl("file:///D:/desktop/automation/cssfiles/ServiceListing.html");
            SignIntab.Click();
            Email.SendKeys("email");
            Password.SendKeys("password");
            LoginBtn.Click();
        }
    }
}