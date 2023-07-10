using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxelleGarciaAutomationExercise.Pages
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement newUserSignupLabel => Driver.FindElement(By.XPath("//h2[text() = 'New User Signup!']"));
        IWebElement txtSignupName => Driver.FindElement(By.XPath("//input[@data-qa = 'signup-name']"));
        IWebElement txtSignupEmail => Driver.FindElement(By.XPath("//input[@data-qa = 'signup-email']"));
        IWebElement btnSignup => Driver.FindElement(By.XPath("//button[@data-qa = 'signup-button']"));

        //Verify if New User Signup is visible
        public bool isNewUserSignupVisible() => newUserSignupLabel.Displayed;

        //For Login details and Click Signup button
        public void Login(string signupName, string signupEmail)
        {
            txtSignupName.SendKeys(signupName);
            txtSignupEmail.SendKeys(signupEmail);
            btnSignup.Submit();
        }
    }
}
