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
    class SignupPage
    {
        public SignupPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement enterAccInfo => Driver.FindElement(By.XPath("//b[text() = 'Enter Account Information']"));
        IWebElement radioSignupTitle => Driver.FindElement(By.XPath("//div[@id = 'uniform-id_gender2']"));
        IWebElement txtSignupPassword => Driver.FindElement(By.XPath("//input[@data-qa = 'password']"));
        IWebElement selectSignupDays => Driver.FindElement(By.XPath("//select[@data-qa = 'days']"));
        IWebElement selectSignupMonths => Driver.FindElement(By.XPath("//select[@data-qa = 'months']"));
        IWebElement selectSignupYears => Driver.FindElement(By.XPath("//select[@data-qa = 'years']"));
        IWebElement checkNewsletter => Driver.FindElement(By.Id("newsletter"));
        IWebElement checkReceiveOffers => Driver.FindElement(By.Id("optin"));
        IWebElement txtSignupFirstName => Driver.FindElement(By.XPath("//input[@data-qa = 'first_name']"));
        IWebElement txtSignupLastName => Driver.FindElement(By.XPath("//input[@data-qa = 'last_name']"));
        IWebElement txtSignupCompany => Driver.FindElement(By.XPath("//input[@data-qa = 'company']"));
        IWebElement txtSignupAddress => Driver.FindElement(By.XPath("//input[@data-qa = 'address']"));
        IWebElement txtSignupAddress2 => Driver.FindElement(By.XPath("//input[@data-qa = 'address2']"));
        IWebElement selectSignupCountry => Driver.FindElement(By.XPath("//select[@data-qa = 'country']"));
        IWebElement txtSignupState => Driver.FindElement(By.XPath("//input[@data-qa = 'state']"));
        IWebElement txtSignupCity => Driver.FindElement(By.XPath("//input[@data-qa = 'city']"));
        IWebElement txtSignupZipcode => Driver.FindElement(By.XPath("//input[@data-qa = 'zipcode']"));
        IWebElement txtSignupMobileNum => Driver.FindElement(By.XPath("//input[@data-qa = 'mobile_number']"));
        IWebElement btnCreateAcc => Driver.FindElement(By.XPath("//button[@data-qa = 'create-account']"));

        //Verify if Enter Account Information is visible
        public bool isEnterAccInfoVisible() => enterAccInfo.Displayed;

        //Signup Details and Click Create Account
        public void Signup(string password, string days, string months, string years, string firstname, string lastname, string company, string address, string address2, string country, string state, string city, string zipcode, string mobilenumber)
        {

            SelectElement selectDays = new SelectElement(selectSignupDays);
            SelectElement selectMonths = new SelectElement(selectSignupMonths);
            SelectElement selectYears = new SelectElement(selectSignupYears);

            SelectElement selectCountry = new SelectElement(selectSignupCountry);

            radioSignupTitle.Click();
            txtSignupPassword.SendKeys(password);
            selectDays.SelectByValue(days);
            selectMonths.SelectByValue(months);
            selectYears.SelectByValue(years);
            checkNewsletter.Click();
            checkReceiveOffers.Click();

            txtSignupFirstName.SendKeys(firstname);
            txtSignupLastName.SendKeys(lastname);
            txtSignupCompany.SendKeys(company);
            txtSignupAddress.SendKeys(address);
            txtSignupAddress2.SendKeys(address2);
            selectCountry.SelectByValue(country);
            txtSignupState.SendKeys(state);
            txtSignupCity.SendKeys(city);
            txtSignupZipcode.SendKeys(zipcode);
            txtSignupMobileNum.SendKeys(mobilenumber);

            btnCreateAcc.Click();
        }
    }

    
}
