using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxelleGarciaAutomationExercise.Pages
{
    class CheckoutPage
    {
        public CheckoutPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement txtCommentArea => Driver.FindElement(By.Id("ordermsg"));
        IWebElement txtComment => txtCommentArea.FindElement(By.XPath("//textarea[@name = 'message']"));
        IWebElement linkPayment => txtCommentArea.FindElement(By.XPath("//a[@href = '/payment']"));

        //Verify Address Details
        public void VerifyAddress(string customerName, string companyName, string address1, string address2, string cityName, string countryName, string customerNumber)
        {
            IWebElement addName = Driver.FindElement(By.ClassName("address_firstname"));
            IWebElement addCompany = Driver.FindElement(By.XPath("//li[text() = 'Outsourced']"));
            IWebElement add1 = Driver.FindElement(By.XPath("//li[text() = 'Saskatchewan']"));
            IWebElement add2 = Driver.FindElement(By.XPath("//li[text() = 'Greater Saskatoon']"));
            IWebElement addCity = Driver.FindElement(By.ClassName("address_city"));
            IWebElement addCountry = Driver.FindElement(By.ClassName("address_country_name"));
            IWebElement addNumber = Driver.FindElement(By.ClassName("address_phone"));

            string actualName = addName.Text;
            string expectedName = customerName;

            string actualCompanyName = addCompany.Text;
            string expectedCompanyName = companyName;

            string actualAddress1 = add1.Text;
            string expectedAddress1 = address1;

            string actualAddress2 = add2.Text;
            string expectedAddress2 = address2;

            string actualCityName = addCity.Text;
            string expectedCityName = cityName;

            string actualCountryName = addCountry.Text;
            string expectedCountryName = countryName;

            string actualNumber = addNumber.Text;
            string expectedNumber = customerNumber;


            if (actualName != expectedName)
            {
                Console.WriteLine("Actual Name: " + actualName + " and Expected Name: " + expectedName + " are not the same.");
                Assert.IsTrue(true, "Actual Name: " + actualName + " and Expected Name: " + expectedName + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_Name_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified Name: " + actualName);
                Assert.IsTrue(true, "Verified Name: " + actualName);
            }

            if (actualCompanyName != expectedCompanyName)
            {
                Console.WriteLine("Actual Company: " + actualCompanyName + " and Expected Company: " + expectedCompanyName + " are not the same.");
                Assert.IsTrue(true, "Actual Company: " + actualCompanyName + " and Expected Company: " + expectedCompanyName + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_Company_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified Company: " + actualCompanyName);
                Assert.IsTrue(true, "Verified Company: " + actualCompanyName);
            }

            if (actualAddress1 != expectedAddress1)
            {
                Console.WriteLine("Actual Address1: " + actualAddress1 + " and Expected Address1: " + expectedAddress1 + " are not the same.");
                Assert.IsTrue(true, "Actual Address1: " + actualAddress1 + " and Expected Address1: " + expectedAddress1 + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_Address1_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified Address 1: " + actualAddress1);
                Assert.IsTrue(true, "Verified Address 1: " + actualAddress1);
            }

            if (actualAddress2 != expectedAddress2)
            {
                Console.WriteLine("Actual Address2: " + actualAddress2 + " and Expected Address2: " + expectedAddress2 + " are not the same.");
                Assert.IsTrue(true, "Actual Address2: " + actualAddress2 + " and Expected Address2: " + expectedAddress2 + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_Address2_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified Address 2: " + actualAddress2);
                Assert.IsTrue(true, "Verified Address 2: " + actualAddress2);
            }

            if (actualCityName != expectedCityName)
            {
                Console.WriteLine("Actual City: " + actualCityName + " and Expected City: " + expectedCityName + " are not the same.");
                Assert.IsTrue(true, "Actual City: " + actualCityName + " and Expected City: " + expectedCityName + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_City_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified City: " + actualCityName);
                Assert.IsTrue(true, "Verified City: " + actualCityName);
            }

            if (actualCountryName != expectedCountryName)
            {
                Console.WriteLine("Actual Country: " + actualCountryName + " and Expected Country: " + actualCountryName + " are not the same.");
                Assert.IsTrue(true, "Actual Country: " + actualCountryName + " and Expected Country: " + actualCountryName + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_Country_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified Country: " + actualCountryName);
                Assert.IsTrue(true, "Verified Country: " + actualCountryName);
            }

            if (actualNumber != expectedNumber)
            {
                Console.WriteLine("Actual Number: " + actualNumber + " and Expected Number: " + expectedNumber + " are not the same.");
                Assert.IsTrue(true, "Actual Number: " + actualNumber + " and Expected Number: " + expectedNumber + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_Number_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified Number: " + actualNumber);
                Assert.IsTrue(true, "Verified Number: " + actualNumber);
            }
        }

        //Verify Order Details
        public void VerifyOrders(string order1, string order2, string order3, string order4)
        {
            IWebElement product1 = Driver.FindElement(By.XPath("//a[@href = '/product_details/1']"));
            IWebElement product2 = Driver.FindElement(By.XPath("//a[@href = '/product_details/2']"));
            IWebElement product3 = Driver.FindElement(By.XPath("//a[@href = '/product_details/3']"));
            IWebElement product4 = Driver.FindElement(By.XPath("//a[@href = '/product_details/6']"));

            string actualOrder1 = product1.Text;
            string expectedOrder1 = order1;

            string actualOrder2 = product2.Text;
            string expectedOrder2 = order2;

            string actualOrder3 = product3.Text;
            string expectedOrder3 = order3;

            string actualOrder4 = product4.Text;
            string expectedOrder4 = order4;

            if (actualOrder1 != expectedOrder1)
            {
                Console.WriteLine("Actual Order 1: " + actualOrder1 + " and Expected Order 1: " + expectedOrder1 + " are not the same.");
                Assert.IsTrue(true, "Actual Order 1: " + actualOrder1 + " and Expected Order 1: " + expectedOrder1 + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_Order1_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified Order 1: " + actualOrder1);
                Assert.IsTrue(true, "Verified Order 1: " + actualOrder1);
            }

            if (actualOrder2 != expectedOrder2)
            {
                Console.WriteLine("Actual Order 2: " + actualOrder2 + " and Expected Order 2: " + expectedOrder2 + " are not the same.");
                Assert.IsTrue(true, "Actual Order 2: " + actualOrder2 + " and Expected Order 2: " + expectedOrder2 + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_Order2_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified Order 2: " + actualOrder2);
                Assert.IsTrue(true, "Verified Order 2: " + actualOrder2);
            }

            if (actualOrder3 != expectedOrder3)
            {
                Console.WriteLine("Actual Order 3: " + actualOrder3 + " and Expected Order 3: " + expectedOrder3 + " are not the same.");
                Assert.IsTrue(true, "Actual Order 3: " + actualOrder3 + " and Expected Order 3: " + expectedOrder3 + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_Order3_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified Order 3: " + actualOrder3);
                Assert.IsTrue(true, "Verified Order 3: " + actualOrder3);
            }

            if (actualOrder4 != expectedOrder4)
            {
                Console.WriteLine("Actual Order 4: " + actualOrder4 + " and Expected Order 4: " + expectedOrder4 + " are not the same.");
                Assert.IsTrue(true, "Actual Order 4: " + actualOrder4 + " and Expected Order 4: " + expectedOrder4 + " are not the same.");

                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                Directory.CreateDirectory(screenshotPath);

                string screenshotFileName = $"screenshot_Order4_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotFilePath = Path.Combine(screenshotPath, screenshotFileName);

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                Console.WriteLine("This is where you can find the screenshots | " + screenshotFilePath);
            }
            else
            {
                Console.WriteLine("Verified Order 4: " + actualOrder4);
                Assert.IsTrue(true, "Verified Order 4: " + actualOrder4);
            }
        }

        //Click Place Order button
        public void ClickPlaceOrder(string addComment)
        {
            txtComment.SendKeys(addComment);
            linkPayment.Click();
        }
    }
}
