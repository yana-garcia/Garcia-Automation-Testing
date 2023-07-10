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
    public class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver {  get; }

        public IWebElement linkSignup => Driver.FindElement(By.XPath("//a[@href = '/login']"));

        // For Register User
        IWebElement homeSlider => Driver.FindElement(By.Id("slider-carousel"));
        IWebElement loggedInAs => Driver.FindElement(By.XPath("//a[contains(., 'Logged in as')]"));
        IWebElement linkDelete => Driver.FindElement(By.XPath("//a[@href = '/delete_account']"));

        // For Place Order
        IWebElement accordionWomen => Driver.FindElement(By.XPath("//a[@href = '#Women']"));
        IWebElement btnContinueShop => Driver.FindElement(By.XPath("//button[text() = 'Continue Shopping']"));
        IWebElement linkCart => Driver.FindElement(By.XPath("//a[@href = '/view_cart']"));

        // For Register User
        public void ClickSignup() => linkSignup.Click();

        //Verify if Home page is visible
        public bool isHomeSliderExist() => homeSlider.Displayed;

        //Verify if Logged in as is visible
        public bool isLoggedInAsVisible() => loggedInAs.Displayed;

        //Click Delete Account link
        public void ClickDeleteAcc() => linkDelete.Click();


        //For Place Order
        //Click Cart Link
        public void ClickCart() => linkCart.Click();

        //Order 1
        public void AddToCart1()
        {
            Driver.FindElement(By.XPath("//a[@data-product-id = '1']")).Click();

            Thread.Sleep(3000);
            btnContinueShop.Click();
        }

        //Order 2
        public void AddToCart2()
        {
            Driver.FindElement(By.XPath("//a[@data-product-id = '2']")).Click();

            Thread.Sleep(3000);
            btnContinueShop.Click();
        }

        //Order 3
        public void AddToCart3()
        {
            Driver.FindElement(By.XPath("//a[@data-product-id = '3']")).Click();

            Thread.Sleep(3000);
            btnContinueShop.Click();
        }

        //Filter Category
        public void ClickWomenAccordion()
        {
            accordionWomen.Click();

            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[@href = '/category_products/2']")).Click();
        }

        //Order 4
        public void AddToCart4()
        {
            Driver.FindElement(By.XPath("//a[@data-product-id = '6']")).Click();

            Thread.Sleep(3000);
            btnContinueShop.Click();
        }
    }
}
