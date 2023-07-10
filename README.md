## Welcome to Automation Testing with Selenium C#

### **How to use the Project**
1.  Open a ***Microsoft Visual Studio***
2.  Click ***Clone a repository***
3.  In the *Clone a repository* window, insert https://github.com/yana-garcia/Garcia-Automation-Testing.git in ***Repository location*** textbox
4.  Click ***Clone*** button
5.  Open the *Test Explorer* window
     -  Click *Window* tab 
     -  Click ***Test Explorer***
6.  In *Test Explorer* tab, click ***Run All Tests in View***

<hr>

### **How to Setup Environment**
1.  Install ***Microsoft Visual Studio Community 2022 (64-bit) - Current Version 17.6.4***
2.  Click ***Create New Project***
3.  Select ***C#*** in Language dropdown
4.  Select ***NUnit Test Project*** in Project Templates
5.  Click ***Next*** button and Configure your new project details
6.  In the *Additional Information* window, Select ***.NET 6.0 (Long Term Support)*** in Framework dropdown
7.  Click ***Create*** button

<hr>

### **What are the Dependencies needed**
1.  In *Solution Explorer*, Right Click ***Dependencies***
2.  Click ***Manage NuGet Packages...***
3.  Click ***Browse*** tab
4.  Search and Install the following packages
     -  Selenium.WebDriver v4.10.0
     -  Selenium.Support v4.10.0
     -  Selenium.WebDriver.ChromeDriver v114.0.5735.9000
     -  RestSharp v110.2.0
     -  Newtonsoft.Json v13.0.3

<hr>

### ***Things to Remember***
1.  In testing the Test Case 1 and Test Case 14, there are some randomly google_vignette ads that are appearing in full screen in https://www.automationexercise.com/

    Note: If it ever happens, uncomment the timeout code in [testcase].cs, to have a 5 seconds buffer to close the ads. And the testing will proceed.
    ```
    Thread.Sleep(5000);
    ```
3.  Screenshots for the failure screen in exception handling are located in folder:

    ***\RoxelleGarciaAutomationExercise\RoxelleGarciaAutomationExercise\bin\Debug\net6.0\Screenshots***
4.  I have added a failed comparison in the test case to test the *exception handling and capture screenshots* during the process of **Updating the quantity of the products**. The comparison between the actual total amount and the expected total amount of two items does not match, allowing for the testing of the exception handling.

### ***Notes***
1.  This is the first time I have created test scripts and a test environment in general, but I have been working as a UI developer for 7 years. Although I don't have much experience in automation, I am confident that I can learn and improve my skills in coding automation scripts if given the opportunity.
2.  The most challenging part in testing is the google vignette ads, it consumed more moments for the test to continue and passed.
3.  I used **Page Object Model** approach in developing, to reuse scripts in other test cases and to make it maintainable.
4.  In updating quantity in Orders, I encountered some issue. First is you cannot update the quantity in **Cart Page**, the only thing that can do in Cart Page is removing the Item. I saw a workaround in updating the quantity by clicking the Item itself and adding quantity in **Product Details Page**.
5.  I also encountered an issue in updating the quantity in **Product Details Page**. It seems like the actual total quantity of the Item in the Product Details Page is not reflecting when you click the Item from the Cart Page. The quantity in the Product Details Page is by default 1 even if you click it from the Cart Page. But the actual quantity in Cart Page is correct when you add to cart or update the quantity from the Product Details Page.
     -  For example:
     -  Cart Page | Item A Quantity: 2
     -  *(Click Item A from Cart Page to update quantity)*
     -  Product Details Page | Item A Quantity: 1 *(still 1 not 2)*
     -  *(But when you add to cart from Product Details Page, it will add and reflect to the Cart Page)*
6.  I haven't finished yet the API testing, as time has been a challenge too, also for learning new tools and creating test cases. Hopefully you will consider my application even though I haven't finished all of the tests.
7.  Thank you very much, and best of luck :) 
