using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxelleGarciaAutomationExercise.Pages
{
    class AccountCreatedPage
    {
        public AccountCreatedPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement accountCreated => Driver.FindElement(By.XPath("//b[text() = 'Account Created!']"));
        IWebElement btnContinue => Driver.FindElement(By.XPath("//a[@data-qa = 'continue-button']"));

        //Verify if Account Created is visible
        public bool isAccountCreatedVisible() => accountCreated.Displayed;

        //Click Continue button
        public void AccountCreated() => btnContinue.Click();
    }
}
