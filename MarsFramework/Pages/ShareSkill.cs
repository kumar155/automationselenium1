using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        IWebDriver driver;
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
            driver = Global.GlobalDefinitions.driver;
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add new tag'][1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//input[@name='serviceType']")]
        private IList<IWebElement> ServiceTypeOptions { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//input[@name='locationType']")]
        private IList<IWebElement> LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//input[@name='Available' and @type='checkbox']")]
        private IList<IWebElement> Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime']")]
        private IList<IWebElement> StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime']")]
        private IList<IWebElement> EndTime { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades']")]
        private IList<IWebElement> SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add new tag']")]
        private IList<IWebElement> SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive' and @type='radio']")]
        private IList<IWebElement> ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        internal void EnterShareSkill()
        {
            driver.Navigate().GoToUrl("file:///D:/desktop/automation/cssfiles/ServiceListing.html");
            //ShareSkillButton.Click();
            Title.SendKeys("HTML");
            Description.SendKeys("Good in designing and development");
            SelectElement category = new SelectElement(CategoryDropDown);
            category.SelectByText("Graphics & Design");
            Tags.SendKeys("html {ENTER}");
            Tags.SendKeys("designing {ENTER}");
            ServiceTypeOptions[0].Click();
            LocationTypeOption[0].Click();
            StartDateDropDown.SendKeys("02-03-2022");
            EndDateDropDown.SendKeys("30-03-2022");
            for (var element = 0; element < Days.Count; element++)
            {
                Days[element].Click();
                StartTime[element].SendKeys("09:30");
                EndTime[element].SendKeys("10:30");
            }
            SkillTradeOption[0].Click();
            SkillExchange[1].SendKeys("React {ENTER}");
            SkillExchange[1].SendKeys("Javascript {ENTER}");
            ActiveOption[0].Click();
            Save.Click();
        }

        internal void EditShareSkill()
        {
            
        }
    }
}
