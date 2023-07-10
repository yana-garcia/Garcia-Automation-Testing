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
    class DeleteAccountPage
    {
        public DeleteAccountPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement accountDeleted => Driver.FindElement(By.XPath("//b[text() = 'Account Deleted!']"));
        IWebElement btnContinue => Driver.FindElement(By.XPath("//a[@data-qa = 'continue-button']"));

        //Verify if Account Created is visible
        public bool isAccountDeletedVisible() => accountDeleted.Displayed;

        //Click Continue button
        public void AccountDeleted() => btnContinue.Click();
    }
}
