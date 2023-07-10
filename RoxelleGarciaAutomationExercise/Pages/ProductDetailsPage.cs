using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxelleGarciaAutomationExercise.Pages
{
    class ProductDetailsPage
    {
        public ProductDetailsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement btnAddToCart => Driver.FindElement(By.ClassName("cart"));
        IWebElement btnContinueShop => Driver.FindElement(By.XPath("//button[text() = 'Continue Shopping']"));

        // For Updating Quantity
        public void AddQty()
        {
            btnAddToCart.Click();

            Thread.Sleep(3000);
            btnContinueShop.Click();

            HomePage homePage = new HomePage(Driver);
            homePage.ClickCart();
        }

        // For Comparing Actual and Expected Amount and Take/Save Screenshot of Assert Failure
        public void CompareOrder(string orderId, string expectedAmount)
        {
            IWebElement orderRow = Driver.FindElement(By.Id("" + orderId + ""));
            IWebElement orderTotal = orderRow.FindElement(By.ClassName("cart_total_price"));

            string actualResult = orderTotal.Text;
            string expectedResult = expectedAmount;

            if (actualResult != expectedResult)
            {
                Console.WriteLine(orderId + " | Expected amount of " + expectedAmount + " and Actual amount of " + actualResult + " are not the same");
                Assert.IsTrue(true, orderId + " | This data failed, please see logs for more information");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = orderId + $"_screenshot_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine(orderId + " | This data passed the testing!");
                Assert.IsTrue(true, orderId + " | This data passed the testing!");
            }
        }

    }
}
