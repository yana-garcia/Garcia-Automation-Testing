using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxelleGarciaAutomationExercise.Pages
{
    class PaymentDonePage
    {
        public PaymentDonePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement labelOrderPlaced => Driver.FindElement(By.XPath("//a[@href = '/download_invoice/4600']"));

        //Verify if Invoice button exists
        public bool islabelOrderPlacedExist() => labelOrderPlaced.Displayed;
    }
}
