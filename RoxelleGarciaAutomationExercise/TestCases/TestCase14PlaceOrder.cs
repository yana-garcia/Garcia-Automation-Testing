using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RoxelleGarciaAutomationExercise.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxelleGarciaAutomationExercise.TestCases
{
    class TestCase14PlaceOrder
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
        public void PlaceOrder()
        {
            // Verify if Home Page is visible
            HomePage homePage = new HomePage(webDriver);
            Assert.That(homePage.isHomeSliderExist, Is.True);
            Assert.IsTrue(true, "- Home Page successfully loaded!");

            // Add to Cart Items
            homePage.AddToCart1();
            homePage.AddToCart2();
            homePage.AddToCart3();
            // Click Filter Category
            homePage.ClickWomenAccordion();
            //Thread.Sleep(5000); //========= Uncomment this line if Google vignette Ads appear
            homePage.AddToCart4();

            // Click Cart button
            homePage.ClickCart();

            ViewCartPage viewCartPage = new ViewCartPage(webDriver);

            //Verify if Cart Page is visible
            Assert.That(viewCartPage.isShoppingCartBreadcrumbVisible, Is.True);
            Assert.IsTrue(true, "- Cart Page successfully loaded!");

            ProductDetailsPage productDetailsPage = new ProductDetailsPage(webDriver);

            // Update Order 1
            viewCartPage.ClickItem("/product_details/1");
            productDetailsPage.AddQty();
            productDetailsPage.CompareOrder("product-1", "Rs. 1000");

            // Update Order 2
            viewCartPage.ClickItem("/product_details/2");
            productDetailsPage.AddQty();
            productDetailsPage.CompareOrder("product-2", "Rs. 1000");

            // Update Order 3
            viewCartPage.ClickItem("/product_details/3");
            productDetailsPage.AddQty();
            productDetailsPage.CompareOrder("product-3", "Rs. 1500");

            // Update Order 4
            viewCartPage.ClickItem("/product_details/6");
            productDetailsPage.AddQty();
            productDetailsPage.CompareOrder("product-6", "Rs. 800");

            // Click Checkout and Register/Login Link in Modal
            viewCartPage.ClickCheckout();
            viewCartPage.ClickRegisterLogin();

            // Verify if Login Page is visible and Signup Details
            LoginPage loginPage = new LoginPage(webDriver);
            Assert.That(loginPage.isNewUserSignupVisible, Is.True);
            Assert.IsTrue(true, "- Login Page successfully loaded!");
            loginPage.Login("Yana", "yana456@gmail.com");

            // Continue Signup Details and Click Create Account
            SignupPage signupPage = new SignupPage(webDriver);
            Assert.That(signupPage.isEnterAccInfoVisible, Is.True);
            Assert.IsTrue(true, "- Signup Page successfully loaded!");
            signupPage.Signup("password123", "3", "9", "1996", "Yana", "Garcia", "Outsourced", "Saskatchewan", "Greater Saskatoon", "Canada", "Saskatoon", "Regina", "S6H7V5", "09305062382");

            // Verify Account Created Page and Click Continue
            AccountCreatedPage accountCreatedPage = new AccountCreatedPage(webDriver);
            Assert.That(accountCreatedPage.isAccountCreatedVisible, Is.True);
            Assert.IsTrue(true, "- New Account Created Page successfully loaded!");
            accountCreatedPage.AccountCreated();

            // Verify if User is Logged In
            Thread.Sleep(1000);
            Assert.That(homePage.isLoggedInAsVisible, Is.True);
            Assert.IsTrue(true, "- New User successfully logged in!");

            // Click Cart Link and Click Checkout button
            homePage.ClickCart();
            viewCartPage.ClickCheckout();

            // Verification of Address Details and Order Details, Add Comment and Click Place Order button
            CheckoutPage checkoutPage = new CheckoutPage(webDriver);
            checkoutPage.VerifyAddress("Mrs. Yana Garcia", "Outsourced", "Saskatchewan", "Greater Saskatoon", "Regina Saskatoon S6H7V5", "Canada", "09305062382");
            checkoutPage.VerifyOrders("Blue Top", "Men Tshirt", "Sleeveless Dress", "Summer White Top");
            checkoutPage.ClickPlaceOrder("No Comment!");

            // Payment Details and Click Confirm
            PaymentPage paymentPage = new PaymentPage(webDriver);
            paymentPage.ClickConfirmPay("Yana Garcia", "1234567890", "112", "11", "2018");

            // Verify Successful Order Placed
            PaymentDonePage paymentDonePage = new PaymentDonePage(webDriver);
            Assert.That(paymentDonePage.islabelOrderPlacedExist, Is.True);
            Assert.IsTrue(true, "Your order has been placed successfully!");
            Console.WriteLine("Your order has been placed successfully!");

            // Click Delete Account
            homePage.ClickDeleteAcc();

            // Verify Delete Page is visible and Confirm Delete
            DeleteAccountPage deleteAccountPage = new DeleteAccountPage(webDriver);
            Assert.That(deleteAccountPage.isAccountDeletedVisible, Is.True);
            Assert.IsTrue(true, "- User Account successfully deleted!");
            deleteAccountPage.AccountDeleted();
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
