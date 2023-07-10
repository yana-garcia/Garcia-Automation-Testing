using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxelleGarciaAutomationExercise.Pages
{
    class ViewCartPage
    {
        public ViewCartPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement labelShopCart => Driver.FindElement(By.XPath("//li[text() = 'Shopping Cart']"));
        IWebElement linkCheckout => Driver.FindElement(By.LinkText("Proceed To Checkout"));
        IWebElement linkRegLogin => Driver.FindElement(By.XPath("//u[text() = 'Register / Login']"));
        
        //Verify if Shopping Cart Breadcrumb is visible
        public bool isShoppingCartBreadcrumbVisible() => labelShopCart.Displayed;

        //Click Item
        public void ClickItem(string orderLink) => Driver.FindElement(By.XPath("//a[@href = '" + orderLink + "']")).Click();

        //Click Checkout
        public void ClickCheckout() => linkCheckout.Click();

        //Click Register/Login in Modal
        public void ClickRegisterLogin()
        {
            Thread.Sleep(3000);
            linkRegLogin.Click();
        }
    }
}
