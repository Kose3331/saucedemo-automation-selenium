using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using saucedemo_automation_selenium.Pages;


namespace saucedemo_automation_selenium.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

         protected LoginPage loginPage;
         protected InventoryPage inventoryPage;
         protected CartPage cartPage;
        protected CheckoutPage checkoutPage;
        protected HiddenMenuPage hiddenMenuPage;

        [SetUp]

        public void SetUp()
        {
            var chromeOptions = new ChromeOptions();

            
            chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);

            
            chromeOptions.AddArgument("--incognito");

           
            chromeOptions.AddArgument("--disable-notifications");

          
            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

           
            loginPage = new LoginPage(driver);
            inventoryPage = new InventoryPage(driver);
            cartPage = new CartPage(driver);
            checkoutPage = new CheckoutPage(driver);
            hiddenMenuPage = new HiddenMenuPage(driver);


        }

        [TearDown]

        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        protected void LogIn(string username, string password)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            loginPage.InputUserName(username);
            loginPage.InputPassword(password);
            loginPage.ClickLoginButton();
        }
    }
}
