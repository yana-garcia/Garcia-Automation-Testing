using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RoxelleGarciaAutomationExercise.Pages
{
    class PaymentPage
    {
        public PaymentPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement txtNameCard => Driver.FindElement(By.XPath("//input[@data-qa = 'name-on-card']"));
        IWebElement txtCardNumber => Driver.FindElement(By.XPath("//input[@data-qa = 'card-number']"));
        IWebElement txtCvc => Driver.FindElement(By.XPath("//input[@data-qa = 'cvc']"));
        IWebElement txtExpiMonth => Driver.FindElement(By.XPath("//input[@data-qa = 'expiry-month']"));
        IWebElement txtExpiYear => Driver.FindElement(By.XPath("//input[@data-qa = 'expiry-year']"));
        IWebElement btnPay => Driver.FindElement(By.XPath("//button[@data-qa = 'pay-button']"));

        // For Payment Details and Click Pay button
        public void ClickConfirmPay(string cardName, string cardNum, string cardCvc, string expiMonth, string expiYear)
        {
            txtNameCard.SendKeys(cardName);
            txtCardNumber.SendKeys(cardNum);
            txtCvc.SendKeys(cardCvc);
            txtExpiMonth.SendKeys(expiMonth);
            txtExpiYear.SendKeys(expiYear);

            btnPay.Click();
        }
    }
}
