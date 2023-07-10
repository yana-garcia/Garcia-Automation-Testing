using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RoxelleGarciaAutomationExercise.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxelleGarciaAutomationExercise.TestCases
{
    class TestCase1RegisterUser
    {
        //Browser driver
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void SetUp()
        {
            //Go to site
            webDriver.Navigate().GoToUrl("https://automationexercise.com/");
        }

        [Test]
        public void RegisterUser()
        {
            // Verify if Home Page is visible
            HomePage homePage = new HomePage(webDriver);
            Assert.That(homePage.isHomeSliderExist, Is.True);
            
            // Click Signup Link
            homePage.ClickSignup();

            // Verify if Signup Page is visible, Add Signup Details and Click Signup
            LoginPage loginPage = new LoginPage(webDriver);
            Assert.That(loginPage.isNewUserSignupVisible, Is.True);
            loginPage.Login("Yana", "yana123@gmail.com");

            // Verify if Signup Page is visible, Continue Signup Details and Click Create Account
            SignupPage signupPage = new SignupPage(webDriver);
            Assert.That(signupPage.isEnterAccInfoVisible, Is.True);
            signupPage.Signup("password123", "3", "9", "1996", "Yana", "Garcia", "Outsourced", "Saskatchewan", "Greater Saskatoon", "Canada", "Saskatoon", "Regina", "S6H7V5", "09305062382");

            // Verify if New Account Created Page is visible and Click Continue
            AccountCreatedPage accountCreatedPage = new AccountCreatedPage(webDriver);
            Assert.That(accountCreatedPage.isAccountCreatedVisible, Is.True);
            accountCreatedPage.AccountCreated();

            // Verify if New User is logged in
            Thread.Sleep(1000);
            Assert.That(homePage.isLoggedInAsVisible, Is.True);

            // Click Delete Account link
            homePage.ClickDeleteAcc();

            // Verify if Delete Account Page is visible and Click Confirm
            DeleteAccountPage deleteAccountPage = new DeleteAccountPage(webDriver);
            Assert.That(deleteAccountPage.isAccountDeletedVisible, Is.True);
            deleteAccountPage.AccountDeleted();
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
